using System.Runtime.CompilerServices;
using Dmb.Model.Base;

namespace Dmb.Model.Interfaces;

public interface IDomainBehavior
{
    void AddEntity(
        EntityBase entity);

    void RemoveEntity(
        EntityBase entity);

    bool SetProperty<T>(
        ref T storage,
        T value,
        [CallerMemberName] string? propertyName = null);

    void AddToCollection<T>(
        ICollection<T> collection,
        T item);
}