using Pacifist.Logic;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Duration;
using Pacifist.Logic.Decks.Tool;
using Pacifist.Logic.Rules;

namespace PacifistUnitTest
{
    public class StandardGameTestBase
    {
        public Game GetGame()
        {
            return new Game(
               new StandardDeckFactory(
                   new StandardDeckToolBuilder(
                       new StandardActionToolDuration())),
               new StandardRuleSetFactory());
        }
    }
}
