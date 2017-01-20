using System.Collections.Generic;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Players;
using Pacifist.Logic.Rules;

namespace Pacifist.Logic
{
    public class Game
    {
        private readonly IDeckFactory _deckFactory;
        private readonly IRuleSetFactory _ruleSetFactory;
        private Deck _deck;
        private GameBoard _gameBoard;
        private readonly List<Player> _players;

        public Game(
            IDeckFactory deckFactory, 
            IRuleSetFactory ruleSetFactory)
        {
            _deckFactory = deckFactory;
            _ruleSetFactory = ruleSetFactory;
            _deck = _deckFactory.Get();
            _players = new List<Player>();
            _gameBoard = new GameBoard();
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            _players.Remove(player);
        }
    }
}
