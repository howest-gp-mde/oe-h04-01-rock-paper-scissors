using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mde.Oef.RPSGame.Domain.Services
{
    public class StatisticsService
    {
        private static List<GameStatistic> gameStatistics = new List<GameStatistic>();

        public async Task<IEnumerable<GameStatistic>> GetAll()
        {
            return await Task.FromResult(gameStatistics);
        }

        public async Task AddStatistic(GameStatistic statistic)
        {
            gameStatistics.Add(await Task.FromResult(statistic));
        }

        public async Task<GameStatisticSummary> GetSummary()
        {
            return await Task.FromResult(new GameStatisticSummary
            {
                GamesPlayed = gameStatistics.Count,
                Wins = gameStatistics.Count(s => s.Result == GameResult.PlayerWin),
                Losses = gameStatistics.Count(s => s.Result == GameResult.PlayerLost),
                Draws = gameStatistics.Count(s => s.Result == GameResult.Draw),
            });;
        }


    }
}
