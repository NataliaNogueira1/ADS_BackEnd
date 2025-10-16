using System.Drawing.Drawing2D;

namespace Models.BaseShapes;

public abstract class Shape
{
    //Atributos
    protected int X; // protected = só os filhos podem acessar esse atributo (herança)
    protected int Y; // se quiser: public int Y { get; protected set; }
    protected int SpeedX;
    protected int SpeedY;
    protected int Width;
    protected int Height;
    protected Color ColorShape;
    private Random rnd = new Random();

    //Construtor
    public Shape(int x, int y, Color color, int width, int height)
    {
        X = x;
        Y = y;
        SpeedX = 9;
        SpeedY = 9;
        Width = width;
        Height = height;
        ColorShape = color;
    }

    //Métodos
    public void Move(int xLimit, int yLimit)
    {
        if (X > xLimit - Width || X < 0){
            SpeedX = -SpeedX;
            ColorGenerate();
        }

        if (Y > yLimit - Height || Y < 0){
            SpeedY = -SpeedY;
            ColorGenerate();
        }

        X += SpeedX;
        Y += SpeedY;
    }
    private void ColorGenerate()
    {
        // Color.FromArgb(red, green, blue)
        // trocar para cor aleatoria (usar random) toda vez que bater na borda
        // criar metodo privado dentro da classe shape
        ColorShape = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
    }
    //ToString
    public override string ToString() {
        return $"Pos X: {X}, Pos Y {Y}, Cor: {ColorShape}";
    }
}