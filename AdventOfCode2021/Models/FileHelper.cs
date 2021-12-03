using System;
using System.Collections.Generic;

namespace AdventOfCode2021.Models
{
    public class FileHelper
    {
        public static IEnumerable<string> Read(string data)
        {
            var strings = new List<string>();
            foreach (var s in data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                strings.Add(s);
            return strings;
        }
    }
}
