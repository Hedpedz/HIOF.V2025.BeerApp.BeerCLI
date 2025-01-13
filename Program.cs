namespace HIOF.V2025.BeerApp.BeerCLI
{
    using System;
    using System.Collections.Generic;
    internal class Program 
    {
        static void Main (String [] args)
        {
            Console.WriteLine("Hello World!");
            Beer beer1 = new Beer("Heineken", 4.7);
            Beer beer2 = new Beer("Guinness", 4.2);
            beer1.PrintInfo();
            beer2.PrintInfo(); 
            Console.WriteLine($"Beer1.Name: {beer1.Name}");
            List<Beer> beers = new List<Beer>();
            {
                beer1,
                beer2,
            };
            beers.Add(new Lager("Min Ale", 4.6));
            Console.WriteLine("Beers in list:");
            foreach (var beer in beers)
            {
                beer.PrintInfo();
            }
            Dictionary<string, Beer> beersByName = new Dictionary<string, Beer>();
            beersByName.Add(beer1.Name, beer1);
            Beer beer1Ref = beersByName["Ass Pilsner"];
            
        }
    }    
}

