using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Venta
    {

		private float subtotal;

		public float Subtotal
		{
			get { return subtotal; }
			set { subtotal = value; }
		}


		private List<ItemVenta> items = new List<ItemVenta>();

		public List<ItemVenta> Items
		{
			get { return items; }
			set { items = value; }
		}

		public void Calcular()
		{
			for (int n = 0; n < Items.Count; n++)
			{
				subtotal += Items[n].CalcularItemTotal();
			}
		}

	}
}