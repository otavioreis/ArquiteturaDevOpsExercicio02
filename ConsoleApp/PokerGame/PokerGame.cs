using System;
using System.Collections.Generic;
namespace ConsoleApp
{
    public class PokerGame : IPokerGame
    {
        public PokerGame()
        {

        }

        public List<Carta> MaoJogadorUm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Carta> MaoJogadorDois { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsCartaAlta(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsDoisPares(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsQuadra(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsRoyalFlush(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsStraightFlush(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsTrinca(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public bool IsUmPar(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }

        public string Jogar()
        {
            throw new NotImplementedException();
        }

        public PesoMao PesoMaoJogador(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }
    }
}