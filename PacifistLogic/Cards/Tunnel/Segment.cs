using System.Collections.Generic;

namespace Pacifist.Logic.Cards.Tunnel
{
    public sealed class Segment
    {
        public Segment(SegmentType segmentType)
        {
            Connections = new List<SegmentEnum>();
            SegmentType = segmentType;
        }

        public Segment(
            IEnumerable<SegmentEnum> connections,
            SegmentType segmentType)
        {
            Connections = connections;
            SegmentType = segmentType;
        }

        public IEnumerable<SegmentEnum> Connections { get; }

        public SegmentType SegmentType { get; }
    }
}
