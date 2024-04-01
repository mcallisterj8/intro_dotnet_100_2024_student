using GenericLibrary.Interfaces;

namespace GenericLibrary.Models;

public class Library<T> where T : ILibraryItem {
    public List<T> Items { get; private set; } = new List<T>();

    public void AddItem(T item) {
        this.Items.Add(item);
        Console.WriteLine($"{item.Title} added to the library.");
    }

    public T GetItem(string title) {
        // LINQ
        return this.Items.FirstOrDefault(item => item.Title == title);

     }

}