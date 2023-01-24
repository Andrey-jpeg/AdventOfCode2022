PartOne();

static void PartOne(){
    string rucksacks = File.ReadAllText("DayThree/input.txt").TrimEnd();

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