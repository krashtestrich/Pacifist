namespace Pacifist.Logic.Cards.Character
{
    public sealed class CharacterCard : Card
    {
        public CharacterCard(CharactersEnum character)
        {
            Character = character;
        }

        public override bool Secret => true;

        public CharactersEnum Character { get; }
    }
}
