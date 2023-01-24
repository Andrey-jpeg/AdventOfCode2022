using System.Diagnostics;
using DayTwo;

PartOne();
PartTwo();

void PartOne()
{
    Dictionary<string, RockPaperScissors> moves = new Dictionary<String, RockPaperScissors>()
            {
                { "A", new RockPaperScissors(move: RockPaperScissors.Move.ROCK) },
                { "B", new RockPaperScissors(move: RockPaperScissors.Move.PAPER) },
                { "C", new RockPaperScissors(move: RockPaperScissors.Move.SCISSORS)},
                { "X", new RockPaperScissors(move: RockPaperScissors.Move.ROCK)},
                { "Y", new RockPaperScissors(move: RockPaperScissors.Move.PAPER) },
                { "Z", new RockPaperScissors(move: RockPaperScissors.Move.SCISSORS)}
            };

    string games = File.ReadAllText("DayTwo/input.txt").TrimEnd();

    string[] singleGame = games.Split("\n");

    int sum = 0;
    foreach (string round in singleGame)
    {
        string[] choice = round.Split(" ");
        RockPaperScissors? enemyChoice = moves.GetValueOrDefault(choice[0]);
        RockPaperScissors? myChoice = moves.GetValueOrDefault(choice[1]);

        if (enemyChoice == null || myChoice == null) break;

        switch (enemyChoice.CompareTo(myChoice))
        {
            case (1):
                sum += (6 + ((int)myChoice.move));
                break;
            case (0):
                sum += (3 + ((int)myChoice.move));
                break;
            case (-1):
                sum += (int)myChoice.move;
                break;
        }
    }

    Debug.WriteLine(sum);
}

void PartTwo()
{
    Dictionary<string, RockPaperScissors> moves = new Dictionary<String, RockPaperScissors>()
            {
                { "A", new RockPaperScissors(move: RockPaperScissors.Move.ROCK) },
                { "B", new RockPaperScissors(move: RockPaperScissors.Move.PAPER) },
                { "C", new RockPaperScissors(move: RockPaperScissors.Move.SCISSORS)},
            };

    string games = File.ReadAllText("DayTwo/input.txt").TrimEnd();

    string[] singleGame = games.Split("\n");

    int sum = 0;
    foreach (string round in singleGame)
    {
        string[] choice = round.Split(" ");
        RockPaperScissors? enemyChoice = moves.GetValueOrDefault(choice[0]);

        if (enemyChoice == null) break;

        switch (choice[1])
        {
            case ("X"):
                sum += (lose(enemyChoice.move));
                break;
            case ("Y"):
                sum += (3 + ((int)enemyChoice.move));
                break;
            case ("Z"):
                sum += (6 + win(enemyChoice.move));
                break;
        }


    }

    Debug.WriteLine(sum);
}

static int win(RockPaperScissors.Move move)
{
    switch (move)
    {
        case (RockPaperScissors.Move.PAPER):
            return 3;
        case (RockPaperScissors.Move.ROCK):
            return 2;
        case (RockPaperScissors.Move.SCISSORS):
            return 1;
        default:
            return 0;
    }
}

static int lose(RockPaperScissors.Move move)
{
    switch (move)
    {
        case (RockPaperScissors.Move.PAPER):
            return 1;
        case (RockPaperScissors.Move.ROCK):
            return 3;
        case (RockPaperScissors.Move.SCISSORS):
            return 2;
        default:
            return 0;
    }
}