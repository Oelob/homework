public abstract class Polygon : Figure
{
    protected int[] sides;
    public Polygon(int[] sides)
    {
        this.sides = sides;
    }

    public double calcP()
    {
        double result = 0;
        foreach (var item in this.sides)
        {
            result += item;
        }
        return result;
    }

   public abstract double calcS();
}