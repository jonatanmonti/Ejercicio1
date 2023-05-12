using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Libreria
    {
		//creamos nuestra lista de productos ya que se va a ignresar varios productos
		private List<Producto> productos = new List<Producto>();

		public List<Producto> Productos
		{
			get { return productos; }
			set { productos = value; }
		}
		//creamos nuestra lista de venta ya que no va a haber solo una venta
		private List<Venta> ventas = new List<Venta>();

		public List<Venta> Ventas
		{
			get { return ventas; }
			set { ventas = value; }
		}
		//creamos nuestra propiedad recaudacion
		private float recaudacion;

		public float Recaudacion
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}
		//creamos el metodo CalcularRecaudacion para obtener la recaudacion total de cada venta
		public void CalcularRecaudacion()
		{
			//hacemos un for para recorrer la lista de venta
			recaudacion = 0;
			for (int n = 0; n < ventas.Count; n++)
			{
				ventas[n].CalcularSubtotal();
				recaudacion += ventas[n].Subtotal;
			}
						

		}

	}
}