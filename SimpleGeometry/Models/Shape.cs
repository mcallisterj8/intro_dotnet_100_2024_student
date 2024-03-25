using SimpleGeometry.Interfaces;

namespace SimpleGeometry.Models;

public abstract class Shape: IShape {
    public string Name { get; set; }

    public Shape(string name) {
        this.Name = name;
    }
    public abstract string Describe();

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}