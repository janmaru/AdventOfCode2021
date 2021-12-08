using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Statistics;

namespace AdventOfCode2021.Models
{

    public class Days7
    {
        private List<double> crabs;
        public Days7()
        {
            crabs = new List<double>();
        }
        public void Parse(string? values)
        {
            if (!string.IsNullOrEmpty(values))
                crabs = values.Split(",").Select(x => Convert.ToDouble(x)).ToList();
        }

        public int CalculateAlignment()
        {
            double median = crabs.Median();
            double count = 0;
            foreach (var c in crabs)
            {
                count += Math.Abs(c - median);
            }
            return (int)count;
        }

        private int Sum(long ini, long fin)
        {
            var count = 0;
            if (ini < fin)
                for (int i = (int)ini; i <= fin; i++)
                    count += i;
            else
                for (int i = (int)ini; i >= fin; i--)
                    count += i;

            return count;
        }
        public long[,] CalculateProgressiveAlignment()
        {
            var max = (int)crabs.Max() + 1;
            long[,] matrix = new long[max, max];
            for (int i = 0; i < max; i++) 
                for (int j = 0; i < max; i++)
                {
                    matrix[i, j] = Sum(i, j);
                    matrix[j, i] = Sum(j, i);
                } 
            return matrix;
        }
    }
}
