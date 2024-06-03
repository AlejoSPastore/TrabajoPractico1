using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Models
{
    public class Bloque
    {
        public int largo { get; set; }
        public int ancho { get; set; }
        public int alto { get; set; }

        public Bloque(int largo, int ancho, int alto)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }

        public int ObtenerLargo()
        {
            return largo;
        }

        public int ObtenerAncho()
        {
            return ancho;
        }

        public int ObtenerAlto()
        {
            return alto;
        }

        public int ObtenerVolumen() //metodo para sacar el volumen
        {
            return largo * ancho * alto;
        }

        public int ObtenerAreaSuperficie() // metodo para sacar el area
        {
            int areaFrontal = largo * alto;
            int areaLateral = ancho * alto;
            int areaSuperior = largo * ancho;
            return 2 * (areaFrontal + areaLateral + areaSuperior);
        }

        public override string ToString()
        {
            return $"Largo: {largo}, Ancho: {ancho}, Alto: {alto}";
        }
    }

}
