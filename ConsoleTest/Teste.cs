using System;
using System.Collections.Generic;
using ConsoleApp;
using Xunit;

namespace ConsoleTest
{
   
    public class Teste
    {
        private IPokerGame _game;

        public Teste() {
            _game = new PokerGame();
        }

        [Fact]
        public void Possui_52_cartas() {
            var baralho = new Baralho();
            Assert.Equal(52, baralho.Cartas.Count);
        }

        [Fact]
        [InlineData(Valor.As, Valor.Rei, Valor.Dama, Valor.Valete, Valor.Dez, Naipe.Espadas)]
        [InlineData(Valor.As, Valor.Rei, Valor.Dama, Valor.Valete, Valor.Dez, Naipe.Copas)]
        [InlineData(Valor.As, Valor.Rei, Valor.Dama, Valor.Valete, Valor.Dez, Naipe.Ouro)]
        [InlineData(Valor.As, Valor.Rei, Valor.Dama, Valor.Valete, Valor.Dez, Naipe.Paus)]
        public void Testa_IsRoyalFlush(Valor c1, Valor c2, Valor c3, Valor c4, Valor c5, Naipe n) {
            var maoJogador = new List<Carta> {
                new Carta {Valor = c1, Naipe = Naipe.Espadas},
                new Carta {Valor = c2, Naipe = Naipe.Espadas},
                new Carta {Valor = c3, Naipe = Naipe.Espadas},
                new Carta {Valor = c4, Naipe = Naipe.Espadas},
                new Carta {Valor = c5, Naipe = Naipe.Espadas},
            };
            Assert.True(_game.IsFlush(maoJogador));
        }

        [Fact]
        [InlineData(Valor.Nove, Valor.Oito, Valor.Sete, Valor.Seis, Valor.Cinco)]
        public void Testa_IsStraightFlush(Valor c1, Valor c2, Valor c3, Valor c4, Valor c5) {
            var maoJogador = new List<Carta> {
                new Carta {Valor = c1, Naipe = Naipe.Espadas},
                new Carta {Valor = c2, Naipe = Naipe.Espadas},
                new Carta {Valor = c3, Naipe = Naipe.Espadas},
                new Carta {Valor = c4, Naipe = Naipe.Espadas},
                new Carta {Valor = c5, Naipe = Naipe.Espadas},
            };
            Assert.True(_game.IsStraightFlush(maoJogador));
        }

        [Fact]
        public void Testa_IsQuadra() {
            throw new NotImplementedException();
        }
        [Fact]
        public void Testa_IsFullHouse() {
            throw new NotImplementedException();
        }
        [Fact]
        public void Testa_IsFlush() {
            throw new NotImplementedException();
        }
        [Fact]
        public void Testa_IsStraight() {
            throw new NotImplementedException();
        }
        [Fact]
        public void Testa_IsTrinca() {
            throw new NotImplementedException();
        }
        [Fact]
        public void Testa_IsDoisPares() {
            throw new NotImplementedException();
        }

        [Fact]
        public void Testa_IsUmPar() {
            throw new NotImplementedException();
        }

        [Fact]
        public void Testa_IsCartaAlta() {
            throw new NotImplementedException();
        }       

    }
}
