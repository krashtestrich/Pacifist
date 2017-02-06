namespace Pacifist.Logic.Settings
{
    public class GameSettings
    {
        public bool AllowBots { get; protected internal set; }

        public int DesiredPlayerCount { get; protected internal set; }

        public GameSettings(
            bool allowBots,
            int desiredPlayerCount)
        {
            AllowBots = allowBots;
            DesiredPlayerCount = desiredPlayerCount;
        }
    }
}
