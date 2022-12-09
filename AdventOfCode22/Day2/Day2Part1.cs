using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode22.Day2
{
    public class Day2Part1
    {
        public static void Execute()
        {
            var inputFile = File.ReadAllLines("C:\\Users\\c11995a\\source\\repos\\AdventOfCode22\\AdventOfCode22\\Day2\\Day2Input.txt");

            var input = new List<string>(inputFile);

            var roundScore = new Dictionary<string, int>()
            {
                {"X", 1},
                {"Y", 2},
                {"Z", 3},
            };

            int score = 0;

            foreach (var line in input)
            {
                var lineChoices = line.Split(" ");
                var opponentChoice = lineChoices[0];
                var myChoice = lineChoices[1];

                //draw
                if (opponentChoice == "A" && myChoice == "X" || opponentChoice == "B" && myChoice == "Y" || opponentChoice == "C" && myChoice == "Z")
                {
                    score += 3 + roundScore[myChoice];
                }
                //win
                else if (opponentChoice == "A" && myChoice == "Y" || opponentChoice == "B" && myChoice == "Z" || opponentChoice == "C" && myChoice == "X")
                {
                    score += 6 + roundScore[myChoice];
                }
                //lose
                else
                {
                    score += roundScore[myChoice];
                }                 
            }

            Console.WriteLine($"The total score using Strategy 1 is: {score}. (PART 1)");


        }
    }
}
