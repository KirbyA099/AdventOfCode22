using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode22.Day3
{
    public class Day3Part1
    {
        public static void Execute()
        {
            var inputFile = File.ReadAllLines("C:\\Users\\c11995a\\source\\repos\\AdventOfCode22\\AdventOfCode22\\Day3\\Day3Input.txt");

            var input = new List<string>(inputFile);

            int charValue;
            int priorityValue = 0;

                foreach (var line in input)
                {
                    var compartment1 = line.Substring(0, (int)(line.Length / 2));
                    var compartment2 = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));

                foreach (char c in compartment1)
                    if(compartment2.Contains(c))
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

                }
            Console.WriteLine($"The sum of the items is: {priorityValue}. (PART 1)\n");
                       
        }
    }
}
    

