namespace PacMan1
{
    public interface IScene
    {
        void PrintMap();
        void Update(IGameObject[] gameObjects);
    }
}