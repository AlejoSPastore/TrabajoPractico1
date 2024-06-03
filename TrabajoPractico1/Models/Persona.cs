using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Models
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public void Hablar() // método hablar
        {
            Console.WriteLine($"Me llamo {nombre}, me considero {genero} y tengo {edad} años.");
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, Género: {genero}";
        }
    }

}
