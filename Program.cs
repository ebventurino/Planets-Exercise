using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> planetList = new List<string>();
            planetList.Add("Mercury");
            planetList.Add("Mars");
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>();
            lastTwoPlanets.Add("Uranus");
            lastTwoPlanets.Add("Neptune");

            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<String> RockyPlanets = planetList.GetRange(0, 4);


            foreach (string item in planetList)
            {
                Console.WriteLine(item);


            }
            foreach (string items in RockyPlanets)
            {
                Console.WriteLine(items);
            }

            // creating a list of planets
            List<string> newPlanetList = new List<string>() { "Venus", "Mars" };
            // creating an empty list
            List<Dictionary<string, string>> solarSystemProbes = new List<Dictionary<string, string>>();

            Dictionary<string, string> venusProbes = new Dictionary<string, string>() {
                            { "Venus" ,"Mariner 2"}
                };

            Dictionary<string, string> Mariner = new Dictionary<string, string>() {
                            { "Mars" ,"Mariner4"}
                };

            // adding probes to the list
            solarSystemProbes.Add(venusProbes);
            solarSystemProbes.Add(Mariner);



            foreach (string planet in newPlanetList)           // foreach (Dictionary<string,string> probe in solarSystemProbes)
            {
                List<string> visitedProbes = new List<string>();

                // Iterate over all the probes
                foreach (Dictionary<string, string> probe in solarSystemProbes)
                {
                    /*
                        Does the current planet name in the dictionary match
                        the name of the planet in the planet list
                     */
                    if (probe.ContainsKey(planet))
                    {
                        visitedProbes.Add(probe[planet]);
                    }

                }

                // Output the name of the planet and comma separated list of matching probes
                Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
            }





        }
    }
}
