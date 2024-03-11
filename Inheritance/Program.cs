
//public Airplane(string airline, int maxAltitude, int numEngines) {

// Airplane planeA = new Airplane("Delta", 1200, 8);
Airplane planeA = new Airplane("Delta", 1200, 8, "Lexi");
if(planeA.Airline == null){
    Console.WriteLine($"planeA airline: null");
} else {
    Console.WriteLine($"planeA airline: {planeA.Airline}");
}

Console.WriteLine($"planeA name: {planeA.Name}");
Console.WriteLine($"planeA maxAlt: {planeA.MaxAltitude}");
Console.WriteLine($"planeA numEngine: {planeA.NumEngines}");

Console.WriteLine($@"<div class=""myClass"">");

// <div class="myClass">