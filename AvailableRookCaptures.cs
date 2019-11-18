            public class Solution
        {
            public int NumRookCaptures(char[][] board)
            {
                int rookY = 0;
                int rookX = 0;
                int hits = 0;

                for (int y = 0; y < board.Length; y++)
                {
                    for (int x = 0; x < board[y].Length; x++)
                    {
                        Console.Write(board[y][x]);
                        if (board[y][x] == 'R')
                        {
                            rookX = x;
                            rookY = y;
                        }
                    }
                    Console.WriteLine();
                }

                int scanX = rookX;
                int scanY = rookY;
                bool stopScan = false;
                while (scanX >= 0 && scanX < 8 && scanY >= 0 && scanY < 8 && !stopScan)
                {
                    Console.WriteLine("scanning: " + scanX + ", " + scanY);
                    if (board[scanY][scanX] == 'B')
                    {
                        stopScan = true;
                    }
                    if (board[scanY][scanX] == 'p')
                    {
                        hits++;
                        stopScan = true;
                    }
                    scanY--;
                }

                scanX = rookX;
                scanY = rookY;
                stopScan = false;
                while (scanX >= 0 && scanX < 8 && scanY >= 0 && scanY < 8 && !stopScan)
                {
                    Console.WriteLine("scanning: " + scanX + ", " + scanY);
                    if (board[scanY][scanX] == 'B')
                    {
                        stopScan = true;
                    }
                    if (board[scanY][scanX] == 'p')
                    {
                        hits++;
                        stopScan = true;
                    }
                    scanY++;
                }

                scanX = rookX;
                scanY = rookY;
                stopScan = false;
                while (scanX >= 0 && scanX < 8 && scanY >= 0 && scanY < 8 && !stopScan)
                {
                    Console.WriteLine("scanning: " + scanX + ", " + scanY);
                    if (board[scanY][scanX] == 'B')
                    {
                        stopScan = true;
                    }
                    if (board[scanY][scanX] == 'p')
                    {
                        hits++;
                        stopScan = true;
                    }
                    scanX++;
                }

                scanX = rookX;
                scanY = rookY;
                stopScan = false;
                while (scanX >= 0 && scanX < 8 && scanY >= 0 && scanY < 8 && !stopScan)
                {
                    Console.WriteLine("scanning: " + scanX + ", " + scanY);
                    if (board[scanY][scanX] == 'B')
                    {
                        stopScan = true;
                    }
                    if (board[scanY][scanX] == 'p')
                    {
                        hits++;
                        stopScan = true;
                    }
                    scanX--;
                }


                Console.WriteLine(hits);



                return hits;
            }
        }
