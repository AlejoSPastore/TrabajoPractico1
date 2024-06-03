using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Models
{
    public class Tanque
    {
        public string nombre { get; set; }
        public string pais { get; set; }
        public int año { get; set; }
        public int peso { get; set; }
        public List<string> aliados { get; set; }

        public Tanque(string nombre, string pais, int año, int peso, List<string> aliados)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.año = año;
            this.peso = peso;
            this.aliados = aliados;
        }

        public static void Batalla(Tanque tanque1, Tanque tanque2) // metodo para la batalla
        {
            Console.WriteLine("Tanque 1:");
            Console.WriteLine(tanque1);
            Console.WriteLine("\nTanque 2:");
            Console.WriteLine(tanque2);

            int puntuacionTanque1 = tanque1.Año + tanque1.Peso;
            int puntuacionTanque2 = tanque2.Año + tanque2.Peso;

            Console.WriteLine("\nResultado de la batalla:");
            if (puntuacionTanque1 > puntuacionTanque2)
            {
                Console.WriteLine($"{tanque1.Nombre} gana la batalla!");
            }
            else if (puntuacionTanque1 < puntuacionTanque2)
            {
                Console.WriteLine($"{tanque2.Nombre} gana la batalla!");
            }
            else
            {
                Console.WriteLine("La batalla termina en empate!");
            }
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, País: {pais}, Año: {año}, Peso: {peso} toneladas, Aliados: {string.Join(", ", aliados)}";
        }
    }

}
