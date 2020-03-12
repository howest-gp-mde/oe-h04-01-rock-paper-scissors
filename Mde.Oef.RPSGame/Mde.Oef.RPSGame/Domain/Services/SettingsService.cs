using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Oef.RPSGame.Domain.Services
{
    public class SettingsService
    {
        private static Settings inMemorySettings = new Settings
        {
            UserName = "",
            Email = "",
            ReceiveWeeklyStats = false
        };

        public async Task<Settings> GetSettings()
        {
            return await Task.FromResult(inMemorySettings);
        }

        public async Task SaveSettings(Settings settings)
        {
            inMemorySettings = await Task.FromResult(settings);
        }
    }
}
