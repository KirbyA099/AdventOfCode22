using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace AdventOfCode22.Day5
{
    public class Day5Part1
    {
        public static void Execute()
        {
            var inputFile = File.ReadAllText("C:\\Users\\c11995a\\source\\repos\\AdventOfCode22\\AdventOfCode22\\Day5\\Day5Input.txt");

            string[] inputSplit = inputFile.Split("\r\n\r\n");
            string[] crateRow = inputSplit[0].Split("\n");
            string[] instructions = inputSplit[1].Split("\r\n"); ;


            foreach (var instruction in instructions)
            {
                string[] getNumberString = Regex.Split(instruction, @"\D+");

                var instructionNumbers = new List<int>();

                foreach (string value in getNumberString)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int no = Int32.Parse(value);
                        instructionNumbers.Add(no);
                    }
                }
                var moveNumberOfCrates = instructionNumbers[0];
                var fromStack = instructionNumbers[1];
                var toStack = instructionNumbers[2];
            }
            
        }
    }
}
