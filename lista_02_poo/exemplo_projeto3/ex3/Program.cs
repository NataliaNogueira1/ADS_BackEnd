// Car[] cars = new Car[3];

// for (int i = 0; i < cars.Length; i++)
// {
//     cars[i] = new Car("vermelho", 10);
//     Console.WriteLine(cars[i]);
// }

Car c1 = new Car("Vermelho");

Console.WriteLine("Digite o valor da aceleração");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    c1.Accelerate(a);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
// // Car c2 = new Car("Azul", 10);

Console.WriteLine(c1);

// try // usado em tudo que pode dar erro por causa do usuário
// {
//     int n = Convert.ToInt32(Console.ReadLine());
//     cars[n].Accelerate(20);
// }
// catch (Exception e)
// {
//     Console.WriteLine("Errou!!!! (só são aceitos números)");
//     Console.WriteLine(e); // e é a instância do erro
//     Console.WriteLine(e.Message);
// }

// Console.WriteLine(c2);
// Console.WriteLine(c1);
// c1.Accelerate(10);
// Console.WriteLine(c1);
// c1.Accelerate();
// Console.WriteLine(c1);
// c1.Brake(2);
// Console.WriteLine(c1);
// c1.Brake();
// c1.Brake();
// c1.Brake();
// Console.WriteLine(c1);