using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode22.Day2
{
    public class Day2Part2
    {
        public static void Execute()
        {
            var inputFile = File.ReadAllLines("C:\\Users\\c11995a\\source\\repos\\AdventOfCode22\\AdventOfCode22\\Day2\\Day2Input.txt");

            var input = new List<string>(inputFile);

            var roundResult = new Dictionary<string, int>()
            {
                {"X", 0 },
                {"Y", 3 },
                {"Z", 6}
            };

            int score = 0;

            foreach (var line in input)
            {
                var lineStrategy = line.Split(" ");
                var opponentChoice = lineStrategy[0];
                var gameResult = lineStrategy[1];

                //rock
                if (opponentChoice == "A" && gameResult == "Y" || opponentChoice == "B" && gameResult == "X" || opponentChoice == "C" && gameResult == "Z")
                {
                    score += 1 + roundResult[gameResult];
                }
                //paper    
                else if (opponentChoice == "A" && gameResult == "Z" || opponentChoice == "B" && gameResult == "Y" || opponentChoice == "C" && gameResult == "X")
                {
                    score += 2 + roundResult[gameResult];
                }
                //scissors
                else 
                {
                    score += 3 + roundResult[gameResult];                                      
                }
                
            }
            Console.WriteLine($"\nThe total score using Strategy 2 is: {score}. (PART 2)\n");

           
        }
    }
}
