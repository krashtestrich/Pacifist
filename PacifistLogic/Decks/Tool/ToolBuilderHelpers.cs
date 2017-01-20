using System.Collections.Generic;
using System.Linq;
using Pacifist.Logic.Cards.Action;
using PacifistInfrastructure;

namespace Pacifist.Logic.Decks.Tool
{
    public class ToolBuilderHelpers
    {
        public Deck Deck { get; }
        public ToolBuilderHelpers(Deck deck)
        {
            Deck = deck;
        }

        public void AddSingleToolBreakCards(
            int number,
            int duration)
        {
            EnumHelpers
                .GetValues<ToolEnum>()
                .ToList()
                .ForEach(t =>
                {
                    AddManyBreakCards(number, duration, t);
                });
        }

        public void AddSingleToolFixCards(
            int number)
        {
            EnumHelpers
                .GetValues<ToolEnum>()
                .ToList()
                .ForEach(t =>
                {
                    AddManyFixCards(number, t);
                });
        }

        public void AddComboToolFixCards(
            int number
        )
        {
            var tools = EnumHelpers
                .GetValues<ToolEnum>()
                .ToList();

            var toolsToAdd = new List<ToolEnum[]>();
            tools.ForEach(t =>
            {
                var otherTools = tools.Where(t1 => t1 != t).ToList();
                otherTools.ForEach(t1 =>
                {
                    if (!toolsToAdd.Any(tad => tad.Contains(t1) && tad.Contains(t)))
                    {
                        toolsToAdd.Add(new[] { t, t1 });
                    }
                });
            });
            toolsToAdd.ForEach(t => AddManyFixCards(1, t));
        }

        private void AddManyFixCards(int number, params ToolEnum[] forTools)
        {
            for (var i = 0; i < number; i++)
                Deck.PlayingCards.Add(new FixCard(3, forTools));
        }

        private void AddManyBreakCards(
            int number, 
            int duration,
            ToolEnum forTool)
        {
            for (var i = 0; i < number; i++)
                //TODO: the duration of the cards, how long they stay in play for
                Deck.PlayingCards.Add(new BreakCard(duration, forTool));
        }
    }
}
