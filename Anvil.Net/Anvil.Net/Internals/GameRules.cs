using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anvil.Net.Internals
{
    public class GameRules
    {
        public string CommandBlockOutput { get; set; }
        public string DoDaylightCycle { get; set; }
        public string DoFireTick { get; set; }
        public string DoMobLoot { get; set; }
        public string DoEntityDrops { get; set; }
        public string DoMobSpawning { get; set; }
        public string DoTileDrops { get; set; }
        public string KeepInventory { get; set; }
        public string LogAdminCommands { get; set; }
        public string MobGriefing { get; set; }
        public string NaturalRegeneration { get; set; }
        public string RandomTickSpeed { get; set; }
        public string SendCommandFeedback { get; set; }
        public string ShowDeathMessages { get; set; }
        public string ReducedDebugInfo { get; set; }
    }
}
