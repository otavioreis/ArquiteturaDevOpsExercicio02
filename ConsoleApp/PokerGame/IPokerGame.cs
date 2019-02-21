using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    public interface IPokerGame
    {
        List<Carta> MaoJogadorUm { get; set; }
        List<Carta> MaoJogadorDois { get; set; }
        
        bool IsRoyalFlush(List<Carta> maoJogador);
        bool IsStraightFlush(List<Carta> maoJogador);
        bool IsQuadra(List<Carta> maoJogador);
        bool IsFullHouse(List<Carta> maoJogador);
        bool IsFlush(List<Carta> maoJogador);
        bool IsStraight(List<Carta> maoJogador);
        bool IsTrinca(List<Carta> maoJogador);
        bool IsDoisPares(List<Carta> maoJogador);
        bool IsUmPar(List<Carta> maoJogador);
        bool IsCartaAlta(List<Carta> maoJogador);

        PesoMao PesoMaoJogador(List<Carta> maoJogador);

        string Jogar();
    }

}