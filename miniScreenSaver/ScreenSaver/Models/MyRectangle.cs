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
    
    public override void Draw(Graphics g) // o override é por causa do abstratc em shape
    {
        using var brush = new SolidBrush(ColorShape);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

}