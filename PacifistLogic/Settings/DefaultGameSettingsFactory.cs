namespace Pacifist.Logic.Settings
{
    public class DefaultGameSettingsFactory : IGameSettingsFactory
    {
        public GameSettings Get()
        {
            return new GameSettings(true, 5);
        }
    }
}
