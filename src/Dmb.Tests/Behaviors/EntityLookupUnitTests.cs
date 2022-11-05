using Dmb.Model;
using Dmb.Model.Interfaces;
using Dmb.Behaviors;

namespace Dmb.Tests.Behaviors;

public class EntityLookupUnitTests
{
    [Fact]
    public void EntityLookup_CanCreate()
    {
        EntityLookupBehavior behavior = new EntityLookupBehavior();

        IModelFactory factory = WireUp(behavior);

        Guid teamId = Guid.NewGuid();
        factory.CreateTeam(teamId);

        Assert.True(behavior.TryLookupEntity<Team>(teamId, out _));
    }

    private IModelFactory WireUp(IDomainBehavior behavior)
    {
        IModelFactory factory = new Dmb.Model.Factories.ModelFactory(behavior);

        return factory;
    }
}