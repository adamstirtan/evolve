using Evolve.Entities;
using Evolve.Math;
using Evolve.Problems;

namespace Evolve.PSO.Particles
{
    public class Particle : BaseEntity
    {
        private Vector _position;
        private Vector _direction;

        public override void Initialize(BaseProblem problem)
        {
            _position = new Vector();
            _direction = new Vector();
        }

        public override void Reinitialize()
        {
            var dimensions = _position.Length;

            _position = new Vector(dimensions);
            _direction = new Vector(dimensions);
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
