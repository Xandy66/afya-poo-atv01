namespace Ex04_RPG
{
    public enum Classe
    {
        Guerreiro,
        Mago
    }

    public class Personagem
    {
        private string nome;
        private Classe classe;
        private int nivel;
        private int vidaAtual;
        private int vidaMaxima;

        public string Nome => nome;
        public Classe Classe => classe;
        public int Nivel => nivel;
        public int VidaAtual => vidaAtual;
        public int VidaMaxima => vidaMaxima;

        public bool EstaMorto => vidaAtual <= 0;

        public Personagem(string nome, Classe classe)
        {
            this.nome = nome;
            this.classe = classe;
            nivel = 1;
            vidaMaxima = classe == Classe.Guerreiro ? 150 : 80;
            vidaAtual = vidaMaxima;
        }

        public string ReceberDano(int dano)
        {
            if (EstaMorto)
                return $"{nome} já está morto e não pode receber dano.";

            if (dano <= 0)
                return "O valor de dano deve ser maior que zero.";

            vidaAtual -= dano;

            if (vidaAtual < 0)
                vidaAtual = 0;

            if (EstaMorto)
                return $"{nome} recebeu {dano} de dano e morreu!";

            return $"{nome} recebeu {dano} de dano. {this}";
        }

        public string Curar(int pontos)
        {
            if (EstaMorto)
                return $"{nome} está morto. Use Ressuscitar() para revivê-lo.";

            if (pontos <= 0)
                return "O valor de cura deve ser maior que zero.";

            int vidaFaltando = vidaMaxima - vidaAtual;

            if (pontos > vidaFaltando)
            {
                vidaAtual += vidaFaltando;
                return $"Personagem foi curado em {vidaFaltando} pontos de vida, sua vida está cheia!";
            }
            else
            {
                vidaAtual += pontos;
                return $"Personagem foi curado em {pontos} pontos de vida.";
            }
        }

        public string Curar()
        {
            if (EstaMorto)
                return $"{nome} está morto. Use Ressuscitar() para revivê-lo.";

            if (vidaAtual == vidaMaxima)
                return $"{nome} já está com a vida cheia!";

            int vidaFaltando = vidaMaxima - vidaAtual;
            vidaAtual = vidaMaxima;
            return $"{nome} foi completamente curado! Vida restaurada em {vidaFaltando} pontos.";
        }

        public string SubirNivel()
        {
            if (EstaMorto)
                return $"{nome} está morto e não pode subir de nível.";

            if (nivel >= 99)
                return $"{nome} já está no nível máximo (99)!";

            nivel++;
            vidaMaxima = (int)(vidaMaxima * 1.1);
            vidaAtual = vidaMaxima;

            return $"Parabéns! {nome} subiu para o nível {nivel}. "
                 + $"Vida máxima agora é {vidaMaxima} e foi totalmente restaurada.";
        }

        public string Ressuscitar()
        {
            if (!EstaMorto)
                return $"{nome} ainda está vivo, não precisa ressuscitar.";

            vidaAtual = vidaMaxima;

            return $"{nome} foi ressuscitado! Retorna ao nível {nivel} com {vidaAtual}/{vidaMaxima} HP.";
        }

        public override string ToString()
        {
            return $"[{nome}] ({classe}) - Lvl {nivel} - HP: {vidaAtual}/{vidaMaxima}";
        }
    }
}