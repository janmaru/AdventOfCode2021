using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Models
{
    public class Result
    {
        public Result(int[,]? board, int number)
        {
            Board = board;
            Number = number;
        }
        public int[,] Board { get; set; }
        public int Number { get; set; }
    }

    public class Day4
    {
        private List<int> numbers;
        private readonly List<int[,]> boards;

        public Day4()
        {
            numbers = new List<int>();
            boards = new List<int[,]>();
        }
        public int Bingo(Result res)
        {
            var count = 0;
            for (int i = 0; i < res.Board.GetLength(0); i++)
                for (int j = 0; j < res.Board.GetLength(1); j++)
                    if (res.Board[i, j] != -1)
                        count += res.Board[i, j];
            return count * res.Number;
        }
 
        public Result LastBoard()
        {
            List<Result> results = new List<Result>();
            List<int> index = new List<int>();
            foreach (var n in numbers)
            { 
                if (index.Count == boards.Count)
                    break;
                for (int k = 0; k < boards.Count; k++)
                {
                    if (!index.Contains(k))
                    {
                        var b = boards[k];
                        var isOk = false;
                        for (int i = 0; i < b.GetLength(0); i++)
                        {
                            var count = 0;
                            for (int j = 0; j < b.GetLength(1); j++)
                            {
                                if (b[i, j] == n)
                                    b[i, j] = -1;
                                count += b[i, j];
                            }
                            if (count == -5)
                            {
                                results.Add(new Result(b, n));
                                isOk = true;
                                index.Add(k);
                                break;
                            }
                        }
                        if (!isOk)
                        {
                            for (int j = 0; j < b.GetLength(1); j++)
                            {
                                var count = 0;
                                for (int i = 0; i < b.GetLength(0); i++)
                                {
                                    if (b[i, j] == n)
                                        b[i, j] = -1;
                                    count += b[i, j];
                                }
                                if (count == -5)
                                {
                                    results.Add(new Result(b, n));
                                    isOk = true;
                                    index.Add(k);
                                    break;
                                }
                            }
                        }
                    } 
                }
            }
            return results.Last();
        }

        public Result Board()
        {
            foreach (var n in numbers)
            {
                for (int k = 0; k < boards.Count; k++)
                {
                    var b = boards[k];
                    for (int i = 0; i < b.GetLength(0); i++)
                    {
                        var count = 0;
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            if (b[i, j] == n)
                                b[i, j] = -1;
                            count += b[i, j];
                        }
                        if (count == -5)
                            return new Result(b, n);
                    }
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        var count = 0;
                        for (int i = 0; i < b.GetLength(0); i++)
                        {
                            if (b[i, j] == n)
                                b[i, j] = -1;
                            count += b[i, j];
                        }
                        if (count == -5)
                            return new Result(b, n);
                    }
                }
            }
            return new Result(new int[0, 0], 0);
        }


        public void Parse(List<string> values)
        {
            numbers = values[0].Split(",").Select(x => Convert.ToInt32(x)).ToList();
            var b = new int[5, 5];
            int c = 1;
            int index = 0;
            for (int i = 1; i < values.Count; i++)
            {
                if (i == c)
                    b = new int[5, 5];
                var ll = values[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x.Replace(" ", ""))).ToArray();
                for (int j = 0; j < ll.Length; j++)
                    b[index, j] = ll[j];
                index++;
                if (i == c + 4)
                {
                    boards.Add(b);
                    index = 0;
                    c = i + 1;
                }
            }
        }

        public List<int> GetNumbers()
        {
            return numbers;
        }

        public List<int[,]> GetBoards()
        {
            return boards;
        }
    }
}
