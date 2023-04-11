public class Square : Rectangle
{
    public Square(int a) : base(a, a)
    {

    }
    public Square(): base(5,5)
    {
       
    }
    public override string ToString()
    {
        return $"Квадрат\n длина стороны: {base.sides[0]}\n Периметр: {this.calcP()}\n Площадь: {this.calcS()}";
    }
    
}