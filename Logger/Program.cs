using GenericLogger.Models;

User userA = new User {Name = "Alice", Age = 27};

Logger bot = new Logger("Wall-e");

bot.Log("User logged in", 42);
bot.DisplayLogCount();

Console.WriteLine("====================================");
// bot.Log(DateTime.Now, userA);

// bot.DisplayLogCount();