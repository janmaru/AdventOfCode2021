using System;

namespace AdventOfCode2021.Models
{
    public class Day22
    {
        private (int, int, int) position;

        public Day22()
        {
            position = (0, 0, 0);
        }

        //down X increases your aim by X units.
        //up X decreases your aim by X units.
        //forward X does two things:
        //    It increases your horizontal position by X units.
        //    It increases your depth by your aim multiplied by X.
        public void Parse(string action)
        {
            if (action.Contains("forward"))
            {
                position.Item1 += Convert.ToInt32(action.Replace("forward ", string.Empty));
                position.Item2 += position.Item3 * Convert.ToInt32(action.Replace("forward ", string.Empty));
            }
            else if (action.Contains("down"))
                position.Item3 += Convert.ToInt32(action.Replace("down ", string.Empty));
            else
                position.Item3 -= Convert.ToInt32(action.Replace("up ", string.Empty));
        }

        public (int, int, int) GetPosition()
        {
            return position;
        }
    }
}
