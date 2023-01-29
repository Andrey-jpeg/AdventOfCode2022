using System.Text.RegularExpressions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

PartOne();
PartTwo();

static void PartOne()
{
    string input = File.ReadAllText("DayFive/input.txt").TrimEnd();

    string[] sections = input.Split("\n\n");

    string cratesSection = sections[0];

    var crates = cratesSection.Split('\n');

    int amountOfStacks = int.Parse(crates.Last()
    .Trim()
    .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
    .Last());

    crates = crates.Take(crates.Count() - 1).Reverse().ToArray();
    Stack<char>[] stacks = new Stack<Char>[amountOfStacks];

    foreach (string crateLine in crates)
    {
        for ( int i = 0; i < amountOfStacks; i++)
        {
            if ( char.IsLetter(crateLine[i * 4 + 1]))
            {
                stacks[i] ??= new Stack<char>();
                stacks[i].Push(crateLine[i * 4 +1]);
            }
        }
    }

    string instructionsSection = sections[1];
    string[] instructions = instructionsSection.Split('\n');

    foreach (var instruction in instructions)
    {
        var instructionValues = Regex.Matches(instruction, @"\d+").Select(m => int.Parse(m.Value)).ToList();

        for (int i = 0; i < instructionValues[0]; i++)
        {
            char v = stacks[instructionValues[1]-1].Pop();
            stacks[instructionValues[2]-1].Push(v);
        }
    }

    System.Console.WriteLine(String.Join("", stacks.Select(s => s.Peek())));
}

static void PartTwo()
{
    string input = File.ReadAllText("DayFive/input.txt").TrimEnd();

    string[] sections = input.Split("\n\n");

    string cratesSection = sections[0];

    var crates = cratesSection.Split('\n');

    int amountOfStacks = int.Parse(crates.Last()
    .Trim()
    .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
    .Last());

    crates = crates.Take(crates.Count() - 1).Reverse().ToArray();
    Stack<char>[] stacks = new Stack<Char>[amountOfStacks];

    foreach (string crateLine in crates)
    {
        for ( int i = 0; i < amountOfStacks; i++)
        {
            if ( char.IsLetter(crateLine[i * 4 + 1]))
            {
                stacks[i] ??= new Stack<char>();
                stacks[i].Push(crateLine[i * 4 +1]);
            }
        }
    }

    string instructionsSection = sections[1];
    string[] instructions = instructionsSection.Split('\n');

    foreach (var instruction in instructions)
    {
        var instructionValues = Regex.Matches(instruction, @"\d+").Select(m => int.Parse(m.Value)).ToList();

        Stack<Char> tempStack = new Stack<Char>();
        for (int i = 0; i < instructionValues[0]; i++)
        {
            char v = stacks[instructionValues[1]-1].Pop();
            tempStack.Push(v);
        }

        while(tempStack.TryPop(out var crate))
        {
            stacks[instructionValues[2]-1].Push(crate);
        }
    }

    System.Console.WriteLine(String.Join("", stacks.Select(s => s.Peek())));

}
