using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode22.Day4
{
    public class Day4
    {
        public static void Execute()
        {
            var inputFile = File.ReadAllLines("C:\\Users\\c11995a\\source\\repos\\AdventOfCode22\\AdventOfCode22\\Day4\\Day4Input.txt");

            var input = new List<string>(inputFile);

            int countPart1 = 0;
            int countPart2 = 0;

            int lineCount = 0;

            foreach (var line in input)
            {
                string[] splitLine = line.Split(',');
                var range1 = splitLine[0];
                var range2 = splitLine[1];

                //Console.WriteLine(line);
                //Console.WriteLine($"Range 1: {range1}  Range 2: {range2}");

                string[] splitRange = range1.Split('-');
                var a = Int32.Parse(splitRange[0]);
                var b = Int32.Parse(splitRange[1]);

                string[] splitRange2 = range2.Split('-');
                var c = Int32.Parse(splitRange2[0]);
                var d = Int32.Parse(splitRange2[1]);

                lineCount++;

                //Console.WriteLine($"Start Range: {startRange1} End Range: {endRange1}   Start Range: {startRange2} End Range: {endRange2}");

                if (a <= c && b >= d || c <= a && d >= b)
                {
                    countPart1++;
                }
                if(c <= a && a <= d || c <= b && b <= d || a <= c && c <= b || a <= d && d <= b)
                {
                    countPart2++;
                }
                //Console.WriteLine($"Line: {lineCount} Count: {countPart2}");
            }
            Console.WriteLine($"The number of pairs where one range fully contains the other is: {countPart1}. (PART 1)\n");
            Console.WriteLine($"The number of pairs where one range overlaps other is: {countPart2}. (PART 2)\n");

        }
    }

}
