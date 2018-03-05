using Evolve.Math;

namespace Evolve
{
    public class Particle
    {
        private Vector _position;
        private Vector _direction;

        public Particle()
        {
            _position = new Vector(3);
            _direction = new Vector(3);
        }
    }
}
