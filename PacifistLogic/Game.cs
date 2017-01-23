using System.Collections.Generic;
using Pacifist.Logic.Cards;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Players;
using Pacifist.Logic.Rules;

namespace Pacifist.Logic
{
    public class Game
    {
        private readonly List<Player> _players;
        private static List<ICard> _discardPile;

        public Game(
            IDeckFactory deckFactory,
            IRuleSetFactory ruleSetFactory)
        {
            DeckFactory = deckFactory;
            RuleSetFactory = ruleSetFactory;
            _players = new List<Player>();
            _discardPile = new List<ICard>();
            GameBoard = new GameBoard();
        }

        public IDeckFactory DeckFactory { get; }

        public IRuleSetFactory RuleSetFactory { get; }

        public IEnumerable<ICard> DiscardPile => _discardPile;

        public IEnumerable<Player> Players => _players;

        public Deck Deck { get; private set; }

        public GameBoard GameBoard { get; }

        public int? Turn { get; private set; }

        public void Start()
        {
            Deck = DeckFactory.Get();
            Turn = 1;
        }

        public void AddPlayer(Player player)
        {
            player.CardPlayed += PlayCardEventHandler;
            player.ActionExpired += ExpireActionCardEventHandler;
            _players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            player.CardPlayed -= PlayCardEventHandler;
            player.ActionExpired -= ExpireActionCardEventHandler;
            _players.Remove(player);
        }

        #region Events
        private void PlayCardEventHandler(
            object sender,
            PlayCardEventArgs playCardEventArgs)
        {
            GameBoard.CardsInPlay.Add(playCardEventArgs.Card);
        }

        private static void ExpireActionCardEventHandler(
            object sender,
            ExpireActionCardEventArgs expireActionCardEventArgs)
        {
            _discardPile.Add(expireActionCardEventArgs.Card);
        }
        #endregion
    }
}
