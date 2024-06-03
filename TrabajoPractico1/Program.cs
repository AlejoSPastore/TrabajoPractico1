using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    class Program
    static void Main(string[] args)
    {
        Persona persona1 = new Persona("Juan", 30, "Masculino");
        Persona persona2 = new Persona("Ana", 25, "Femenino");

        persona1.Hablar();
        persona2.Hablar();
    }
    static void Main(string[] args)
    {
        Barco barco1 = new Barco(5000, 20);
        Barco barco2 = new Barco(10000, 50);
        Barco barco3 = new Barco(25, 4);

        Console.WriteLine(barco1);
        Console.WriteLine($"¿Vale la pena saquear? {barco1.ValeLaPenaSaquear()}");

        Console.WriteLine(barco2);
        Console.WriteLine($"¿Vale la pena saquear? {barco2.ValeLaPenaSaquear()}");

        Console.WriteLine(barco3);
        Console.WriteLine($"¿Vale la pena saquear? {barco3.ValeLaPenaSaquear()}");
    }


    static void Main(string[] args)
    {
        List<string> aliados1 = new List<string> { "EE.UU.", "Reino Unido", "Francia" };
        Tanque tanque1 = new Tanque("M1 Abrams", "EE.UU.", 1980, 60, aliados1);

        List<string> aliados2 = new List<string> { "Rusia", "China", "India" };
        Tanque tanque2 = new Tanque("T-90", "Rusia", 1992, 48, aliados2);

        Tanque.Batalla(tanque1, tanque2);
    }

    static void Main(string[] args)
    {
        Bloque bloque1 = new Bloque(10, 5, 3);

        Console.WriteLine(bloque1);
        Console.WriteLine($"Largo: {bloque1.ObtenerLargo()}");
        Console.WriteLine($"Ancho: {bloque1.ObtenerAncho()}");
        Console.WriteLine($"Alto: {bloque1.ObtenerAlto()}");
        Console.WriteLine($"Volumen: {bloque1.ObtenerVolumen()}");
        Console.WriteLine($"Área de Superficie: {bloque1.ObtenerAreaSuperficie()}");
    }






}
