namespace MazeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, To Maze Game!");
            Console.WriteLine("Use Arrows To Move The Player");
            Maze maze = new Maze(40, 20);
            maze.DrawMaze();
            while (true)
            {
                maze.MovePlayer();
            }

        }
    }
}
