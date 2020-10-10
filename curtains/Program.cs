using System;
using System.Linq;

namespace curtains
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = args[0];
            var allOptions = XkcdColour.AllColours
                .Select(xc => new
                {
                    Proximity = xc.Proximity(userInput),
                    Colour = xc
                });
            var smallestProx = allOptions
                .Min(p => p.Proximity);
            var closestOptions = allOptions
                .Where(p => p.Proximity == smallestProx)
                .Select(p => p.Colour);
            foreach (var option in closestOptions)
            {
                Console.WriteLine($"{option.Name} {option.Value}");
            }
        }
    }
}
