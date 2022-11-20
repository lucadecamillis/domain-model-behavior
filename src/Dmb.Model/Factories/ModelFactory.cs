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
        
        return team;
    }

    public Player CreatePlayer(Guid? id = null)
    {
        Player player = new Player(id ?? Guid.NewGuid(), this.behavior);
        
        return player;
    }

    public Bio CreateBio()
    {
        Bio bio = new Bio(this.behavior);

        return bio;
    }
}