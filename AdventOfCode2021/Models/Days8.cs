using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Models
{

    public class Days8
    {
        private List<string> signals;
        public Days8()
        {
            signals = new List<string>();
        }
        public void Parse(List<string> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (i % 2 != 0)
                {
                    var oo = values[i].Split(" ");
                    for (int j = 0; j < oo.Length; j++)
                    {
                        signals.Add(oo[j]);
                    }
                }
            }
        }

        public void ParseNoLineFeed(List<string> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                var o = values[i].Split("|"); 
                var oo = o[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < oo.Length; j++)
                {
                    signals.Add(oo[j]);
                }
            }
        }

        public int CountEasyDigits()
        {
            var count = 0;
            foreach (var s in signals)
            {
                count += CalculateSingleEasyDigits(s);
            }
            return count;
        }

        private int CalculateSingleEasyDigits(string signal)
        {
            var zero = Zero.Length; // 6
            var uno = Uno.Length; //* 2
            var due = Due.Length; // 5
            var tre = Tre.Length; // 5
            var quattro = Quattro.Length;  //* 4
            var cinque = Cinque.Length; // 5
            var sei = Sei.Length; // 6
            var sette = Sette.Length;  //* 3
            var otto = Otto.Length;  //* 7
            var nove = Nove.Length; // 6

            var s = signal.ToCharArray().Distinct().OrderBy(x => x);
            return s.Count() switch
            {
                2 or 4 or 3 or 7 => 1,
                _ => 0,
            };
        }

        private readonly char[] Zero = new char[] { 'a', 'b', 'c', 'e', 'f', 'g' };
        private readonly char[] Uno = new char[] { 'c', 'f' };
        private readonly char[] Due = new char[] { 'a', 'c', 'd', 'e', 'g' };
        private readonly char[] Tre = new char[] { 'a', 'c', 'd', 'f', 'g' };
        private readonly char[] Quattro = new char[] { 'b', 'c', 'd', 'f' };
        private readonly char[] Cinque = new char[] { 'a', 'b', 'd', 'f', 'g' };
        private readonly char[] Sei = new char[] { 'a', 'b', 'd', 'e', 'f', 'g' };
        private readonly char[] Sette = new char[] { 'a', 'c', 'f' };
        private readonly char[] Otto = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
        private readonly char[] Nove = new char[] { 'a', 'b', 'c', 'd', 'f', 'g' };

        private int CalculateDigits(string signal)
        {
            var s = signal.ToCharArray().Distinct().OrderBy(x => x).ToArray();

            if (s.SequenceEqual(Zero))
                return 0;
            else if (s.SequenceEqual(Uno))
                return 1;
            else if (s.SequenceEqual(Due))
                return 2;
            else if (s.SequenceEqual(Tre))
                return 3;
            else if (s.SequenceEqual(Quattro))
                return 4;
            else if (s.SequenceEqual(Cinque))
                return 5;
            else if (s.SequenceEqual(Sei))
                return 6;
            else if (s.SequenceEqual(Sette))
                return 7;
            else if (s.SequenceEqual(Otto))
                return 8;
            else if (s.SequenceEqual(Nove))
                return 9;

            return -1;
        }
    }
}
