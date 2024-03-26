using Learning05.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape_1 = new Square("Yellow", 10);
        shapes.Add(shape_1);

        Rectangle shape_2 = new Rectangle("Blue", 10, 20);
        shapes.Add(shape_2);

        Circle shape_3 = new Circle("Red", 15);
        shapes.Add(shape_3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}