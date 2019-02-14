using System;

public class Carta
{
    public Valor Valor { get; set; }
    public Naipe Naipe { get; set; }
}

public enum Valor
{
    As,
    Dois,
    Tres,
    Quatro,
    Cinco,
    Seis,
    Sete,
    Oito,
    Nove,
    Dez,
    Valete,
    Dama,
    Rei
}

public enum Naipe
{
    Ouro,
    Copas,
    Espadas,
    Paus
}