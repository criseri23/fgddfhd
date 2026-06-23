using System;

class Vehiculo
{
    private string patente;
    private decimal saldo;

    public string Patente
    {
        get { return patente; }
        set { patente = value; }
    }

    public decimal Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }

    public Vehiculo(string patente, decimal saldo)
    {
        Patente = patente;
        Saldo = saldo;
    }

    public virtual string PagarPeaje(decimal tarifa)
    {
        if (Saldo >= tarifa)
        {
            Saldo -= tarifa;
            return $"Patente: {Patente} - Peaje pagado. Saldo restante: ${Saldo}";
        }

        return $"Patente: {Patente} - Saldo insuficiente.";
    }
}