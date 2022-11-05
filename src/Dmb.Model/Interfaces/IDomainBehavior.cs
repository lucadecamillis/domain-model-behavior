using System.Runtime.CompilerServices;

namespace Dmb.Model.Interfaces;

public interface IDomainBehavior
{
    bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null);
}