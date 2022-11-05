using System.Runtime.CompilerServices;
using Dmb.Model.Base;
using Dmb.Model.Interfaces;

namespace Dmb.Behaviors;

public class DefaultBehavior : IDomainBehavior
{
    public void AddEntity(EntityBase entity)
    {
        // NTD
    }

    public bool SetProperty<T>(
        ref T storage,
        T value,
        [CallerMemberName] string? propertyName = null)
    {
        storage = value;
        return true;
    }

    public void AddToCollection<T>(
        ICollection<T> collection,
        T item)
    {
        collection.Add(item);
    }
}