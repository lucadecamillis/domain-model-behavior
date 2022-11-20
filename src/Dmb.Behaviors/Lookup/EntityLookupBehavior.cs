using System.Runtime.CompilerServices;
using Dmb.Model.Base;
using Dmb.Model.Interfaces;

namespace Dmb.Behaviors;

public class EntityLookupBehavior : IDomainBehavior
{
    readonly IDictionary<Guid, EntityBase> entityLookups;

    #region  CTOR

    public EntityLookupBehavior()
    {
        this.entityLookups = new Dictionary<Guid, EntityBase>();
    }

    #endregion

    #region  IDomainBehavior

    public void AddEntity(EntityBase entity)
    {
        this.entityLookups[entity.Id] = entity;
    }

    public void RemoveEntity(EntityBase entity)
    {
        if (this.entityLookups.ContainsKey(entity.Id))
        {
            this.entityLookups.Remove(entity.Id);
        }
    }

    public void AddToCollection<T>(ICollection<T> collection, T item)
    {
        collection.Add(item);
    }

    public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
    {
        storage = value;
        return true;
    }

    #endregion

    public bool TryLookupEntity<T>(Guid id, out T? entity) where T : EntityBase
    {
        entity = null;

        if (this.entityLookups.TryGetValue(id, out var entityBase) && entityBase is T t)
        {
            entity = t;
            return true;
        }

        return false;
    }
}