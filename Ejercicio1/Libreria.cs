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

		private float recaudacion;

		public float Recaudacion
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}

		public void CalcularRecaudacion()
		{
			recaudacion = 0;
			for (int n = 0; n < ventas.Count; n++)
			{
				ventas[n].CalcularSubtotal();
				recaudacion += ventas[n].Subtotal;
			}
						

		}

	}
}