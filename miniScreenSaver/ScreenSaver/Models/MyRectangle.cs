namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    //Atributos

    //Construtores
    public MyRectangle(int x, int y, Color color, int width, int height) : base(x, y, color, width, height)
    {
    }

    public MyRectangle(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {
    }

    //Métodos
    
    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

}