using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Tool;

namespace PacifistUnitTest.DeckTests.DeckExtensionTests
{
    [TestClass]
    public class WhenAddingSingleToolBreakCards
    {
        [TestMethod]
        public void ShouldAddOneSingleToolBreakCards()
        {
            const int expectedCountOfCards = 3;
            const int expectedUniqueCards = 3;
            var deck = new Deck();
            var helper =new ToolBuilderHelpers(deck);
            helper.AddSingleToolBreakCards(1, 3);
            Assert.AreEqual(expectedCountOfCards, deck.PlayingCards.Count);

            var breakCardsDistinct = 
                deck.PlayingCards
                    .Select(c => c as BreakCard)
                    .GroupBy(c => c.Tool)
                    .ToList();
            Assert.AreEqual(expectedUniqueCards, breakCardsDistinct.Count);
        }

        [TestMethod]
        public void ShouldAddMultipleSingleToolBreakCards()
        {
            const int expectedCountOfCards = 9;
            const int expectedUniqueCards = 3;
            var deck = new Deck();
            var helper = new ToolBuilderHelpers(deck);
            helper.AddSingleToolBreakCards(3, 3);
            Assert.AreEqual(deck.PlayingCards.Count, expectedCountOfCards);

            var breakCardsDistinct =
                deck.PlayingCards
                    .Select(c => c as BreakCard)
                    .GroupBy(c => c.Tool)
                    .ToList();
            Assert.AreEqual(expectedUniqueCards, breakCardsDistinct.Count);
        }
        //TODO: Add test(s) for Duration....
    }
}
