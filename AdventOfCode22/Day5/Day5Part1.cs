using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections;

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

            var moveNumberOfCrates = 0;
            var fromStack = 0;
            var toStack =0;

            var stackCount = 0;
            List<Stack<char>> crateStacks = new List<Stack<char>>();

            for (int i = 0; i < 9; i++)
            {
                crateStacks.Add(new Stack<char>()); 
            }    
            for (int i = 7; i < crateRow.Length; i--)
            {
                var crateChar = crateRow[i].ToCharArray();
                
                for (int j =1; j < crateChar.Length; j +=4)
                {
                    if (crateChar[j] != ' ')
                    {
                        crateStacks[stackCount].Push(crateChar[j]);
                    }
                    stackCount++;
                }
                stackCount = 0;
                if (i == 0)
                {
                    break;
                }

            }

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
                moveNumberOfCrates = instructionNumbers[0];
                fromStack = instructionNumbers[1] -1;
                toStack = instructionNumbers[2] -1;

                for (int k = moveNumberOfCrates; k > 0; k--)
                {

                    var toPush = crateStacks[fromStack].Pop();
                    crateStacks[toStack].Push(toPush);                    
                }          
            }

            for (int i = 0; i < crateStacks.Count; i++)
            {
                Console.Write($"{crateStacks[i].First()}");
            }
        }
    }
}
