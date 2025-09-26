class Car
{
    // Atributos
    public string Color { get; private set; }
    public int Speed { get; private set; }

    // Construtores
    public Car(string color)
    {
        Color = color;
        Speed = 0;
    }
    
    public Car(string color, int speed)
    {
        Color = color;
        Speed = 0;
    }

    // Métodos

    // Pode ter dois métodos com o mesmo nome se tem parâmetros diferentes
    public void Accelerate()
    {
        Speed++;
    }

    public void Accelerate(int value)
    {
        if (value <= 0)
            throw new Exception("Valor de aceleração inválido");
        Speed += value;
    }

    public void Brake()
    {
        Speed --;
    }

    public void Brake(int value)
    {
        if (value >= 0)
            throw new Exception("Valor de desaceleração inválido");
        Speed -= value;
    }

    //ToString
    public override string ToString()
    {
        return $"Cor: {Color}, Velocidade: {Speed}";
    }
}