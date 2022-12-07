using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1
{
    public class Day1
    {
        public static void Execute()
        {

            var inputFile = File.ReadAllLines("C:\\Users\\c11995a\\source\\repos\\AdventOfCode2022\\AdventOfCode2022\\Day1\\Day1Input.txt");

            var input = new List<string>(inputFile);


            int elfCalories = 0;
            int highestElfCalories = 0;

            List<int> elfList = new List<int>();

            foreach (string line in input)
            {

                if (line == string.Empty)
                {

                    //Console.WriteLine($"Elf Total Calories: {elfCalories}");
                    highestElfCalories = Math.Max(highestElfCalories, elfCalories);
                    elfList.Add(elfCalories);
                    elfCalories = 0;
                }
                else
                {
                    int caloriesInItems = Int32.Parse(line);
                    elfCalories += caloriesInItems;

                    //Console.WriteLine(caloriesInItems);
                }
            }
            //Console.WriteLine($"Elf Total Calories: {elfCalories}");

            highestElfCalories = Math.Max(highestElfCalories, elfCalories);
            Console.WriteLine($"Part One: The most calories an elf carries is {highestElfCalories}");

            elfList.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine($"{elfList[0]}, {elfList[1]}, {elfList[2]}");
            int totalCalories = elfList[0] + elfList[1] + elfList[2];
            Console.WriteLine(totalCalories);
        }

    }

}