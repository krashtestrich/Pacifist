using System.Collections.Generic;
using Pacifist.Logic.Cards;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Cards.Character;

namespace Pacifist.Logic.Players
{
    public class Player
    {
        public Player()
        {
            Hand = new List<ICard>();
            ActiveCards = new List<ActionCard>();
        }

        public List<ICard> Hand { get; set; } 
        public List<ActionCard> ActiveCards { get; set; } 
        public CharacterCard CharacterCard { get; set; }
    }
}
