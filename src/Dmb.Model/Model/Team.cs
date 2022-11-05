using Dmb.Model.Base;
using Dmb.Model.Interfaces;

namespace Dmb.Model;

public class Team : EntityBase
{
    readonly DomainList<Player> players;

    private string? name;

    public string? Name
    {
        get { return this.name; }
        set { this.behavior.SetProperty(ref this.name, value); }
    }

    public IReadOnlyList<Player> Players
    {
        get { return this.players; }
    }

    #region  CTOR

    internal Team(Guid id, IDomainBehavior behavior) : base(id, behavior)
    {
        this.players = new DomainList<Player>(behavior);
    }

    #endregion
}