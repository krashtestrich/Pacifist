﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Tool;

namespace PacifistUnitTest.DeckTests.DeckExtensionTests
{
    [TestClass]
    public class WhenAddingMultipleToolFixCards
    {
        [TestMethod]
        public void ShouldAddComboToolFixCards()
        {
            const int expectedCountOfCards = 3;
            const int expectedUniqueCards = 3;
            var deck = new Deck();
            var helper = new ToolBuilderHelpers(deck);
            helper.AddComboToolFixCards(1);
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
