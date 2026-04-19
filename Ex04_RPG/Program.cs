
namespace Ex04_RPG;

class Program
{
    static void Main()
    {
        // Criando personagens
        Personagem guerreiro = new Personagem("Arthur", Classe.Guerreiro);
        Personagem mago = new Personagem("Merlin", Classe.Mago);

        Console.WriteLine("=== PERSONAGENS ===");
        Console.WriteLine(guerreiro);
        Console.WriteLine(mago);

        // Teste de dano
        Console.WriteLine("\n=== DANO ===");
        Console.WriteLine(guerreiro.ReceberDano(40));
        Console.WriteLine(guerreiro);

        // Cura parcial
        Console.WriteLine("\n=== CURA PARCIAL ===");
        Console.WriteLine(guerreiro.Curar(20));
        Console.WriteLine(guerreiro);

        // Cura total (sobrecarga)
        Console.WriteLine("\n=== CURA TOTAL ===");
        Console.WriteLine(guerreiro.Curar());
        Console.WriteLine(guerreiro);

        // Matar personagem
        Console.WriteLine("\n=== MORTE ===");
        Console.WriteLine(guerreiro.ReceberDano(999));
        Console.WriteLine(guerreiro);

        // Tentar curar morto
        Console.WriteLine("\n=== CURAR MORTO ===");
        Console.WriteLine(guerreiro.Curar());

        // Ressuscitar
        Console.WriteLine("\n=== RESSUSCITAR ===");
        Console.WriteLine(guerreiro.Ressuscitar());
        Console.WriteLine(guerreiro);

        // Subir nível
        Console.WriteLine("\n=== SUBIR NÍVEL ===");
        Console.WriteLine(guerreiro.SubirNivel());
        Console.WriteLine(guerreiro);

        // Teste nível máximo
        Console.WriteLine("\n=== TESTE NÍVEL MÁXIMO ===");
        for (int i = 0; i < 100; i++)
        {
            mago.SubirNivel();
        }
        Console.WriteLine(mago);

        Console.WriteLine("\n=== FIM ===");
    }
}