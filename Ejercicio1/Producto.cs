using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    public class Producto
    {

		//declaramos nuestras propiedades cb, nombre, descripcion, precio.

		private string cb;

		public string CB
		{
			get { return cb; }
			set { cb = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private float preico;

		public float Precio
		{
			get { return preico; }
			set { preico = value; }
		}



	}
}