using System;
using System.Collections.Generic;

public class Estacionamiento
{
    private List<Nodo> autosEstacionados; // Lista para almacenar los autos

    public Estacionamiento()
    {
        autosEstacionados = new List<Nodo>();
    }

    // Método para verificar si el estacionamiento está vacío
    public bool EstaVacio()
    {
        return autosEstacionados.Count == 0;
    }

    // Método para ingresar un auto al estacionamiento
    public void IngresarAuto(string placas, string propietario)
    {
        Nodo nuevoAuto = new Nodo(placas, propietario);
        autosEstacionados.Add(nuevoAuto); // Agregar auto a la lista

        Console.WriteLine($"Auto ingresado con placas: {placas}, Propietario: {propietario}, Hora de entrada: {nuevoAuto.HoraEntrada}");
    }

    // Método para sacar un auto del estacionamiento
    public void SalidaAuto()
    {
        if (EstaVacio())
        {
            Console.WriteLine("El estacionamiento está vacío.");
            return;
        }

        // El primer auto en la lista es el que sale
        Nodo autoSalida = autosEstacionados[0];
        DateTime horaSalida = DateTime.Now;
        TimeSpan tiempoEstacionado = horaSalida - autoSalida.HoraEntrada;
        double costo = tiempoEstacionado.TotalSeconds * 2.00;

        Console.WriteLine($"\nAuto con placas: {autoSalida.Placas}");
        Console.WriteLine($"Propietario: {autoSalida.Propietario}");
        Console.WriteLine($"Hora de entrada: {autoSalida.HoraEntrada}");
        Console.WriteLine($"Hora de salida: {horaSalida}");
        Console.WriteLine($"Tiempo estacionado: {tiempoEstacionado.TotalSeconds:F2} segundos");
        Console.WriteLine($"Costo total: ${costo:F2}");

        // Eliminar el auto de la lista (el primero)
        autosEstacionados.RemoveAt(0);
    }
}
