using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode22.Day3
{
    public class Day3Part2
    {
        public static void Execute()
        {
            var inputFile = File.ReadAllLines("C:\\Users\\c11995a\\source\\repos\\AdventOfCode22\\AdventOfCode22\\Day3\\Day3Input.txt");

            var input = new List<string>(inputFile);

            int charValue;
            int priorityValue = 0;

            int lineCount = 0;
            var lines = new string[3];


            foreach (var line in input)
            {
                if (lineCount < 3)
                {
                    lines[lineCount] = line;
                    lineCount++;
                }

                if (lineCount == 3)
                {
                    var characterMatch = new List<char>();

                    foreach (char c in lines[0])
                        if (lines[1].Contains(c))
                        {
                            characterMatch.Add(c);
                        }

                    foreach (char c in lines[2])
                        if (characterMatch.Contains(c))
                        {
                            if (Char.IsLower(c))
                            {
                                charValue = char.ToLower(c) - 96;
                                //Console.WriteLine(charValue);
                                priorityValue += charValue;
                                break;
                            }
                            else
                            {
                                charValue = char.ToUpper(c) - 38;
                                //Console.WriteLine(charValue);
                                priorityValue += charValue;
                                break;
                            }
                        }

                    lines = new string[3];
                    lineCount = 0;

                }

            }
            Console.WriteLine($"The sum of the priorities of each three-Elf groups is: {priorityValue}\n");
        }

    }
}
