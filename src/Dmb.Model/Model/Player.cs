using Dmb.Model.Interfaces;

namespace Dmb.Model;

public class Player : Base.EntityBase
{
    #region  CTOR

    internal Player(Guid id, IDomainBehavior behavior) : base(id, behavior)
    {
        
    }

    #endregion
}