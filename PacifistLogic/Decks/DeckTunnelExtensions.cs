using Pacifist.Logic.Cards.Tunnel;

namespace Pacifist.Logic.Decks
{
    public static class DeckTunnelExtensions
    {
        public static Deck AddOilTunnelCards(this Deck deck)
        {
            AddOilTunnelCard(deck, 1, west: SegmentType.Connect);
            AddOilTunnelCard(deck, 1, south: SegmentType.Connect);
            AddOilTunnelCard(deck, 3, east: SegmentType.Connect, south: SegmentType.Connect, west: SegmentType.Connect);
            AddOilTunnelCard(deck, 1, SegmentType.End, SegmentType.Connect, SegmentType.Connect, SegmentType.Connect);
            AddOilTunnelCard(deck, 1, SegmentType.Connect, SegmentType.Connect, SegmentType.Connect);
            AddOilTunnelCard(deck, 1, SegmentType.Connect, SegmentType.End, SegmentType.Connect, SegmentType.Connect);
            AddOilTunnelCard(deck, 1, SegmentType.Connect, SegmentType.Connect, SegmentType.Connect, SegmentType.Connect);
            AddOilTunnelCard(deck, 1, east: SegmentType.Connect, south: SegmentType.End, west: SegmentType.Connect);
            return deck;
        }

        private static void AddOilTunnelCard(
            this Deck deck,
            int numberOfCards,
            SegmentType north = SegmentType.None, 
            SegmentType east = SegmentType.None, 
            SegmentType south = SegmentType.None, 
            SegmentType west = SegmentType.None
            )
        {
            for (var i = 0; i < numberOfCards; i++)
            {
                deck.PlayingCards.Add(new TunnelCard(
                new Segment(north),
                new Segment(east),
                new Segment(south),
                new Segment(west),
                true));
            }
        }
    }
}
