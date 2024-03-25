
using SimpleGeometry.Models;

Shape shapeA = new Circle("Carl", 4);

Console.WriteLine($"shapeA name: {shapeA.Name}");

if(shapeA is Circle) {
    // Circle myCircle = (Circle)shapeA;
    // Console.WriteLine($"shapeA radius: {myCircle.Radius}");

    
    Console.WriteLine($"shapeA radius: {( (Circle)shapeA ).Radius}");
}

Console.WriteLine(shapeA.Describe());


