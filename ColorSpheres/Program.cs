using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color1 = new Color(255, 0, 0);
            Sphere sphere = new Sphere(color1, 5.0f);

            sphere.Throw();
            sphere.Throw();
            sphere.Throw();
            sphere.Throw();
            sphere.Pop();
            sphere.Throw();

            Console.WriteLine($"The sphere was thrown " +
                $"{sphere.GetTimesThrown()} times.");
            
            redSphere.Throw();
            blueSphere.Throw();
            greenSphere.Throw();

            
            Console.WriteLine($"The blue sphere was thrown " +
                $"{blueSphere.GetTimesThrown()} times.");
            Console.WriteLine($"The green sphere was thrown " +
                $"{greenSphere.GetTimesThrown()} times.");
            Console.WriteLine($"The red sphere was thrown " +
                $"{redSphere.GetTimesThrown()} times.");



            
        }
    }
}
