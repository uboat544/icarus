using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CalcularNomina
{
    public partial class Form1 : Form
    {
        Empleado myempleado = new Empleado();
        Nomina ss = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application. Exit();
        }

        private void btnalmacenarregistro_Click(object sender, EventArgs e)
        {
            // Validar que solo ingresen nombres
          // if(txtnombre == " ")
          // {
            //   error1.SetError(txtnombre, " Debe ingresar un nombre");
             //  txtnombre.Focus();
              // return;
          // }
         //  error1.SetError(txtnombre, " ");
            // Validar que solo permita ingresar datos numericos.

         //  decimal asignaciondia;
         //  if (!decimal.TryParse(txtasignaciondia, Text, out asignacionia))
          // {
            //   error1.SetError(txtasignaciondia, " Debe ingresar un numero");
            //   txtnombre.Focus();
             //  return
         //  }

          //   error1.SetError(txtasignaciondia, " ");





            myempleado.Nombre = txtnombre.Text;
            myempleado.Apellido = txtidentificacion.Text; 
            myempleado.Asignaciondia = Convert.ToDecimal(txtasignaciondia.Text);
            ss.Diastrabajados = Convert.ToInt32(txtsueldo.Text);
            MessageBox.Show("Se ha guardado el registro");

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtasignaciondia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcularsalario_Click(object sender, EventArgs e)
        {
            txtsueldototal.Text = ss.CalcularNomina(Convert.ToInt32(ss.Diastrabajados), 
                Convert.ToDecimal(myempleado.Asignaciondia)).ToString();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtasignaciondia.Clear();
            txtsueldo.Clear();
            txtsueldototal.Clear();
        }
    }
}
