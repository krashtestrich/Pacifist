namespace Pacifist.Logic.Cards
{
    public abstract class Card : ICard
    {
        public abstract bool Secret { get; }
    }
}