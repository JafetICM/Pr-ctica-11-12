using System;

public class Nodo
{
    public string Placas { get; set; }
    public string Propietario { get; set; }
    public DateTime HoraEntrada { get; set; }

    public Nodo(string placas, string propietario)
    {
        Placas = placas;
        Propietario = propietario;
        HoraEntrada = DateTime.Now; // Captura la hora de entrada automáticamente
    }
}
