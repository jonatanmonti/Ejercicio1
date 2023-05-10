using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Libreria
    {

		private List<Producto> productos = new List<Producto>();

		public List<Producto> Productos
		{
			get { return productos; }
			set { productos = value; }
		}

		private List<Venta> ventas = new List<Venta>();

		public List<Venta> Ventas
		{
			get { return ventas; }
			set { ventas = value; }
		}

		public void Calcular()
		{

		}

	}
}