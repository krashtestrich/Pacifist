using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Tool;

namespace PacifistUnitTest.DeckTests.DeckExtensionTests
{
    [TestClass]
    public class WhenAddingSingleToolFixCards
    {
        [TestMethod]
        public void ShouldAddOneSingleToolBreakCards()
        {
            const int expectedCountOfCards = 3;
            const int expectedUniqueCards = 3;
            var deck = new Deck();
            var helper = new ToolBuilderHelpers(deck);
            helper.AddSingleToolFixCards(1);
            Assert.AreEqual(expectedCountOfCards, deck.PlayingCards.Count);

            var fixCardsDistinct =
                deck.PlayingCards
                    .Select(c => c as FixCard)
                    .GroupBy(c => c.Tools)
                    .ToList();
            Assert.AreEqual(expectedUniqueCards, fixCardsDistinct.Count);
        }

        [TestMethod]
        public void ShouldAddMultipleSingleToolFixCards()
        {
            const int expectedCountOfCards = 9;
            const int expectedUniqueCards = 3;
            var deck = new Deck();
            var helper = new ToolBuilderHelpers(deck);
            helper.AddSingleToolFixCards(3);
            Assert.AreEqual(expectedCountOfCards, deck.PlayingCards.Count);

            var fixCardsDistinct =
                deck.PlayingCards
                    .Select(c => c as FixCard)
                    .GroupBy(c => c.Tools)
                    .ToList();
            Assert.AreEqual(expectedUniqueCards, fixCardsDistinct.Count);
        }
    }
}
