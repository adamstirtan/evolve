using System;

using Evolve.Problems;

namespace Evolve.Contracts
{
    public interface IEntity : IComparable<IEntity>, ICloneable
    {
        void Initialize(BaseProblem problem);

        void Reinitialize();
    }
}
