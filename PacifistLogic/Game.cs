using System.Collections.Generic;
using Pacifist.Logic.Decks;

namespace Pacifist.Logic
{
    public class Game
    {
        private readonly IDeckFactory _deckBuilder;
        private Deck _deck;
        private GameBoard _gameBoard;
        private readonly List<Player> _players;

        public Game(IDeckFactory deckBuilder)
        {
            _deckBuilder = deckBuilder;
            _deck = _deckBuilder.Get();
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
