namespace Pacifist.Logic.Cards.Action
{
    public sealed class BreakCard : ActionCard
    {
        public BreakCard(
            int duration,
            ToolEnum tool)
            : base(duration)
        {
            Tool = tool;
        }

        public ToolEnum Tool { get; }
    }
}
