namespace SimpleGeometry.Models;

public class Circle: Shape {
    public double Radius { get; set; }

    public Circle(string givenName, double givenRadius): base(givenName) {
        this.Radius = givenRadius;
    }

    public override string Describe() {
        return $@"
            Shape Name: {this.Name}
            Area of {this.Name}: {this.CalculateArea()}
            Perimeter of {this.Name}: {this.CalculatePerimeter()}
        ";
    }

    public override double CalculateArea() {
        return Math.PI * this.Radius * this.Radius;
    }

    public override double CalculatePerimeter() {
        return Math.PI * 2 * this.Radius;
    }
}