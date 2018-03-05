using System.Collections.Generic;

namespace Evolve
{
    public class ParticleSwarmOptimization
    {
        private readonly IList<Particle> _population;

        public ParticleSwarmOptimization()
        {
            _population = new List<Particle>();
        }
    }
}
