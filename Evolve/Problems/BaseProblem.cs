using Evolve.Contracts;

namespace Evolve.Problems
{
    public abstract class BaseProblem : IProblem
    {
        public abstract object Clone();
    }
}
