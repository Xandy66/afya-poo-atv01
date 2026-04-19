using System;
using Ex03_Conta;

class Program
{
    static void Main()
    {
        Conta conta = new Conta(123, "João");

        Console.WriteLine("=== ESTADO INICIAL ===");
        Console.WriteLine(conta);
        Console.WriteLine(conta.MostrarSaldo());

        Console.WriteLine("\n=== DEPÓSITO ===");
        Console.WriteLine(conta.Depositar(300));
        Console.WriteLine(conta.MostrarSaldo());

        Console.WriteLine("\n=== SAQUE NORMAL ===");
        Console.WriteLine(conta.Sacar(200));
        Console.WriteLine(conta.MostrarSaldo());

        Console.WriteLine("\n=== SAQUE USANDO CHEQUE ESPECIAL ===");
        Console.WriteLine(conta.Sacar(600));
        Console.WriteLine(conta.MostrarSaldo());

        Console.WriteLine("\n=== TENTATIVA DE SAQUE MAIOR QUE O LIMITE ===");
        Console.WriteLine(conta.Sacar(1000));
        Console.WriteLine(conta.MostrarSaldo());

        Console.WriteLine("\n=== STATUS FINAL ===");
        Console.WriteLine(conta);
    }
}