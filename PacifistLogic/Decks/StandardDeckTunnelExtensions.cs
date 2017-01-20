using Pacifist.Logic.Cards.Character;
using Pacifist.Logic.Cards.Tunnel;

namespace Pacifist.Logic.Decks
{
    public static class StandardDeckTunnelExtensions
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
                north: new Segment(north),
                east: new Segment(east),
                south: new Segment(south),
                west: new Segment(west),
                hasOil: true));
            }
        }

        public static Deck AddTeamDoorTunnelCards(this Deck deck)
        {
            deck.AddYellowTeamDoorTunnelCards()
                .AddRedTeamDoorTunnelCards();
            return deck;
        }

        private static Deck AddYellowTeamDoorTunnelCards(this Deck deck)
        {
            deck.AddDoorTunnelCard(1, CharactersEnum.YellowTeam, SegmentType.Connect, south: SegmentType.Connect)
                .AddDoorTunnelCard(1, CharactersEnum.YellowTeam, east: SegmentType.Connect, west: SegmentType.Connect)
                .AddDoorTunnelCard(1, CharactersEnum.YellowTeam, south: SegmentType.Connect, west: SegmentType.Connect);

            return deck;
        }

        private static void AddRedTeamDoorTunnelCards(this Deck deck)
        {
            deck.AddDoorTunnelCard(1, CharactersEnum.RedTeam, SegmentType.Connect, south: SegmentType.Connect)
                .AddDoorTunnelCard(1, CharactersEnum.RedTeam, east: SegmentType.Connect, west: SegmentType.Connect)
                .AddDoorTunnelCard(1, CharactersEnum.RedTeam, south: SegmentType.Connect, west: SegmentType.Connect);
        }

        private static Deck AddDoorTunnelCard(
            this Deck deck,
            int numberOfCards,
            CharactersEnum doorForTeam,
            SegmentType north = SegmentType.None,
            SegmentType east = SegmentType.None,
            SegmentType south = SegmentType.None,
            SegmentType west = SegmentType.None
        )
        {
            for (var i = 0; i < numberOfCards; i++)
            {
                deck.PlayingCards.Add(new TunnelCard(
                    doorForTeam,
                    new Segment(north),
                    new Segment(east),
                    new Segment(south),
                    new Segment(west)));
            }
            return deck;
        }
    }
}
