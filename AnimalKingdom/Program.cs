
List<string> habitats = new List<string> {"savannah", "jungle"};
Lion simba = new Lion("simba", habitats);

simba.SuitableHabitats.Add("wisconsin");

Console.WriteLine($"{simba.Name} Habitats:");
foreach(string elem in simba.SuitableHabitats) {
    Console.WriteLine(elem);
}


Console.WriteLine("=====================");

Console.WriteLine("Passed habitats: ");
foreach(string elem in habitats) {
    Console.WriteLine(elem);
}