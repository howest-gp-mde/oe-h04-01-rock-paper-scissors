using System;

namespace Mde.Oef.RPSGame.Domain
{
    public class Game
    {
        private Random random;
        private int possibleHandValues;

        public Game()
        {
            possibleHandValues = ((int[])Enum.GetValues(typeof(Hand))).Length;
            random = new Random();
        }

        public GameStatistic Play(Hand playerChoice)
        {
            var computerHand = GetComputerChoice();

            return new GameStatistic
            {
                PlayerHand = playerChoice,
                ComputerHand = computerHand,
                Result = CalculateResult(playerChoice, computerHand)
            };
        }

        public Hand GetComputerChoice()
        {
            return (Hand) random.Next(1, possibleHandValues);
        }

        public GameResult CalculateResult(Hand playerHand, Hand computerHand)
        {
            int playerValue = (int)playerHand;
            int computerValue = (int)computerHand;

            if (playerValue + computerValue <= 1) 
                throw new ArgumentException("Both hands should have a value other than Hidden");

            GameResult result = GameResult.Draw;

            if(playerHand != computerHand)
            {
                if(computerHand == playerHand + 1 || computerHand == playerHand - possibleHandValues + 2)
                    result = GameResult.PlayerLost;
                else
                    result = GameResult.PlayerWin;
            }

            return result;
        }
    }
}
