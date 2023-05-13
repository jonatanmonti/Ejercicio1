using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        //creamos un objeto libreria del tipo libreria
        public Libreria lib = new Libreria();
        //creamos un objeto VentaActual del tipo Venta el cual le asignamos valor null
        private Venta VentaActual = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //este es el boton de Add, que se va a encargar de agregar los productos a la lista
            //hacemos un if para validar los textbox para que no se nos rompa el programa
            if (!string.IsNullOrWhiteSpace(textBoxCB.Text)&&!string.IsNullOrWhiteSpace(textBoxNombre.Text)&&!string.IsNullOrWhiteSpace(textBoxDescripcion.Text)&&!string.IsNullOrWhiteSpace(this.maskedTextBoxPrecio.Text))
            {
                Producto p = new Producto();

                p.CB = textBoxCB.Text;
                p.Nombre = textBoxNombre.Text;
                p.Descripcion = textBoxDescripcion.Text;
                p.Precio = float.Parse(maskedTextBoxPrecio.Text);

                ListBoxProducto.DataSource = null;
                ListBoxProducto.DataSource = p;
            }
        }
    }
}
