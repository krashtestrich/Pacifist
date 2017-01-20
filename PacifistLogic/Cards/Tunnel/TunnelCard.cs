using Pacifist.Logic.Cards.Character;

namespace Pacifist.Logic.Cards.Tunnel
{
    public class TunnelCard : Card
    {
        public TunnelCard(
            CharactersEnum? doorForTeam = null,
            Segment north = null,
            Segment east = null,
            Segment south = null,
            Segment west = null,
            bool hasOil = false)
        {
            DoorForTeam = doorForTeam;
            North = north ?? new Segment(SegmentType.None);
            East = east ?? new Segment(SegmentType.None);
            South = south ?? new Segment(SegmentType.None);
            West = west ?? new Segment(SegmentType.None);
            HasOil = hasOil;
        }

        public override bool Secret => false;

        public bool HasOil { get; }

        public CharactersEnum? DoorForTeam { get; }

        public Segment North { get; }
        public Segment East { get; }
        public Segment South { get; }
        public Segment West { get; }
    }
}
