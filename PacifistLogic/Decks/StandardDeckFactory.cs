namespace Pacifist.Logic.Decks
{
    public class StandardDeckFactory : IDeckFactory
    {
        public Deck Get()
        {
            var deck = new Deck();
                deck
                .AddSingleToolBreakCards(3)
                .AddSingleToolFixCards(2)
                .AddComboToolFixCards(1)
                // Character cards
                .AddBlueTeamCards(4)
                .AddRedTeamCards(4)
                .AddPacifistCards(3)
                .AddOilMerchantCards(2)
                .AddProphetCards(1)
                .AddCapitalistCards(1)

                // Tunnel cards
                .AddOilTunnelCards();
            return deck;
        }
    }
}
