using GenericsExamples.Models;

List<string> words = new List<string> {"apple", "berry", "cherry", "date"};
List<int> numbers = new List<int> {12, 16, 18, 24, 80};
iPhone phoneA = new iPhone {
                    Brand = "Apple", 
                    Model = "iPhone 11"
                };
Android phoneB = new Android {
            Brand = "Google", 
            Model = "Samsung Galaxy 23"
        };

ISmartphone phoneC = new iPhone {
                    Brand = "Apple", 
                    Model = "iPhone 12"
                };

ISmartphone phoneD = new Android {
            Brand = "Google", 
            Model = "Samsung Galaxy 20"
        };
List<ISmartphone> smartphoneList = new List<ISmartphone> {
                                        phoneA,
                                        phoneB,
                                        phoneC,
                                        phoneD
                                    };

Box<string> boxA = new Box<string>("boxA", "Star Item", words);
Console.WriteLine(boxA.ToString());

Console.WriteLine("\n=======================================");

Box<int> boxB = new Box<int>("boxB", 8, numbers);
Console.WriteLine(boxB.ToString());


Console.WriteLine("\n=======================================");