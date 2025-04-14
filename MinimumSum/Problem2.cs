//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MinimumSum
//{

//    using System;
//    using System.Collections.Generic;

//    class Program
//    {
//        static int[] dx = { 1, 0, -1, 0 };
//        static int[] dy = { 0, 1, 0, -1 };

//        static bool CanReachDestination(char[,] grid, int sx, int sy, int dx, int dy)
//        {
//            int m = grid.GetLength(0);
//            int n = grid.GetLength(1);

//            // Create a visited matrix to keep track of visited cells
//            bool[,] visited = new bool[m, n];

//            // Create a queue for BFS
//            Queue<(int, int)> queue = new Queue<(int, int)>();
//            queue.Enqueue((sx - 1, sy - 1));
//            visited[sx - 1, sy - 1] = true;

//            while (queue.Count > 0)
//            {
//                (int x, int y) = queue.Dequeue();

//                // Check if the current cell is the destination
//                if (x == dx - 1 && y == dy - 1)
//                    return true;

//                // Explore adjacent cells
//                for (int i = 0; i < 4; i++)
//                {
//                    int newX = x + dx[i];
//                    int newY = y + dy[i];

//                    // Check if the new cell is within the grid and not visited
//                    if (newX >= 0 && newX < m && newY >= 0 && newY < n && !visited[newX, newY])
//                    {
//                        // If the new cell is blocked by a hollow block, try to break it
//                        if (grid[newX, newY] == '*')
//                        {
//                            // Check if the block can be broken by hitting it from both sides
//                            bool canBreak = false;
//                            for (int j = 0; j < 4; j++)
//                            {
//                                int neighborX = newX + dx[j];
//                                int neighborY = newY + dy[j];

//                                if (neighborX >= 0 && neighborX < m && neighborY >= 0 && neighborY < n && visited[neighborX, neighborY])
//                                {
//                                    canBreak = true;
//                                    break;
//                                }
//                            }

//                            if (canBreak)
//                            {
//                                grid[newX, newY] = '.';
//                                queue.Enqueue((newX, newY));
//                                visited[newX, newY] = true;
//                            }
//                        }
//                        else
//                        {
//                            queue.Enqueue((newX, newY));
//                            visited[newX, newY] = true;
//                        }
//                    }
//                }
//            }

//            return false;
//        }

//        static void Main3(string[] args)
//        {
//            int m = int.Parse(Console.ReadLine());
//            int n = int.Parse(Console.ReadLine());

//            char[,] grid = new char[m, n];
//            for (int i = 0; i < m; i++)
//            {
//                string line = Console.ReadLine();
//                for (int j = 0; j < n; j++)
//                {
//                    grid[i, j] = line[j];
//                }
//            }

//            int sx = int.Parse(Console.ReadLine());
//            int sy = int.Parse(Console.ReadLine());
//            int dx = int.Parse(Console.ReadLine());
//            int dy = int.Parse(Console.ReadLine());

//            if (CanReachDestination(grid, sx, sy, dx, dy))
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }
//}
