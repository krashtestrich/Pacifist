using System.Collections.Generic;

namespace Pacifist.Logic.Cards.Action
{
    public abstract class ActionCard : Card
    {
        private int _remainingDuration;

        protected ActionCard(
            int duration)
        {
            _remainingDuration = duration;
        }

        public override bool Secret => false;
        public Player AppliedTo { get; set; }

        public void DecreaseDuration()
        {
            _remainingDuration--;
        }

        public int RemainingDuration()
        {
            return _remainingDuration;
        }
    }
}
