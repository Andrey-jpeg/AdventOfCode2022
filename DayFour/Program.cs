using System.Text.RegularExpressions;

PartOne();
PartTwo();

static void PartOne()
{
    string sectionAssignments = File.ReadAllText("input.txt").TrimEnd();

    string[] pairs = sectionAssignments.Split("\n");
    
    int count = 0;
    foreach (var pair in pairs)
    {
        var numbers = Regex.Matches(pair, @"\d+").Select(m => int.Parse(m.Value)).ToList();

        if((numbers[0] <= numbers[2] && numbers[1] >= numbers[3]) || (numbers[2] <= numbers[0] && numbers[3] >= numbers[1])) {
            count += 1;
        }   
    }

    System.Console.WriteLine(count);
}

static void PartTwo()
{
    string sectionAssignments = File.ReadAllText("input.txt").TrimEnd();

    string[] pairs = sectionAssignments.Split("\n");
    
    int count = 0;
    foreach (var pair in pairs)
    {
        var numbers = Regex.Matches(pair, @"\d+").Select(m => int.Parse(m.Value)).ToList();

        if( numbers[0] <= numbers[3] && numbers[2] <= numbers[1])
        {
            count += 1;
        }   
    }

    System.Console.WriteLine(count);
}