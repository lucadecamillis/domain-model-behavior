using System.Runtime.CompilerServices;
using Dmb.Model.Base;

namespace Dmb.Model.Interfaces;

public interface IDomainBehavior
{
    /// <summary>
    /// Add an entity to the domain model
    /// </summary>
    /// <param name="entity"></param>
    void AddEntity(
        EntityBase entity);

    /// <summary>
    /// Remove an entity from the domain model
    /// </summary>
    /// <param name="entity"></param>
    void RemoveEntity(
        EntityBase entity);

    /// <summary>
    /// Set a property of an entity in the domain model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="storage"></param>
    /// <param name="value"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    bool SetProperty<T>(
        ref T storage,
        T value,
        [CallerMemberName] string? propertyName = null);

    /// <summary>
    /// Add an item to a domain collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="item"></param>
    void AddToCollection<T>(
        ICollection<T> collection,
        T item);
}