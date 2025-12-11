using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
namespace EnhanceBoss.Common;
public enum DifficultyLevel {
    Normal,
    Hard,
    Expert,
    Nightmare
}
public class DifficultyConfig : ModConfig {
    public override ConfigScope Mode => ConfigScope.ServerSide;
    [DefaultValue(DifficultyLevel.Normal)]
    public DifficultyLevel GlobalDifficulty { get; set; } = DifficultyLevel.Normal;
}
internal static class DifficultyManager {
    internal static DifficultyLevel CurrentDifficulty => ModContent.GetInstance<DifficultyConfig>().GlobalDifficulty;
}