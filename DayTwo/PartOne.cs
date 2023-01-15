using System;
namespace DayTwo
{
	public class PartOne
	{
		public static void execute()
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

			string games = File.ReadAllText("input.txt");

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

			Console.WriteLine(sum);
		}


	}
}

