using OpenAndClosedPrinciple;
using SingleResponsibilityPrinciple;


/*try
{
    Console.WriteLine("Please specify the file to convert to HTML.");
    var fullFilePath = Console.ReadLine() ?? string.Empty;
    var fileProcessor = new FileProcessor(fullFilePath);

    var tagsToReplace = new Dictionary<string, (string, string)>
    {
        { "**", ("<strong>", "</strong>") },
        { "*", ("<em>", "</em>") },
        { "~~", ("<del>", "</del>") }
    };

    var textProcessor = new MdTextProcessor(tagsToReplace);
    var inputText = fileProcessor.ReadAllText();
    var outputText = textProcessor.ConvertText(inputText);
    fileProcessor.WriteToFile(outputText);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();*/

AreaCalculator calculator = new AreaCalculator();

Square square = new Square { Side = 5 };
Circle circle = new Circle { Radius = 3 };
Triangle triangle = new Triangle { Base = 4, Height = 3 };

Shape[] shapes = { square, circle, triangle };

double totalArea = calculator.CalculateTotalArea(shapes);
Console.WriteLine($"Total Area: {totalArea}");


public class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double Area()
    {
        return Side * Side;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    // Incorrect override!
    public override double Area()
    {
        return (Base * Height) / 2;
    }
}



public class AreaCalculator
{
    public double CalculateTotalArea(Shape[] shapes)
    {
        double totalArea = 0;
        foreach (Shape shape in shapes)
        {
            totalArea += shape.Area();
        }
        return totalArea;
    }
}

