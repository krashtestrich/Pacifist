using Pacifist.Logic.Decks.Duration;

namespace Pacifist.Logic.Decks.Tool
{
    public class StandardDeckToolBuilder : IDeckToolBuilder
    {
        public int Duration { get; }

        public StandardDeckToolBuilder(
            IActionToolDuration durationRetriever)
        {
            Duration = durationRetriever.Get();
        }

        public void AddToolCards(Deck deck)
        {
            var helper = new ToolBuilderHelpers(deck);
            helper.AddSingleToolBreakCards(3, Duration);
            helper.AddSingleToolFixCards(2);
            helper.AddComboToolFixCards(1);
        }
    }
}
