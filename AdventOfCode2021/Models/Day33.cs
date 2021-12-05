using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Models
{
    public class Day33
    {
        readonly List<string> numbers;
        public Day33()
        {
            numbers = new List<string>();
        }

        public void Parse(string action)
        {
            numbers.Add(action);
        }
        public int LifeSupportRating()
        {
            return CO2ScrubberRating() * OxygenGeneratorRating();
        }

        public int CO2ScrubberRating()
        {
            var n = numbers.Select(x => x).ToList();
            for (int i = 0; i < numbers[0].Length; i++)
            {
                n = SubCO2ScrubberRating(i, n);
                if (n.Count == 1)
                    break;
            }
            return Convert.ToInt32(n.First(), 2);
        }
        public int OxygenGeneratorRating()
        {
            var n = numbers.Select(x => x).ToList();  
            for (int i = 0; i < numbers[0].Length; i++)
            {
                n = SubOxygenGeneratorRating(i, n);
                if (n.Count == 1)
                    break;
            } 
            return Convert.ToInt32(n.First(), 2);
        }
        private List<string> SubOxygenGeneratorRating(int i, List<string> values)
        {
            var n = values.Select(x => x).ToList();
            List<int> ones = new List<int>();
            List<int> zeros = new List<int>();
            for (int j = 0; j < values.Count; j++)
            {
                char[] c = n[j].ToCharArray();
                if ((int)char.GetNumericValue(c[i]) == 1)
                    ones.Add(j);
                else
                    zeros.Add(j);
            }
            if (ones.Count >= zeros.Count)
            {
                n = n.Where(x => x.Substring(i, 1) == "1").ToList();
            }
            else
            {
                n = n.Where(x => x.Substring(i, 1) == "0").ToList();
            }
            return n;
        }

        private List<string> SubCO2ScrubberRating(int i, List<string> values)
        {
            var n = values.Select(x => x).ToList();
            List<int> ones = new List<int>();
            List<int> zeros = new List<int>();
            for (int j = 0; j < values.Count; j++)
            {
                char[] c = n[j].ToCharArray();
                if ((int)char.GetNumericValue(c[i]) == 1)
                    ones.Add(j);
                else
                    zeros.Add(j);
            }
            if (ones.Count >= zeros.Count)
            {
                n = n.Where(x => x.Substring(i, 1) == "0").ToList();
            }
            else
            {
                n = n.Where(x => x.Substring(i, 1) == "1").ToList();
            }
            return n;
        }
    }
}
