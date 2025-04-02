using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private double radius;
        private int timesThrown;

        public Sphere(Color color, double radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }

        public Color GetColor() => _color;
        public double GetRadius() => _radius;
        public int GetTimesThrown() => _timesThrown;

        public void Throw()
        {
            _timesThrown++;
        }

    }
}