using Dmb.Model;
using Dmb.Model.Interfaces;

namespace Dmb.Tests.Model;

public class TeamUnitTests
{
    [Fact]
    public void Team_CanCreate()
    {
        IModelFactory factory = WireUp();

        Team team = factory.CreateTeam();

        Assert.NotNull(team);
    }

    private IModelFactory WireUp()
    {
        IDomainBehavior behavior = new Dmb.Behaviors.DefaultBehavior();

        IModelFactory factory = new Dmb.Model.Factories.ModelFactory(behavior);

        return factory;
    }
}