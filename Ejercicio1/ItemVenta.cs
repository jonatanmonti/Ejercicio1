using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class ItemVenta
    {

		private int cant;

		public int Cant
		{
			get { return cant; }
			set { cant = value; }
		}


		private Producto articulo;

		public Producto Articulo
		{
			get { return articulo; }
			set { articulo = value; }
		}

		public float calcular()
		{
			return Cant * articulo.Precio;
		}

	}
}