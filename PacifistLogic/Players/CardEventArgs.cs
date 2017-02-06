using System;
using Pacifist.Logic.Cards;

namespace Pacifist.Logic.Players
{
    public class CardEventArgs : EventArgs
    {
        public ICard Card { get; set; }
    }
}
