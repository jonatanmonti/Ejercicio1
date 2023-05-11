using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Venta
    {

		private List<ItemVenta> items = new List<ItemVenta>();

		public List<ItemVenta> Items
		{
			get { return items; }
			set { items = value; }
		}
	}
}