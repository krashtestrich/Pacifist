using System;
using Pacifist.Logic.Cards;

namespace Pacifist.Logic.Players
{
    public class ExpireActionCardEventArgs : EventArgs
    {
        public ICard Card { get; set; }
    }
}