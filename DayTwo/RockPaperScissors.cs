using System;
namespace DayTwo
{
	public class RockPaperScissors : IComparable<RockPaperScissors>
	{
		public Move move { get; }
		public RockPaperScissors(Move move)
		{
			this.move= move;
		}

        public int CompareTo(RockPaperScissors? other)
        {
			if (other == null) throw new ArgumentNullException();

			else if (this.move == other.move) return 0;

			switch((this.move, other.move))
			{
				case (Move.ROCK, Move.PAPER):
				case (Move.SCISSORS, Move.ROCK):
				case (Move.PAPER, Move.SCISSORS):
					return 1;
				default:
					return -1;
			}
			
        }

		public Move pickBetterMove(Move move)
		{
			return Move.ROCK;
		}

		public Move pickWorseMove(Move move)
		{
			return Move.PAPER;
		}

        public enum Move
		{
			ROCK = 1,
			PAPER = 2,
			SCISSORS = 3
		}
	}
}

