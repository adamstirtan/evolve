using System;

namespace Evolve.Contracts
{
    public interface IAlgorithm : ICloneable
    {
        IProblem Problem { get; set; }

        void Initialize();

        void Iteration();
    }
}
