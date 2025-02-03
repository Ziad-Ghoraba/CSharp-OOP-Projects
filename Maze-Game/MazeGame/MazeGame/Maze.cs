using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        private int width;
        private int height;
        private Player player;
        private IMazeObject[,] mazeObjectsArray;

        public Maze(int width, int height)
        {
            this.width = width;
            this.height = height;
            mazeObjectsArray = new IMazeObject[width, height];
            player = new Player()
            {
                X = 1,
                Y = 1
            };
            

        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(x == width-1 && y == height-2)
                    {
                        mazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(mazeObjectsArray[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || x == width-1 || y == height-1)
                    {
                        mazeObjectsArray[x, y] = new Wall();
                        Console.Write(mazeObjectsArray[x, y].Icon);
                    }
                    else if(x == player.X && y == player.Y)
                    {
                        mazeObjectsArray[player.X, player.Y] = new Player();
                        Console.Write(mazeObjectsArray[player.X, player.Y].Icon);
                    }
                    else if(x%3 == 0 && y%3 == 0)
                    {
                        mazeObjectsArray[x, y] = new Wall();
                        Console.Write(mazeObjectsArray[x, y].Icon);
                    }
                    else if (x== 1 && y %2 == 0)
                    {
                        mazeObjectsArray[x, y] = new Wall();
                        Console.Write(mazeObjectsArray[x, y].Icon);
                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {
                        mazeObjectsArray[x, y] = new Wall();
                        Console.Write(mazeObjectsArray[x, y].Icon);
                    }
                    else
                    {
                        mazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(mazeObjectsArray[x, y].Icon);
                    }
                    
                    
                }
                Console.WriteLine();
            }
            
        }



        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            ConsoleKey key = userInput.Key;

            switch(key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
            }
            DrawMaze();
        }

        private void UpdatePlayer(int dx, int dy)
        {
            int newX = player.X + dx;
            int newY = player.Y + dy;
            if(newX < width && newX >=0 && newY <height && newY >= 0 && !mazeObjectsArray[newX, newY].IsSolid)
            {
                player.X = newX;
                player.Y = newY;
            }
        }
    }
}
