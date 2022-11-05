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
        Assert.NotEqual(Guid.Empty, team.Id);
    }

    [Fact]
    public void Team_AddPlayer()
    {
        IModelFactory factory = WireUp();

        Team team = factory.CreateTeam();
        Assert.NotEqual(Guid.Empty, team.Id);

        Player player = factory.CreatePlayer();
        Assert.NotEqual(Guid.Empty, player.Id);

        team.AddPlayer(player);

        Assert.Equal(1, team.Players.Count);

        Bio bio = factory.CreateBio();

        bio.FirstName = "Ante";
        bio.LastName = "Rebic";
        bio.BirthDate = new DateOnly(1993, 09, 21);

        player.Bio = bio;
    }

    private IModelFactory WireUp()
    {
        IDomainBehavior behavior = new Dmb.Behaviors.DefaultBehavior();

        IModelFactory factory = new Dmb.Model.Factories.ModelFactory(behavior);

        return factory;
    }
}