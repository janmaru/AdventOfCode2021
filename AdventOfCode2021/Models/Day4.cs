using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Models
{
    public class Day4
    {
        private List<int> numbers;
        private readonly List<int[,]> boards;

        public Day4()
        {
            numbers = new List<int>();
            boards = new List<int[,]>();
        }
        public void ParseNumbers(List<string> values)
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
