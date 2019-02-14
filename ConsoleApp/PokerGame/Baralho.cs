using System;
using System.Collections.Generic;
using System.Linq;

public class Baralho
{
    public Baralho()
    {
        this.CriarBaralho();
    }

    public List<Carta> Cartas{get; set;}

    private void CriarBaralho()
    {
        Cartas = new List<Carta>();

        foreach(var naipe in Enum.GetValues(typeof(Naipe)).Cast<Naipe>()){
            foreach(var valor in Enum.GetValues(typeof(Valor)).Cast<Valor>()){
                var carta = new Carta(){
                    Valor = valor,
                    Naipe = naipe
                };

                Cartas.Add(carta);
            }
        }
    }
}