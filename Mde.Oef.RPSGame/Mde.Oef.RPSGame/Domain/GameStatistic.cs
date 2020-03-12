namespace Mde.Oef.RPSGame.Domain
{
    public class GameStatistic
    {
        public Hand PlayerHand { get; set; }
        public Hand ComputerHand { get; set; }
        public GameResult Result { get; set; }
    }
}
