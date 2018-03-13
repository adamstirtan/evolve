using Evolve.Contracts;
using Evolve.Entities;

namespace Evolve.Problems
{
    public abstract class BaseProblem : IProblem
    {
        public abstract IFitness GetFitness(BaseEntity solution);

        public abstract object Clone();
    }
}
