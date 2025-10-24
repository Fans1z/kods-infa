using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan1
{
    public class Scene
    {
        private Tyle[,] _map;
        private string[] _textFile;

        public Scene(string path)
        {
            _textFile = GetTextFile(path);
            _map = GetMap(_textFile);
        }

        public void Update(IGameObject[] gameObjects)
        {
            for (int x = 0; x < _map.GetLength(0); x++)
                for (int y = 0; y < _map.GetLength(1); y++)
                    _map[x, y].AddGameObject(gameObjects);
        }

        public void PrintMap()
        {
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(_map[x, y].Symbol);
                }
            }

        }

        private string[] GetTextFile(string path)
        {
            return File.ReadAllLines(path);
        }

        private Tyle[,] GetMap(string[] textFile)
        {
            const char SymbolWall = '#';
            const char SymbolEmptyCell = ' ';
            const int KyeWall = 1;
            const int KyeEmptyCell = 0;

            Tyle[,] tyles = new Tyle[textFile.Length, GetMaxOfLine(textFile)];

            for (int x = 0; x < textFile.Length; x++)
            {
                for (int y = 0; y < textFile[x].Length; y++)
                {
                    switch (Convert.ToInt32(textFile[x][y]))
                    {
                        case KyeWall:
                            tyles[x, y] = new Tyle(new Vector(x, y), Convert.ToInt32(textFile[x][y]), SymbolWall);
                            break;
                        case KyeEmptyCell:
                            tyles[x, y] = new Tyle(new Vector(x, y), Convert.ToInt32(textFile[x][y]), SymbolEmptyCell);
                            break;
                    }
                }
            }

            return tyles;
        }

        private int GetMaxOfLine(string[] strings)
        {
            int maxLength = 0;

            foreach (string line in strings)
                if (line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;
        }

        internal bool IsWall(Vector position)
        {
            throw new NotImplementedException();
        }
    }
}