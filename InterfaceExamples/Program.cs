
iPhone phoneA = new iPhone {
                    Brand = "Apple", 
                    Model = "iPhone 11"
                };
Android phoneB = new Android {
            Brand = "Google", 
            Model = "Samsung Galaxy 23"
        };

// phoneA.UseAssistant("Check Weather"); // Valid command
// phoneA.UseAssistant("Test"); // Invalid command

ISmartphone phoneC = new iPhone {
                    Brand = "Apple", 
                    Model = "iPhone 12"
                };

ISmartphone phoneD = new Android {
            Brand = "Google", 
            Model = "Samsung Galaxy 20"
        };

phoneC.BrowseInternet(); // iPhone
phoneD.BrowseInternet(); // Android

phoneC = new Android {
                Brand = "Google", 
                Model = "Samsung Galaxy 16"
            };

Console.WriteLine("=================================");

phoneC.BrowseInternet(); // Android
phoneD.BrowseInternet(); // Android

Console.WriteLine("=================================");
List<ISmartphone> smartphoneList = new List<ISmartphone> {
                                        phoneA,
                                        phoneB,
                                        phoneC,
                                        phoneD
                                    };

foreach(ISmartphone phone in smartphoneList) {
    phone.BrowseInternet();
}


decimal x = 0.1m;
decimal y = 0.2m;

Console.WriteLine(x + y);
