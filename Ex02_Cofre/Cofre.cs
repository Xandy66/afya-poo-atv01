using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex02_Cofre;

public class Cofre
{
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativasErradas;

    public Cofre(string dono, string senha)
    {
        this.dono = dono;
        this.senha = senha;
        estaAberto = false;
        tentativasErradas = 0;
    }

    public string Dono => dono;
    public bool EstaAberto => estaAberto;
    public int TentativasErradas => tentativasErradas;
    public bool EstaBloqueado => tentativasErradas >= 3;


    public string Abrir(string senhaInformada)
    {
        if (EstaBloqueado)
        {
            return "Cofre Bloqueado";
        }

        if (estaAberto)
        {
            return "Cofre já está aberto";
        }

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativasErradas = 0;
            return "Cofre Aberto";
        }
        else
        {
            tentativasErradas++;
            return "Senha Incorreta";
        }
    }

    public string Fechar()
    {

        if (!estaAberto)
            return "O cofre já está fechado";

        estaAberto = false;
        return "Cofre fechado";
    }

    public string AlterarSenha(string senhaAntiga, string novaSenha)
    {

        if (string.IsNullOrWhiteSpace(novaSenha))
            return "A nova senha não pode ser vazia";

        if (estaAberto && senhaAntiga == senha)
        {
            senha = novaSenha;
            return "Senha redefinida";
        }

        return "Não foi possível alterar a senha";
    }


    public string Reset(string senhaDono)
    {
        if (senhaDono == senha)
        {
            tentativasErradas = 0;
            estaAberto = false;
            return "Cofre desbloqueado e resetado";
        }
        return "Senha inválida para reset";
    }


    public override string ToString()
    {
        string estado = estaAberto ? "Aberto" : "Fechado";
        string bloqueio = EstaBloqueado ? " [BLOQUEADO]" : "";
        return $"Cofre de {dono} | Estado: {estado}{bloqueio} | Tentativas erradas: {tentativasErradas}";
    }
}

