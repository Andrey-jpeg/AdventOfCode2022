string calories = File.ReadAllText("input.txt");

string[] elfBasket = calories.Split("\n\n");

int[] topInts = new int[3];

foreach (string s in elfBasket)
{
    string[] basketContent = s.Split("\n");

    int[] values = basketContent.Select((value, j) => int.TryParse(value, out j) ? j : 0).ToArray();

    int sum = values.Sum();
    for (int i = 0; i < topInts.Length; i++)
    {
        if (sum > topInts[i])
        {
            topInts[i] = sum;
            break;
        }
    }

}

Console.Write(topInts.Sum());