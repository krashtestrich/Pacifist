using Pacifist.Logic.Decks.Tool;

namespace Pacifist.Logic.Decks
{
    public class StandardDeckFactory : IDeckFactory
    {
        private static IDeckToolBuilder _deckToolBuilder;
        public StandardDeckFactory(IDeckToolBuilder deckToolBuilder)
        {
            _deckToolBuilder = deckToolBuilder;
        }

        public Deck Get()
        {
            var deck = new Deck();
            _deckToolBuilder.AddToolCards(deck);
            deck
            // Character cards
            .AddYellowTeamCards(4)
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
