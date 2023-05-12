using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Venta
    {

		private float subtotal; //declaramos nuestra propiedad subtotal para calcular el subtotal de la venta

		public float Subtotal
		{
			get { return subtotal; }
			set { subtotal = value; }
		}

        //hacemos nuestra lista de items ya que para la venta se va a vender mas de un producto
        private List<ItemVenta> items = new List<ItemVenta>(); 

		public List<ItemVenta> Items
		{
			get { return items; }
			set { items = value; }
		}
		//hacemos nuestro metodo Calcular subtotal en el que se va a encargar 
		public void CalcularSubtotal()
		{
			//el for se va a encargar de recorrer nuestra lista de items
			for (int n = 0; n < Items.Count; n++)
			{
				subtotal += Items[n].CalcularItemTotal(); /*calculamos el subtotal multiplicando la cantidad de items
				                                           * por la propiedad CalcularItemTotal de la clase ItemVenta*/
            }												
		}

	}
}