using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Models
{
    public class Day6
    {

        private List<long> fishes;
        public Day6()
        {
            fishes = new List<long>();
        }
        public void Parse(string? values)
        {
            if (!string.IsNullOrEmpty(values))
                fishes = values.Split(",").Select(x => Convert.ToInt64(x)).ToList();
        }

        public long TimePassing(int days)
        {
            days++; 
            for (int i = 1; i < days; i++)
            {
                var buffer = fishes.Select(x => x).ToList();
                for (int j = 0; j < fishes.Count; j++)
                {
                    buffer[j] = buffer[j] - 1;
                    if (buffer[j] < 0)
                    {
                        buffer[j] = 6;
                        buffer.Add(8);
                    }
                }
                fishes = buffer;
            }
            return fishes.Count;
        } 
    }
}
 
