using Dmb.Model.Interfaces;

namespace Dmb.Model;

public class Team : Base.EntityBase
{
    #region  CTOR

    internal Team(Guid id, IDomainBehavior behavior) : base(id, behavior)
    {
        
    }

    #endregion
}