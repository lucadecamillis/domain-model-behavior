using System.Runtime.CompilerServices;

namespace Dmb.Model.Interfaces;

public interface IModelFactory
{
    Team CreateTeam(Guid? id = null);

    Player CreatePlayer(Guid? id = null);

    Bio CreateBio();
}