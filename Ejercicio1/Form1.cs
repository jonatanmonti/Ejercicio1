using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        public List<Libreria> lib = new List<Libreria> ();
        public Producto p = new Producto ();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCB.Text) && !string.IsNullOrWhiteSpace(textBoxNombre.Text) && !string.IsNullOrWhiteSpace(textBoxDescripcion.Text) && !string.IsNullOrWhiteSpace(this.maskedTextBoxPrecio.Text))
            {

            }
        }
    }
}
