class Camion : Vehiculo
{
    private int ejes;

    public int Ejes
    {
        get { return ejes; }
        set { ejes = value; }
    }

    public Camion(string patente, decimal saldo, int ejes)
        : base(patente, saldo)
    {
        Ejes = ejes;
    }

    public override string PagarPeaje(decimal tarifa)
    {
        decimal total = tarifa * Ejes;

        if (Ejes > 4)
        {
            total = total * 0.90m; // descuento 10%
        }

        if (Saldo >= total)
        {
            Saldo -= total;

            return $"Camión {Patente} ({Ejes} ejes): Pagó ${total}. Saldo restante: ${Saldo}";
        }

        return $"Camión {Patente} ({Ejes} ejes): Saldo insuficiente. Quedó varado.";
    }
}
