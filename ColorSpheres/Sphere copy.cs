using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int timesThrown;

        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }
        public int GetTimesThrown() => _timesThrown;

        private void Pop()
        {
            radius = 0;
        }

        private void Throw()
        {
            if (_radius > 0)

            {
                _timesThrown++;
            }
        }
        

    }
}