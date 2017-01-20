using Pacifist.Logic.Cards.Character;

namespace Pacifist.Logic.Decks
{
    public static class DeckCharacterExtensions
    {
        public static Deck AddYellowTeamCards(
            this Deck deck,
            int number
        )
        {
            AddCharacterCards(deck, number, CharactersEnum.YellowTeam);
            return deck;
        }

        public static Deck AddRedTeamCards(
            this Deck deck,
            int number
        )
        {
            AddCharacterCards(deck, number, CharactersEnum.RedTeam);
            return deck;
        }

        public static Deck AddPacifistCards(
           this Deck deck,
           int number
        )
        {
            AddCharacterCards(deck, number, CharactersEnum.Pacifist);
            return deck;
        }

        public static Deck AddOilMerchantCards(
          this Deck deck,
          int number
        )
        {
            AddCharacterCards(deck, number, CharactersEnum.OilMerchant);
            return deck;
        }

        public static Deck AddProphetCards(
          this Deck deck,
          int number
        )
        {
            AddCharacterCards(deck, number, CharactersEnum.ProphetOfDoom);
            return deck;
        }
        public static Deck AddCapitalistCards(
          this Deck deck,
          int number
        )
        {
            AddCharacterCards(deck, number, CharactersEnum.Capitalist);
            return deck;
        }

        private static void AddCharacterCards(this Deck deck, int number, CharactersEnum character)
        {
            for (var i = 0; i < number; i++)
                deck.CharacterCards.Add(new CharacterCard(character));
        }
    }
}
