﻿namespace Pacifist.Logic.Cards.Tunnel
{
    public class TunnelCard : Card
    {
        public TunnelCard(
            Segment north = null,
            Segment east = null,
            Segment south = null,
            Segment west = null,
            bool hasOil = false)
        {
            North = north ?? new Segment(SegmentType.None);
            East = east ?? new Segment(SegmentType.None);
            South = south ?? new Segment(SegmentType.None);
            West = west ?? new Segment(SegmentType.None);
            HasOil = hasOil;
        }

        public override bool Secret => false;

        public bool HasOil { get; }

        public Segment North { get; }
        public Segment East { get; }
        public Segment South { get; }
        public Segment West { get; }
    }
}
