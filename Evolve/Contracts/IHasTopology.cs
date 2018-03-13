using System.Collections.Generic;

namespace Evolve.Contracts
{
    public interface IHasTopology<T>
    {
        List<T> Topology { get; set; }
    }
}
