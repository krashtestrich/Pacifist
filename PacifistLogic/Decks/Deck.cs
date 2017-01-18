using System;
using System.Collections.Generic;
using Pacifist.Logic.Cards;

namespace Pacifist.Logic.Decks
{
    public class Deck
    {
        public Deck()
        {
            PlayingCards = new List<ICard>();
            CharacterCards = new List<ICard>();
        }

        public List<ICard> PlayingCards { get; set; }

        public List<ICard> CharacterCards { get; set; }

        public ICard DealPlayingCard()
        {
            return DealCard(PlayingCards);
        }
        public ICard DealCharacterCard()
        {
            return DealCard(CharacterCards);
        }

        private static ICard DealCard(IList<ICard> cards)
        {
            var r = new Random();
            var index = r.Next(cards.Count);
            var card = cards[index];
            cards.RemoveAt(index);
            return card;
        }
    }
}
