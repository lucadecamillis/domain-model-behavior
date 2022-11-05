using System.Runtime.CompilerServices;
using Dmb.Model.Interfaces;

namespace Dmb.Behaviors;

public class DefaultBehavior : IDomainBehavior
{
    public bool SetProperty<T>(
        ref T storage,
        T value,
        [CallerMemberName] string? propertyName = null)
    {
        storage = value;
        return true;
    }
}