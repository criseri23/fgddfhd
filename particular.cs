class Particular : Vehiculo
{
    public Particular(string patente, decimal saldo)
        : base(patente, saldo)
    {
    }

    public override string PagarPeaje(decimal tarifa)
    {
        if (Saldo >= tarifa)
        {
            Saldo -= tarifa;
            return $"Particular {Patente}: Paso autorizado. Saldo restante: ${Saldo}";
        }

        return $"Particular {Patente}: Paso denegado.";
    }
}