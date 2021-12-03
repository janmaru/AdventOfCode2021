using System;

namespace AdventOfCode2021.Models
{
    public class Day1
    {
        private int countIncreases;
        private int? previous;
        public Day1()
        {
            previous = null;
        }

        public void Parse(string action)
        {
            var value = Convert.ToInt32(action);
            if (!previous.HasValue) 
                countIncreases = 0; 
            else 
                if (previous < value)
                    countIncreases += 1; 
            previous = value;
        }

        public int GetCount()
        {
            return countIncreases;
        }
    }
}
