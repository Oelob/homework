public class Circle : Figure
{
    protected double r;

    public Circle(double r)
    {
        this.r = r;
    }

    public Circle()
    {
        this.r = 5;
    }
    public double calcP()
    {
        return Math.Round((2*Math.PI*r),2);
    }

    public double calcS()
    {
        return Math.Round((Math.PI*r*r),2);
    }

    public override string ToString()
    {
        return $"Круг\n Радиус: {this.r}\n Длина окружности: {this.calcP()}\n Площадь: {this.calcS()}";
    }


}