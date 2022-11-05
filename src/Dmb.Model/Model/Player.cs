using Dmb.Model.Interfaces;

namespace Dmb.Model;

public class Player : Base.EntityBase
{
    private Bio? bio;

    public Bio? Bio
    {
        get { return this.bio; }
        set { this.behavior.SetProperty(ref this.bio, value); }
    }

    #region  CTOR

    internal Player(Guid id, IDomainBehavior behavior) : base(id, behavior)
    {
        
    }

    #endregion
}