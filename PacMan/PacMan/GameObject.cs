using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan1
{
    public abstract class GameObject
    {
        protected const int KeyDirectionUp = 1;
        protected const int KeyDirectionDown = 2;
        protected const int KeyDirectionLeft = 3;
        protected const int KeyDirectionRight = 4;

        protected const int moveUp = 1;
        protected const int moveDown = -1;
        protected const int moveStop = 0;

        private Scene _scene;


        public GameObject(Vector position, char symbol, Scene scene)
        {
            Position = position;
            Symbol = symbol;
            _scene = scene;
        }

        public Vector Position { get; private set; }

        public char Symbol { get; private set; }

        public abstract void Update();

        public void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(Symbol);
        }

        protected void ToChangePosition(Vector move)
        {
            Vector oldPosition = Position;
            Position += move;

            if (_scene.IsWall(Position))
                Position = oldPosition;
        }

    }
}