using System;
using System.Collections.Generic;

namespace AdventOfCode2021.Models
{
    public class Day5
    {
        public int[,] GetBoards()
        {
            return board;
        }

        private readonly int[,] board;
        public Day5()
        {
            board = new int[1000, 1000];
        }
        public void ParseDiagonal(List<string> values)
        {
            foreach (var v in values)
            {
                var cc = v.Split(" -> ");
                int ox = 0;
                int oy = 0;
                int dx = 0;
                int dy = 0;
                for (int i = 0; i < cc.Length; i++)
                {
                    var p = cc[i].Split(",");
                    if (i == 0)
                    {
                        ox = Convert.ToInt32(p[0]);
                        oy = Convert.ToInt32(p[1]);
                    }
                    else
                    {
                        dx = Convert.ToInt32(p[0]);
                        dy = Convert.ToInt32(p[1]);
                    }
                }
                if (ox != dx && oy != dy && (System.Math.Abs(dx - ox) != System.Math.Abs(dy - oy)))
                    continue;
                var maxx = System.Math.Max(ox, dx);
                var minx = System.Math.Min(ox, dx);
                var maxy = System.Math.Max(oy, dy);
                var miny = System.Math.Min(oy, dy);

                for (int i = minx; i <= maxx; i++)
                {
                    for (int j = miny; j <= maxy; j++)
                    {
                        if (i == j)
                            board[i, j] += 1;
                    }
                }

                for (int i = minx; i <= maxx; i++)
                {
                    for (int j = miny; j <= maxy; j++)
                    {
                        if (i == j)
                            board[i, j] += 1;
                    }
                }
            }
        }
        public void Parse(List<string> values)
        {
            //var x = "0,9 -> 5,9";
            foreach (var v in values)
            {
                var cc = v.Split(" -> ");
                int ox = 0;
                int oy = 0;
                int dx = 0;
                int dy = 0;
                for (int i = 0; i < cc.Length; i++)
                {
                    var p = cc[i].Split(",");
                    if (i == 0)
                    {
                        ox = Convert.ToInt32(p[0]);
                        oy = Convert.ToInt32(p[1]);
                    }
                    else
                    {
                        dx = Convert.ToInt32(p[0]);
                        dy = Convert.ToInt32(p[1]);
                    }
                }
                if (ox != dx && oy != dy)
                    continue;
                var maxx = System.Math.Max(ox, dx);
                var minx = System.Math.Min(ox, dx);
                var maxy = System.Math.Max(oy, dy);
                var miny = System.Math.Min(oy, dy);
                for (int i = minx; i <= maxx; i++)
                {
                    for (int j = miny; j <= maxy; j++)
                    { 
                        board[i, j] += 1; 
                    }
                }
            }
        }
        public int TwoLinesOverLap()
        {
            var count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] >= 2)
                        count++;
                }
            }
            return count;
        }
    }
}
