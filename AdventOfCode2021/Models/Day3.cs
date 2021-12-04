using System;

namespace AdventOfCode2021.Models
{
    public class Day3
    {
        int[,] numbers;
        public Day3(int x, int y)
        {
            numbers = new int[x, y];
        }


        public void Parse(int y, string action)
        {
            char[] c = action.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                numbers[i, y] = (int)char.GetNumericValue(c[i]);
            }
        }


        public int PowerConsumption()
        {
            string gamma = string.Empty;
            string epsilon = string.Empty;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int countOne = 0;
                int countZero = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    switch (numbers[i, j])
                    {
                        case 1:
                            countOne += 1;
                            break;
                        default:
                            countZero += 1;
                            break;
                    }
                }
                if (countOne > countZero)
                { 
                    gamma += "1";
                    epsilon += "0";
                }
                else
                {
                    gamma += "0";
                    epsilon += "1";
                } 
            }
            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }
    }
}
