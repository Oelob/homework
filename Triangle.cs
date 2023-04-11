public class Triangle : Polygon
{
    public Triangle(int a, int b, int c) : base(new int[] {a,b,c})
    {

    }

    public Triangle() : base(new int[]{3,4,5})
    {
        
    }

    public override double calcS()
    {
        double result = 0;
        double p = this.calcP()/2;
        double side1 = base.sides[0];
        double side2 = base.sides[1];
        double side3 = base.sides[2];
        result = Math.Round(Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3)),2);
        return result;
    }
    public override string ToString()
    {
        return $"Треугольник\n длины сторон: {base.sides[0]}, {base.sides[1]}, {base.sides[2]}\n Периметр: {this.calcP()}\n Площадь: {this.calcS()}";
    }
}   