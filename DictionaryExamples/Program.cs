var capitals = new Dictionary<string, string>();
capitals.Add("France", "Paris");
capitals.Add("Japan", "Tokyo");
capitals.Add("United States", "Washington D.C.");
capitals.Add("Australia", "Canberra");

// if(capitals.TryAdd("Japan", "Test")) {
//     Console.WriteLine("ADDED!");
// } else {
//     Console.WriteLine("NOT ADDED!");
// }

foreach(KeyValuePair<string, string> kvp in capitals) {
    Console.WriteLine($"Country: {kvp.Key} => Capital: {kvp.Value}");
}

if(capitals.ContainsKey("Japan")) {
    Console.WriteLine("TRUE!");
    capitals.Remove("Japan");
} 

Console.WriteLine("===============================");

foreach(KeyValuePair<string, string> kvp in capitals) {
    Console.WriteLine($"Country: {kvp.Key} => Capital: {kvp.Value}");
}


Console.WriteLine("===============================");

var capitalCities = capitals.Values;

foreach(var value in capitalCities) {
    Console.WriteLine($"Capital: {value}");
}