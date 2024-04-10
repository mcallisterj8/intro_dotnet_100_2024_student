HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

List<int> numbers = new List<int> { 2, 3, 4, 6 };

hashSet.SymmetricExceptWith(numbers); // Will now contain 1, 5

int x;
bool result = hashSet.TryGetValue(5, out x);

Console.WriteLine($"found => {result}; num: {x}");

// foreach(int elem in hashSet) {
//     Console.WriteLine(elem);
// }

