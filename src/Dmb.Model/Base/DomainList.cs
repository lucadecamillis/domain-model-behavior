using System.Collections;
using Dmb.Model.Interfaces;

namespace Dmb.Model.Base;

public class DomainList<T> : IReadOnlyList<T>
{
    protected readonly IDomainBehavior behavior;

    private readonly IList<T> inner;

    #region  CTOR

    public DomainList(IDomainBehavior behavior)
        : this(new List<T>(), behavior) { }

    public DomainList(IList<T> list, IDomainBehavior behavior)
    {
        this.behavior = behavior;
        this.inner = list;
    }

    #endregion

    #region IReadOnlyList

    public T this[int index]
    {
        get { return this.inner[index]; }
    }

    public int Count
    {
        get { return this.inner.Count; }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.inner.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.inner.GetEnumerator();
    }

    #endregion

    public void Add(T item)
    {
        this.behavior.AddToCollection(this.inner, item);
    }
}