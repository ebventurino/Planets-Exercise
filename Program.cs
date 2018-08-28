using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        // this is rendering the main thing
        static void Main(string[] args)
        {
            //  creating a list, adding with .Add
            List<string> planetList = new List<string>();
            planetList.Add("Mercury");
            planetList.Add("Mars");
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            //  creating a list, adding with .Add
            List<string> lastTwoPlanets = new List<string>();
            lastTwoPlanets.Add("Uranus");
            lastTwoPlanets.Add("Neptune");
            //  creating a list, adding with .Add
            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            // Slices planetList
            List<String> RockyPlanets = planetList.GetRange(0, 4);

            //looping through planetList, writing the list out with WriteLine.
            foreach (string item in planetList)
            {
                Console.WriteLine(item);


            }
            // looping through the RockyPlanets, writing out a list of the rocky planets
            foreach (string items in RockyPlanets)
            {
                Console.WriteLine(items);
            }

            // creating a list of planets, venus and mars
            List<string> newPlanetList = new List<string>() { "Venus", "Mars" };
            // creating an empty list, containing strings?
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


            // looping though newPlanetList
            foreach (string planet in newPlanetList)
            {
                // making a list of visitedProbes, which are strings
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
