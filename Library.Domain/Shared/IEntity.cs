using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Shared
{
    public interface IEntity<out TId> where TId : IEquatable<TId>
    {
        TId Id { get; }
    }
}
