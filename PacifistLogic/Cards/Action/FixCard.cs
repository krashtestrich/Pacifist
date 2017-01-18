using System.Collections.Generic;

namespace Pacifist.Logic.Cards.Action
{
    public sealed class FixCard : ActionCard
    {
        public FixCard(
            int duration,
            IEnumerable<ToolEnum> tools)
            : base(duration)
        {
            Tools = tools;
        }

        public IEnumerable<ToolEnum> Tools { get; }
    }
}
