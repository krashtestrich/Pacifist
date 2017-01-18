using System.Collections.Generic;
using System.Linq;
using Pacifist.Logic.Cards.Action;
using PacifistInfrastructure;

namespace Pacifist.Logic.Decks
{
    public static class DeckToolExtensions
    {
        public static Deck AddSingleToolBreakCards(
            this Deck deck,
            int number)
        {
            EnumHelpers
                .GetValues<ToolEnum>()
                .ToList()
                .ForEach(t =>
                {
                    deck.AddManyBreakCards(number, t);
                });
            return deck;
        }

        public static Deck AddSingleToolFixCards(
            this Deck deck,
            int number)
        {
            EnumHelpers
                .GetValues<ToolEnum>()
                .ToList()
                .ForEach(t =>
                {
                    deck.AddManyFixCards(number, t);
                });
            return deck;
        }

        public static Deck AddComboToolFixCards(
            this Deck deck,
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
            toolsToAdd.ForEach(t => AddManyFixCards(deck, 1, t));
            return deck;
        }

        private static void AddManyFixCards(this Deck deck, int number, params ToolEnum[] forTools)
        {
            for (var i = 0; i < number; i++)
                deck.PlayingCards.Add(new FixCard(3, forTools));
        }

        private static void AddManyBreakCards(
           this Deck deck,
           int number,
           ToolEnum forTool)
        {
            for (var i = 0; i < number; i++)
                deck.PlayingCards.Add(new BreakCard(3, forTool));
        }
    }
}
