using Dmb.Model.Interfaces;

namespace Dmb.Model.Factories;

public class ModelFactory : IModelFactory
{
    readonly IDomainBehavior behavior;

    public ModelFactory(IDomainBehavior behavior)
    {
        this.behavior = behavior;
    }

    public Team CreateTeam(Guid? id = null)
    {
        Team team = new Team(id ?? Guid.NewGuid(), behavior);

        return team;
    }
}