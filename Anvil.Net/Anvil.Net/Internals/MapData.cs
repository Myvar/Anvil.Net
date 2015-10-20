using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anvil.Net.Internals
{
    public class MapData
    {

        public int Version { get; set; }
        public bool Initialized { get; set; }
        public string LevelName { get; set; }
        public string GeneratorName { get; set; }
        public int GeneratorVersion { get; set; }
        public string GeneratorOptions { get; set; }
        public long RandomSeed { get; set; }
        public bool MapFeatures { get; set; }
        public long LastPlayed { get; set; }
        public long SizeOnDisk { get; set; }
        public bool AllowCommands { get; set; }
        public bool Hardcore { get; set; }
        public int GameType { get; set; }
        public int Difficulty { get; set; }
        public int DifficultyLocked { get; set; }
        public long Time { get; set; }
        public long DayTime { get; set; }
        public int SpawnX { get; set; }
        public int SpawnY { get; set; }
        public int SpawnZ { get; set; }
        public double BorderCenterX { get; set; }
        public double BorderCenterZ { get; set; }
        public double BorderSize { get; set; }
        public double BorderSafeZone { get; set; }
        public double BorderWarningBlocks { get; set; }
        public double BorderWarningTime { get; set; }
        public double BorderSizeLerpTarget { get; set; }
        public long BorderSizeLerpTime { get; set; }
        public double BorderDamagePerBlock { get; set; }
        public bool Raining { get; set; }
        public int RainTime { get; set; }
        public bool Thundering { get; set; }
        public int ThunderTime { get; set; }
        public int ClearWeatherTime { get; set; }
        public GameRules GameRules { get; set; }

        public MapData()
        {
            GameRules = new GameRules();
        }

    }
}
