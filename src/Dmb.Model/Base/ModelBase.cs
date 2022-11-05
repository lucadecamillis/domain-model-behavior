using Dmb.Model.Interfaces;

namespace Dmb.Model.Base;

public class ModelBase
{
    protected readonly IDomainBehavior behavior;

    protected ModelBase(IDomainBehavior behavior)
    {
        this.behavior = behavior;
    }
}