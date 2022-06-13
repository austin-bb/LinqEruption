List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// First eruption that is in Chile
IEnumerable<Eruption> chileEruption = eruptions.Where(eruption => eruption.Location == "Chile");
// Console.WriteLine(chileEruption.FirstOrDefault());

// First eruption that is in Hawaiian Islands
IEnumerable<Eruption> hawaiianEruption = eruptions.Where(e => e.Location == "Hawaiian Is");
// Console.WriteLine(hawaiianEruption.FirstOrDefault() != null ? HawaiianEruption.FirstOrDefault() 
// :
// "No Hawaiian Is Eruption Found.");

// The First eruption after the year 1900 and in New Zealand
IEnumerable<Eruption> newZealandEruption = eruptions.Where(e => e.Location == "New Zealand").Where(e => e.Year > 1900);
// Console.WriteLine(newZealandEruption.FirstOrDefault());

// All eruptions where the volcanos elevation is over 2000m
IEnumerable<Eruption> tallVolcanos = eruptions.Where(e => e.ElevationInMeters > 2000);
// foreach (Eruption e in tallVolcanos)
// {
//   Console.WriteLine(e);
// }

// All eruptions where the volcanos name starts with "Z" and the number of eruptions
IEnumerable<Eruption>? zVolcanos = eruptions.Where(e => e.Volcano.StartsWith("Z"));
// foreach (Eruption e in zVolcanos)
// {
//   Console.WriteLine(e.Volcano);
// }
// Console.WriteLine(zVolcanos.Count());

// Integer of the highest elevation
IEnumerable<Eruption> highestVolcano = eruptions.OrderByDescending(e => e.ElevationInMeters);
int highestElevation = eruptions.Max(e => e.ElevationInMeters);
Eruption? highestElevatedVolcano = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestElevation);
// Console.WriteLine(highestElevatedVolcano.ElevationInMeters);
// Console.WriteLine(highestElevatedVolcano.Volcano);

// All Volcano names alphabetically
IEnumerable<Eruption> volcanosAlphabetically = eruptions.OrderBy(e => e.Volcano);
// foreach (Eruption e in volcanosAlphabetically)
// {
//   Console.WriteLine(e.Volcano);
// }

// all eruptions before the year 1000 by volcano names alphabetically
IEnumerable<Eruption> earlyEruptions = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
foreach (Eruption e in earlyEruptions)
{
  Console.WriteLine(e.Volcano);
}

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.ToString());
//     }
// }