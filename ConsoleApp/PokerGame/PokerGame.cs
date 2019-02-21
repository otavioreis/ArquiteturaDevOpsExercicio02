using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class PokerGame : IPokerGame
    {
        public PokerGame()
        {

        }

        public List<Carta> MaoJogadorUm { get; set; }
        public List<Carta> MaoJogadorDois { get; set; }





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
            bool isTrinca = false;

            for (int i = 0; i < maoJogador.Count; i++)
            {
                for (int j = i + 1; j < maoJogador.Count; j++)
                {
                    for (int k = j + 1; k < maoJogador.Count; k++)
                    {
                        if (maoJogador[i].Valor == maoJogador[j].Valor &&
                            maoJogador[i].Valor == maoJogador[k].Valor)
                        {
                            isTrinca = true;
                        }
                    }
                }
            }

            return isTrinca;
        }
        public bool IsDoisPares(List<Carta> maoJogador)
        {
            int numeroPares = 0;
            for (int i = 0; i < maoJogador.Count; i++)
            {
                for (int j = i + 1; j < maoJogador.Count; j++)
                {
                    if (maoJogador[i].Valor == maoJogador[j].Valor)
                    {
                        numeroPares++;
                    }
                }
            }

            if (numeroPares == 2)
                return true;

            return false;
        }
        public bool IsUmPar(List<Carta> maoJogador)
        {
            int numeroPares = 0;
            for (int i = 0; i < maoJogador.Count; i++)
            {
                for (int j = i + 1; j < maoJogador.Count; j++)
                {
                    if (maoJogador[i].Valor == maoJogador[j].Valor)
                    {
                        numeroPares++;
                    }
                }
            }

            if (numeroPares == 1)
                return true;

            return false;
        }

        public string Jogar()
        {
            var baralho = new Baralho();

            Random r = new Random();
            List<Carta> maosJogadores = baralho.Cartas.OrderBy(x => r.Next()).Take(10).ToList();

            MaoJogadorUm = maosJogadores.Take(5).ToList();
            MaoJogadorDois = maosJogadores.Skip(5).Take(5).ToList();
            Console.WriteLine("isUmPar: " + IsUmPar(MaoJogadorUm));
            Console.WriteLine("isDoisPares: " + IsDoisPares(MaoJogadorUm));
            Console.WriteLine("IsTrinca: " + IsTrinca(MaoJogadorUm));
            Console.WriteLine("----------");
            Console.WriteLine("isUmPar: " + IsUmPar(MaoJogadorDois));
            Console.WriteLine("isDoisPares: " + IsDoisPares(MaoJogadorDois));
            Console.WriteLine("IsTrinca: " + IsTrinca(MaoJogadorDois));

            return "";
        }

        public PesoMao PesoMaoJogador(List<Carta> maoJogador)
        {
            throw new NotImplementedException();
        }
    }
}