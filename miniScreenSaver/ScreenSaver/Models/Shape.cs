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
    protected int ScreenWidth;
    protected int ScreenHeight;
    protected Color ColorShape;
    private Random Rand = new Random();

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

    public Shape(int screenWidth, int screenHeight)
    {
        ScreenWidth = screenWidth;
        ScreenHeight = screenHeight;
        X = Rand.Next(0, screenWidth - Width);
        Y = Rand.Next(0, screenHeight - Height);
        if (SpeedX == 0)
            SpeedX = 1;
        SpeedX = Rand.Next(1, 10);
        if (SpeedY == 0)
            SpeedY = 1;
        SpeedY = Rand.Next(1, 10);
        Width = Rand.Next(50, 250);
        Height = Rand.Next(50, 250);
        ColorShape = ColorGenerate();
    }

    //Métodos
    public void Move(int xLimit, int yLimit)
    {
        if (X > xLimit - Width || X < 0){
            SpeedX = -SpeedX;
            ColorShape = ColorGenerate();
        }

        if (Y > yLimit - Height || Y < 0){
            SpeedY = -SpeedY;
            ColorShape = ColorGenerate();
        }

        X += SpeedX;
        Y += SpeedY;
    }
    private Color ColorGenerate()
    {
        // Color.FromArgb(red, green, blue)
        // trocar para cor aleatoria (usar random) toda vez que bater na borda
        // criar metodo privado dentro da classe shape
        ColorShape = Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255));
        return ColorShape;
    }

    public abstract void Draw(Graphics g); // obriga os filhos da classe Shape a sempre usar o método Draw

    //ToString
    public override string ToString() {
        return $"Pos X: {X}, Pos Y {Y}, Cor: {ColorShape}";
    }
}