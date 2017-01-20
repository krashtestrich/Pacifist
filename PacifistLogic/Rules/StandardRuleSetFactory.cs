namespace Pacifist.Logic.Rules
{
    public class StandardRuleSetFactory : IRuleSetFactory
    {
        public RuleSet Get()
        {
            return new RuleSet(6);
        }
    }
}
