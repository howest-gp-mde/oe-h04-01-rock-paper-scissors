using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Oef.RPSGame.Domain
{
    public struct Settings
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool ReceiveWeeklyStats { get; set; }
    }
}
