using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Baralho
    {
        public Baralho()
        {
            this.CriarBaralho();
        }

        public List<Carta> Cartas { get; set; }

        private void CriarBaralho()
        {
            Cartas = new List<Carta>();
            var naipes = Enum.GetValues(typeof(Naipe)).Cast<Naipe>();
            var valores = Enum.GetValues(typeof(Valor)).Cast<Valor>();

            foreach (var naipe in naipes)
            {
                foreach (var valor in valores)
                {
                    var carta = new Carta()
                    {
                        Valor = valor,
                        Naipe = naipe
                    };

                    Cartas.Add(carta);
                }
            }
        }
    }
}