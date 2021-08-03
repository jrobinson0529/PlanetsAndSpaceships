using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Add Jupiter and Saturn at the end of the list.
            planetList.AddRange(new List<string> { "Jupiter", "Saturn" });

            // Create another List that contains that last two planet of our solar system.
            List<string> planetListTwo = new List<string>() { "Uranus", "Neptune" };

            // Combine the two lists by using AddRange()
            planetList.AddRange(planetListTwo);

            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets
            var rockyPlanets = planetList.GetRange(0, 4);

            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList
            planetList.Remove(planetList[planetList.Count - 1]);

            // Create a dictionary that will hold the name of a spacecraft
            // that we have launched, and a list of names of the planets that it has
            //  visited.Remember that List is a Type just like native types(such as string, int, &bool) and your custom types(such as Movie, Dog, and Food). These types can be passed to anything, like a dictionary.
            var spacecrafts = new Dictionary<string, List<string>>();
            spacecrafts.Add("Mariner-10", new List<string> { "Mercury", "Venus" } );
            spacecrafts.Add("MESSENGER", new List<string> { "Mercury", "Venus", "Earth" });
            spacecrafts.Add("Mariner-2", new List<string> { "Venus" });
            spacecrafts.Add("Mariner-5", new List<string> { "Venus" });
            spacecrafts.Add("Mariner-4", new List<string> { "Mars" });
            spacecrafts.Add("Voyager-2", new List<string> { "Venus", "Earth", "Mars", "Saturn", "Jupiter", "Uranus", "Neptune" });
            spacecrafts.Add("Cassini", new List<string> { "Saturn", "Venus", "Jupiter" });
            // Iterate over your list of planets from above, and inside that loop,
            // iterate over the dictionary. Write to the console, for each planet,
            // which satellites have visited which planet.
            foreach (var planet in planetList)
            {
                var craftList = new List<string>();
                
                foreach (var craft in spacecrafts)
                {
                    if (craft.Value.Contains(planet))
                    {
                        craftList.Add(craft.Key);
                    }
                }
                Console.WriteLine(string.Format($"{planet}: {string.Join(", ", craftList)}"));
            }
        }
    }
}
