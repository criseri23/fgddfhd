using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        vehiculos.Add(new Particular("AA111AA", 1000));
        vehiculos.Add(new Particular("BB222BB", 50));
        vehiculos.Add(new Camion("CC333CC", 2000, 3));
        vehiculos.Add(new Camion("DD444DD", 1000, 5));

        decimal tarifaBase = 200;

        foreach (Vehiculo v in vehiculos)
        {
            Console.WriteLine(v.PagarPeaje(tarifaBase));
        }
    }
}