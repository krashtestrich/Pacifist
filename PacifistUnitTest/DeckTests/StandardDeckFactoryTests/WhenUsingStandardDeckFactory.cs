using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Tunnel;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Duration;
using Pacifist.Logic.Decks.Tool;

namespace PacifistUnitTest.DeckTests.StandardDeckFactoryTests
{
    [TestClass]
    public class WhenUsingStandardDeckFactory
    {
        [TestMethod]
        public void ShouldCreateStandardDeck()
        {
            const int expectedPlayingCards = 28;
            const int expectedCharacterCards = 15;
            const int expectedOilCards = 10;

            var deckFactory = new StandardDeckFactory(new StandardDeckToolBuilder(new StandardActionToolDuration()));
            var deck = deckFactory.Get();

            Assert.AreEqual(expectedPlayingCards, deck.PlayingCards.Count);
            Assert.AreEqual(expectedCharacterCards, deck.CharacterCards.Count);
            Assert.AreEqual(expectedOilCards, deck.PlayingCards.Count(c =>
            {
                var tunnelCard = c as TunnelCard;
                return tunnelCard != null && tunnelCard.HasOil;
            }));
        }
    }
}
