namespace Pacifist.Logic.Rules
{
    public class RuleSet
    {
        public int StartingCards { get; }
        public int MaxPlayers { get; }

        public int MinPlayers { get; }
        public RuleSet(
            int startingCards,
            int maxPlayers,
            int minPlayers)
        {
            StartingCards = startingCards;
            MaxPlayers = maxPlayers;
            MinPlayers = minPlayers;
        }
    }
}
