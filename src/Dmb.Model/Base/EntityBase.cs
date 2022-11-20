using Dmb.Model.Interfaces;

namespace Dmb.Model.Base;

public class EntityBase : ModelBase
{
    public Guid Id { get; }

    #region  CTOR

    protected EntityBase(Guid id, IDomainBehavior behavior) : base(behavior)
    {
        this.Id = id;
        behavior.AddEntity(this);
    }

    #endregion
}