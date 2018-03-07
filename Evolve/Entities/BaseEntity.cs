using Evolve.Contracts;
using Evolve.Problems;

namespace Evolve.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int CompareTo(IEntity other)
        {
            return 0;
        }

        public abstract void Initialize(BaseProblem problem);

        public abstract void Reinitialize();

        public abstract object Clone();
    }
}
