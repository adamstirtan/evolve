using System;
using System.Threading.Tasks;

namespace Evolve.Math
{
    public class Vector : ICloneable
    {
        private readonly double[] _elements;

        public Vector(int n)
        {
            _elements = new double[n];
        }

        public Vector(params double[] elements)
        {
            _elements = elements;
        }

        public double this[int i]
        {
            get => _elements[i];
            set => _elements[i] = value;
        }

        public int Length => _elements.Length;

        public Vector Add(Vector v)
        {
            if (Length != v.Length)
            {
                throw new ArgumentException();
            }

            var elements = new double[Length];

            Parallel.For(0, Length, i =>
            {
                elements[i] = this[i] + v[i];
            });

            return new Vector(elements);
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
