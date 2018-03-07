using Evolve.Contracts;

namespace Evolve.Algorithm
{
    public abstract class BaseAlgorithm : IAlgorithm
    {
        public abstract IProblem Problem { get; set; }

        public abstract void Initialize();

        public abstract void Iteration();

        public abstract object Clone();
    }
}
