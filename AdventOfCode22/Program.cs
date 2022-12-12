using System;
using System.Text;
using System.IO;
using AdventOfCode2022.Day1;
using AdventOfCode22;
using AdventOfCode22.Day2;
using AdventOfCode22.Day3;

namespace AdventofCode2022;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DAY 1:\n");
        Day1.Execute();

        Console.WriteLine("DAY 2:\n");
        Day2Part1.Execute();
        Day2Part2.Execute();

        Console.WriteLine("DAY 3:\n");
        Day3Part1.Execute();
        Day3Part2.Execute();

        Console.WriteLine("DAY 4:\n");

    }
}