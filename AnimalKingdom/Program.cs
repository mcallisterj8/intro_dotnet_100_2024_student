
List<string> habitats = new List<string> {"savannah", "jungle"};
Lion simba = new Lion("simba", habitats);

// simba.SuitableHabitats.Add("wisconsin");

// Console.WriteLine($"{simba.Name} Habitats:");
// foreach(string elem in simba.SuitableHabitats) {
//     Console.WriteLine(elem);
// }


// Console.WriteLine("=====================");

// Console.WriteLine("Passed habitats: ");
// foreach(string elem in habitats) {
//     Console.WriteLine(elem);
// }

// string food = "meat";

// if(simba.Eat(food)) {
//     Console.WriteLine($"{simba.Name} eats {food}");
// } else {
//     Console.WriteLine($"{simba.Name} does not eat {food}");
// }

string checkHabitat = "savannah";

if(simba.IsHabitatSuitable(checkHabitat)) {
    Console.WriteLine($"{simba.Name} can live in {checkHabitat}");
} else {
    Console.WriteLine($"{simba.Name} cannot live in {checkHabitat}");
}