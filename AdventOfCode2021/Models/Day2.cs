using System;

namespace AdventOfCode2021.Models
{
    public class Day2
    {
        private (int, int) position;

        public Day2()
        {
            position = (0, 0);
        }

        //forward X increases the horizontal position by X units.
        //down X increases the depth by X units.
        //up X decreases the depth by X units.
        public void Parse(string action)
        {
            if (action.Contains("forward"))
                position.Item1 += Convert.ToInt32(action.Replace("forward ", string.Empty));
            else if (action.Contains("down"))
                position.Item2 += Convert.ToInt32(action.Replace("down ", string.Empty));
            else
                position.Item2 -= Convert.ToInt32(action.Replace("up ", string.Empty));
        }


        public (int, int) GetPosition()
        {
            return position;
        }
    }
}
