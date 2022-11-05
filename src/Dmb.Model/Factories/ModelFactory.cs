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
        Team team = new Team(id ?? Guid.NewGuid(), this.behavior);

        this.behavior.AddEntity(team);

        return team;
    }

    public Player CreatePlayer(Guid? id)
    {
        Player player = new Player(id ?? Guid.NewGuid(), this.behavior);

        this.behavior.AddEntity(player);

        return player;
    }

    public Bio CreateBio()
    {
        Bio bio = new Bio(this.behavior);

        return bio;
    }
}