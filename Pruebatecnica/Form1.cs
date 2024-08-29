using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebatecnica
{
    public partial class Form1 : Form
    {
        int opcion = 0;
        private string nombre = "";
        private string clave = "";
        private int Number = 0;
        private string password = "";
        private string Estado = "";

        myClass[] misempleados= new myClass[5];
        int cantidad = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Usuario
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //No.
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //nombre de palmas
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numberEmployee_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            nombre = nombreEmployee.Text;
            clave = claveEmployee.Text;
            Number =Convert.ToInt32(numberEmployee.Text);
            password = contrasena.Text;
            Estado = Box.Text;
            var usuario = new myClass(nombre, clave, Number, password, Estado);
            MessageBox.Show($"Usuario Guardado: \n      {nombre}","Alerta",MessageBoxButtons.OK);
            misempleados[cantidad]= usuario;
            cantidad = cantidad + 1;
            nombreEmployee.Text = "";
            claveEmployee.Text = "";
            numberEmployee.Text = "";
            contrasena.Text = "";
            Box.Text = "";


        }

        class myClass
        {
            private string nombre = "";
            private string clave = "";
            private int Number = 0;
            private string password = "";
            private string Estado = "";

            public myClass(string myName,string myClave,int myNumber, string myPassword, string myEstado)
            {
                this.nombre = myName;
                this.clave = myClave;
                this.Number = myNumber;
                this.password = myPassword;
                this.Estado = myEstado;
            }


        }

        private void numberEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar<=255)))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            LabelModulo.Text = "Cuentas\t 5 \nUsuario\t 7 \nParametros\t 9 \nInicializar\t 10 \nImportar\t 3 \nExportar\t 9 \nReportar\t 22";
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            LabelModulo.Text = "Cuentas \nUsuario \nParametros \nInicializar ";
        }

        private void LabelCompras_Click(object sender, EventArgs e)
        {
            LabelModulo.Text = "Cuentas \nUsuario \nParametros \nInicializar \nExportar \nReportar";
        }

        private void LabelAlmacen_Click(object sender, EventArgs e)
        {
            LabelModulo.Text = "Exportar \nReportar";
        }
    }
}
