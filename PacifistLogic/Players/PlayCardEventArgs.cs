using System;
using Pacifist.Logic.Cards;

namespace Pacifist.Logic.Players
{
    public class PlayCardEventArgs : EventArgs
    {
        public ICard Card { get; set; }
    }
}
