public class Rectangle : Polygon
{
    public Rectangle(int a, int b): base(new int[]{a,b,a,b})
    {
        
    }

    public override double calcS()
    {
        return base.sides[0]*base.sides[1];
    }

    public override string ToString()
    {
        return $"Прямоугольник\n длины сторон: {base.sides[0]}, {base.sides[1]}\n Периметр: {this.calcP()}\n Площадь: {this.calcS()}";
    }
}
