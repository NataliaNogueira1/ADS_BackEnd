namespace Models.Screens;

using Models.BaseShapes;
using System.Drawing;
using System.Windows.Forms;

public class ScreenSaver : Form
{
    // ******* Declare suas formas geométricas aqui (escopo global) *******
    MyRectangle r;
    MyRectangle rn;
    MyRectangle rn2;
    // ********************************************************************
    private Timer ControlTimer;

    public ScreenSaver()
    {
        this.DoubleBuffered = true;                     // evita flickering
        this.WindowState = FormWindowState.Maximized;   // Maximiza a janela
        // Define a cor de background
        this.BackColor = Color.Black;                   
        // Inicializa o temporizador de controle
        ControlTimer = new Timer();
        ControlTimer.Interval = 16;                     // 16 ms = ~60 fps
        // Controle da animação
        ControlTimer.Tick += (s, e) => // a cada 16 milisegundos apaga tudo e coloca novas formas na tela
        {
            // ****** Mova suas formas geométricas aqui ******
            r.Move(ClientSize.Width, ClientSize.Height);
            rn.Move(ClientSize.Width, ClientSize.Height);
            rn2.Move(ClientSize.Width, ClientSize.Height);
            // ***********************************************
            Invalidate(); // Foça a tela a ser redesenhada.
        }; // Função anônima disparada pelo ControlTimer a cada Interval (ms)
        ControlTimer.Start();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        r = new MyRectangle(0, 0, Color.Red, 200, 100);
        rn = new MyRectangle(ClientSize.Width, ClientSize.Height);
        rn2 = new MyRectangle(ClientSize.Width, ClientSize.Height);
        // ****************************************************
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        r.Draw(e.Graphics);
        rn.Draw(e.Graphics);
        rn2.Draw(e.Graphics);
        // ***************************************************

    }
}