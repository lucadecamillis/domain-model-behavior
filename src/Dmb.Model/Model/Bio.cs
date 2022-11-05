using Dmb.Model.Interfaces;

namespace Dmb.Model;

public class Bio : Base.ValueBase
{
    private string? firstName;

    private string? lastName;

    public string? FirstName
    {
        get { return this.firstName; }
        set { this.behavior.SetProperty(ref this.firstName, value); }
    }

    public string? LastName
    {
        get { return this.lastName; }
        set { this.behavior.SetProperty(ref this.lastName, value); }
    }

    #region  CTOR

    internal Bio(IDomainBehavior behavior) : base(behavior)
    {
        
    }

    #endregion
}