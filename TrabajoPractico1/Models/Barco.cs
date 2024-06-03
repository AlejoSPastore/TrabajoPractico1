using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Models
{
    public class Barco
    {
        public int cargamento { get; set; }
        public int tripulacion { get; set; }

        public Barco(int cargamento, int tripulacion)
        {
            this.cargamento = cargamento;
            this.tripulacion = tripulacion;
        }

        public bool ValeLaPenaSaquear() //metodo para saquear barcos
        {
            int pesoTripulacion = tripulacion * 1; // Asumiendo 1 unidad de peso por cada tripulante
            int cargamentoRestante = cargamento - pesoTripulacion;
            return cargamentoRestante > 20;
        }

        public override string ToString()
        {
            return $"Cargamento: {Cargamento} kg, Tripulación: {Tripulacion} personas";
        }
    }

}
