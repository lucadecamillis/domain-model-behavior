using Dmb.Model.Interfaces;

namespace Dmb.Model;

public class Bio : Base.ValueBase
{
    private string? firstName;
    private string? lastName;
    private DateOnly? birthDate;

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

    public DateOnly? BirthDate
    {
        get { return this.birthDate; }
        set { this.behavior.SetProperty(ref this.birthDate, value); }
    }

    #region  CTOR

    internal Bio(IDomainBehavior behavior) : base(behavior)
    {
        
    }

    #endregion
}