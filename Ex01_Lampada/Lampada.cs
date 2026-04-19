

namespace Ex01_Lampada;

public class Lampada
{
    private readonly string marca;
    private readonly string tecnologia;
    private bool ligada;
    private int brilho;

    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        this.ligada = false;
        this.brilho = 100;
    }

    public string Marca => marca;
    public string Tecnologia => tecnologia;
    public bool Ligada => ligada;
    public int Brilho => brilho;

    public string Estado => ligada ? "Ligada" : "Desligada";

    public void Alternar()
    {
        ligada = !ligada;
    }

    public void AjustarBrilho(int novoBrilho)
    {
        if (ligada && novoBrilho >= 0 && novoBrilho <= 100)
        {
            brilho = novoBrilho;
        }
    }

    public override string ToString()
    {
        return $"Marca: {marca} | Tecnologia: {tecnologia} | Estado: {Estado} | Brilho: {brilho}%";
    }
}
