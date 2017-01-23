using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Character;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.PlayerTests
{
    [TestClass]
    public class WhenAssigningCharacterCard
    {
        [TestMethod]
        public void ShouldAssignCharacterCardToPlayer()
        {
            const CharactersEnum expectedResult = CharactersEnum.Pacifist;
            var player = new Player();
            Assert.IsNull(player.CharacterCard);
            var characterCard = new CharacterCard(CharactersEnum.Pacifist);
            player.AssignCharacterCard(characterCard);
            Assert.AreEqual(expectedResult, player.CharacterCard.Character);
        }
    }
}
