using System;

namespace AdventOfCode2021.Models
{
    public class Day22
    {
        private (int, int, int) Position;

        public Day22()
        {
            Position = (0, 0, 0);
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
                Position.Item1 += Convert.ToInt32(action.Replace("forward ", string.Empty));
                Position.Item2 += Position.Item3 * Convert.ToInt32(action.Replace("forward ", string.Empty));
            }
            else if (action.Contains("down"))
                Position.Item3 += Convert.ToInt32(action.Replace("down ", string.Empty));
            else
                Position.Item3 -= Convert.ToInt32(action.Replace("up ", string.Empty));
        }

        public (int, int, int) GetPosition()
        {
            return Position;
        }
    }
}
