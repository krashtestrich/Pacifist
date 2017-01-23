using System;
using Pacifist.Logic.Players;

namespace Pacifist.Logic.Cards.Action
{
    public abstract class ActionCard : Card
    {
        public int RemainingDuration { get; private set; }

        protected ActionCard(
            int duration)
        {
            if (duration < 1)
                throw new Exception("Action cards must be created with a positive duration");
            RemainingDuration = duration;
        }

        public override bool Secret => false;
        public Player AppliedTo { get; set; }

        public void DecreaseDuration()
        {
            RemainingDuration--;
        }
    }
}
