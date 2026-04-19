
using Ex02_Cofre;

class Program
{
    static void Main()
    {
        Cofre cofre = new Cofre("João", "1234");

        Console.WriteLine(cofre);

        Console.WriteLine(cofre.Abrir("0000")); // erro 1
        Console.WriteLine(cofre.Abrir("1111")); // erro 2
        Console.WriteLine(cofre.Abrir("2222")); // erro 3

        Console.WriteLine(cofre.Abrir("1234")); // deve estar bloqueado

        Console.WriteLine(cofre);

        Console.WriteLine(cofre.Reset("1234")); // reset

        Console.WriteLine(cofre.Abrir("1234")); // agora deve abrir

        Console.WriteLine(cofre.Abrir("1234"));

        Console.WriteLine(cofre.AlterarSenha("1234", "9999"));

        Console.WriteLine(cofre.Fechar());
        Console.WriteLine(cofre.Fechar());

        Console.WriteLine(cofre);
    }
}