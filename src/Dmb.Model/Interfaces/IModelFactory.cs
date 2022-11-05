using System.Runtime.CompilerServices;

namespace Dmb.Model.Interfaces;

public interface IModelFactory
{
    Team CreateTeam(Guid? id = null);
}