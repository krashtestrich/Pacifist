using System;
using System.Collections.Generic;
using Pacifist.Logic.Cards;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Cards.Character;

namespace Pacifist.Logic.Players
{
    public class Player
    {
        private readonly List<ICard> _hand;
        private readonly List<ActionCard> _activeCards;

        public Player()
        {
            _hand = new List<ICard>();
            _activeCards = new List<ActionCard>();
        }

        public IEnumerable<ICard> Hand => _hand;

        public IEnumerable<ActionCard> ActiveCards => _activeCards;

        public CharacterCard CharacterCard { get; private set; }

        public event EventHandler<PlayCardEventArgs> CardPlayed;

        public event EventHandler<ExpireActionCardEventArgs> ActionExpired;

        public void PlayCard(int index)
        {
            var card = _hand[index];
            _hand.RemoveAt(index);
            OnCardPlayed(card);
        }

        protected virtual void OnCardPlayed(ICard card)
        {
            CardPlayed?.Invoke(this, new PlayCardEventArgs { Card = card });
        }

        public void AssignCharacterCard(CharacterCard card)
        {
            CharacterCard = card;
        }

        public void ReceiveCard(ICard card)
        {
            _hand.Add(card);
        }

        public void PerformRoundEndTasks()
        {
            for (var i = 0; i < _activeCards.Count; i++)
            {
                var card = _activeCards[i];
                card.DecreaseDuration();
                if (card.RemainingDuration >= 1) continue;
                _activeCards.RemoveAt(i);
                OnActionExpired(card);
            }
        }

        protected virtual void OnActionExpired(ICard card)
        {
            ActionExpired?.Invoke(this, new ExpireActionCardEventArgs { Card = card });
        }

        public void ReceiveActionCard(ActionCard card)
        {
            _activeCards.Add(card);
        }
    }
}
