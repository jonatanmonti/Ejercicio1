using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class ItemVenta
    {

		private int cant; /*creamos nuestra propiedad cantidad donde se va a almacenar
		                   * la cantidad que el usuario quiere comprar*/

        public int Cant
		{
			get { return cant; }
			set { cant = value; }
		}


		private Producto articulo; /*creamos nuestra propiedad articulo en donde se va a almacenar el articulo
		                            * que el usuario eligio*/

        public Producto Articulo
		{
			get { return articulo; }
			set { articulo = value; }
		}

		public float CalcularItemTotal() /*creamos nuestro metodo CalcularItemTotal en donde nos va a retornar
		                                  * la cantidad por el precio del articulo*/

        {
			return Cant * articulo.Precio;
		}

		public string desc
		{
			//aca me devuelve en la lista de articulos el nombre y al lado el precio
			get { return articulo.Nombre + "$" + (cant * articulo.Precio).ToString(); }
			
		}

	}
}