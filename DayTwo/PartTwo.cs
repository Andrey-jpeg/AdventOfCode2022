using System;
namespace DayTwo
{
    public class PartTwo
    {
        public static void execute()
        {
            Dictionary<string, RockPaperScissors> moves = new Dictionary<String, RockPaperScissors>()
            {
                { "A", new RockPaperScissors(move: RockPaperScissors.Move.ROCK) },
                { "B", new RockPaperScissors(move: RockPaperScissors.Move.PAPER) },
                { "C", new RockPaperScissors(move: RockPaperScissors.Move.SCISSORS)},
            };

            string games = File.ReadAllText("input.txt");

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
                        break;
                    case ("Y"):
                        break;
                    case ("Z"):
                        break;
                }


            }

            Console.WriteLine(sum);

        }
    }
}

