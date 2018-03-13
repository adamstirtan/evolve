using System;
using System.Collections.Generic;

using Evolve.Contracts;
using Evolve.Entities;

namespace Evolve.Algorithm.Population
{
    public class SinglePopulationBasedAlgorithm<T> : BaseAlgorithm, IHasTopology<T> where T : BaseEntity
    {
        public override IProblem Problem { get; set; }

        public List<T> Topology { get; set; }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Iteration()
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
