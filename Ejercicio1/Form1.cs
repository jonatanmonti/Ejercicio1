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
        public Libreria Lib = new Libreria();
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

                p.CB = textBoxCB.Text; //cargamos el codigo de barra
                p.Nombre = textBoxNombre.Text; //cargamos el nombre
                p.Descripcion = textBoxDescripcion.Text; //cargamos la descripcion
                p.Precio = float.Parse(maskedTextBoxPrecio.Text); //cargamos el precio

                Lib.Productos.Add(p); //agregamos productos a nuestra list

                ListBoxProducto.DataSource = null; //null para que refresque la lista
                ListBoxProducto.DataSource = Lib.Productos; //agregamos los productos al listbox

                ListBoxProducto.DisplayMember = "Nombre";
                
            }
        }

        private void buttonFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (VentaActual != null && VentaActual.Items.Count > 0) //validamos que inicio la venta para no tener errores
            {
                Lib.Ventas.Add(VentaActual); //agregamos nuestra lista d eventa a nuestra libreria
                VentaActual = null; //marcamos que la venta es null para indicar que cerramos la venta

                Lib.CalcularRecaudacion(); //calculamos la recaudacion total
                labelTotal.Text = "Total: " + Lib.Recaudacion.ToString(); //la mostramos reemplazando el texto de nuestro label
            }

            
        }

        private void buttonIniciarVenta_Click_1(object sender, EventArgs e)
        {
            VentaActual = new Venta(); //inicializamos la venta
        }

        private void buttonCant_Click_1(object sender, EventArgs e)
        {
            if (VentaActual != null)
            {
                ItemVenta item = new ItemVenta(); //creamos nuestro objeto item

                item.Cant = int.Parse(maskedTextBoxCantidad.Text); //guardamos la cantidad en nuestro objeto item
                item.Articulo = (Producto)ListBoxProducto.SelectedItem; //le indicamos que el articulo es el que esta seleccionado en la lista de productos
                VentaActual.Items.Add(item); //agregamos el item dentro de nuestra lista de items
                VentaActual.CalcularSubtotal(); //se calcula el subtotal de los items
                labelSubtotal.Text = "Subtotal: " + VentaActual.Subtotal.ToString(); //cambiamos el texto del label por el valor del subtotal

                listBoxArticulos.DataSource = null; //se refresca la lista
                listBoxArticulos.DataSource = VentaActual.Items; //agregamos a la lista de articulos (el carrito), los productos con su total calculado
                listBoxArticulos.DisplayMember = "desc";    //mostramos en pantalla la informacion correcta
            }
        }
    }
}
