namespace Ex01_Lampada;
class Program
{
    static void Main(string[] args)
    {
        Lampada lampada = new Lampada("Philips", "LED");

        Console.WriteLine(lampada);

        lampada.Alternar();
        lampada.AjustarBrilho(50);

        Console.WriteLine(lampada);
    }
}