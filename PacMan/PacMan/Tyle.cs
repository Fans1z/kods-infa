using PacMan1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PacMan1
{
    public class Tyle : IGameObject
    {
        private IGameObject _gameObject;

        public Tyle(Vector position, int kye, char symbol = ' ')
        {
            Position = position;
            _gameObject = null;
            Symbol = symbol;

            if (kye == 0)
                IsWall = false;
            else
                IsWall = true;
        }

        public Vector Position { get; private set; }

        public bool IsOpen => _gameObject == null;

        public bool IsWall { get; private set; }

        public char Symbol { get; private set; }

        public void AddGameObject(IGameObject[] gameObjects)
        {
            foreach (IGameObject @object in gameObjects)
            {
                if (@object.Position == Position)
                {
                    _gameObject = @object;
                    break;
                }
                else
                {
                    _gameObject = null;
                }
            }
        }
    }
}
