internal class Program
{
    public static void Main(string[] arg){
        Figure rectangle = new Rectangle(3,4);
        Figure square = new Square(4);
        Figure triangle = new Triangle(2,2,3);
        Figure circle = new Circle(5);

        List<Figure> figures = new List<Figure>();
        figures.Add(rectangle);
        figures.Add(square);
        figures.Add(triangle);
        figures.Add(circle);

        printInfo(figures);



        

    }
    public static void printInfo(List<Figure> array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
