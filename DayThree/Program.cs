using System.Linq;

PartOne();

PartTwo();

static void PartOne()
{
    string rucksacks = File.ReadAllText("input.txt").TrimEnd();

    var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    string[] individualRucksacks = rucksacks.Split("\n");

    int priority = 0;

    foreach (string rucksack in individualRucksacks)
    {
        char[] chars = rucksack.ToCharArray();
        char[] firstRucksack = chars.Take(chars.Length / 2).ToArray();
        char[] secondRucksack = chars.Skip(chars.Length / 2).ToArray();

        foreach (char c in secondRucksack)
        {
            if (firstRucksack.Contains(c))
            {
                priority += Array.IndexOf(characters, c) + 1;
                break;
            }
        }
    }

    Console.WriteLine(priority);
}

static void PartTwo()
{

    string rucksacks = File.ReadAllText("input.txt").TrimEnd();

    var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    string[] individualRucksacks = rucksacks.Split("\n");

    int priority = 0;

    for (var i = 2; i < individualRucksacks.Length; i += 3)
    {
        string rucksack1 = individualRucksacks[i - 2];
        string rucksack2 = individualRucksacks[i - 1];
        string rucksack3 = individualRucksacks[i];

        HashSet<char> chars1 = new HashSet<char>(rucksack1);
        HashSet<char> chars2 = new HashSet<char>(rucksack2);
        HashSet<char> chars3 = new HashSet<char>(rucksack3);

        string v = rucksack1 + rucksack2 + rucksack3;

        foreach (char c in v) {
            if( chars1.Contains(c) && chars2.Contains(c) && chars3.Contains(c))
            {
                priority += Array.IndexOf(characters, c) + 1;
                break;
            }
        }



    }

    Console.WriteLine(priority);
}