using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNomina
{
    public class Nomina
    {
        private int diastrabajados;

        public int Diastrabajados { get; set; }

        // metodo para calcular nomina

        public decimal CalcularNomina(int diaslab, decimal valordia)
        {
          decimal totalSalario = diaslab * valordia;
          return totalSalario;


        }
    }
}
