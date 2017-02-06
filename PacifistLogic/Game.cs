using System;
using System.Collections.Generic;
using Pacifist.Logic.Cards;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Players;
using Pacifist.Logic.Rules;
using Pacifist.Logic.Settings;

namespace Pacifist.Logic
{
    public class Game
    {
        private readonly List<Player> _players;
        private static List<ICard> _discardPile;

        public Game(
            IDeckFactory deckFactory,
            IRuleSetFactory ruleSetFactory,
            IGameSettingsFactory gameSettingsFactory)
        {
            Deck = deckFactory.Get();
            Rules = ruleSetFactory.Get();
            Settings = gameSettingsFactory.Get();
            _players = new List<Player>();
            _discardPile = new List<ICard>();
            GameBoard = new GameBoard();
        }

        public IEnumerable<ICard> DiscardPile => _discardPile;

        public IEnumerable<Player> Players => _players;

        public Deck Deck { get; private set; }

        public GameStatus Status { get; private set; }

        public RuleSet Rules { get; }

        public GameSettings Settings { get; }

        public GameBoard GameBoard { get; }

        public int? Turn { get; private set; }

        public void Start()
        {
            if (!Settings.AllowBots && _players.Count < Rules.MinPlayers)
                throw new Exception("Need more players");
            
            if (!Settings.AllowBots) return;
            while (_players.Count < Settings.DesiredPlayerCount)
            {
                AddPlayer(new Player());
            }
            
            Turn = 1;
            Status = GameStatus.Started;
        }

        public void AddPlayer(Player player)
        {
            if (_players.Count >= Rules.MaxPlayers)
                throw new Exception("Game is full");
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

        public void ToggleBots(bool enable)
        {
            Settings.AllowBots = enable;
        }

        public void SetDesiredPlayers(int number)
        {
            if (number < Rules.MinPlayers
                || number > Rules.MaxPlayers)
                throw new Exception();

            Settings.DesiredPlayerCount = number;
        }

        #region Events
        private void PlayCardEventHandler(
            object sender,
            CardEventArgs playCardEventArgs)
        {
            GameBoard.CardsInPlay.Add(playCardEventArgs.Card);
        }

        private static void ExpireActionCardEventHandler(
            object sender,
            CardEventArgs expireActionCardEventArgs)
        {
            _discardPile.Add(expireActionCardEventArgs.Card);
        }
        #endregion
    }
}
