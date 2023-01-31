PartOne();
PartTwo();

static void PartOne()
{
    string datastream = File.ReadAllText("input.txt").TrimEnd();
    var chars = datastream.ToArray();

    for (var i = 0; i < chars.Length; i++)
    {
        var subChars = chars.ToList().GetRange(i, 4);
        if(subChars.Distinct().Count() == subChars.Count())
        {
            Console.WriteLine(i + subChars.Count());
            break;
        }
    }
}

static void PartTwo()
{
    string datastream = File.ReadAllText("input.txt").TrimEnd();
    var chars = datastream.ToArray();

    for (var i = 0; i < chars.Length; i++)
    {
        var subChars = chars.ToList().GetRange(i, 14);
        if(subChars.Distinct().Count() == subChars.Count())
        {
            Console.WriteLine(i + subChars.Count());
            break;
        }
    }
}