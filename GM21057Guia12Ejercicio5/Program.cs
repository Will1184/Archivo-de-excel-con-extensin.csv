/*
 * Created by SharpDevelop.
 * User: brand
 * Date: 02/06/2022
 * Time: 06:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

// Guía: 12
// Ejercicio: 5
// Fecha: 3/6/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia12Ejercicio5
{
    //Descripcion del programa:
    //Elabore un archivo en excel con extensión.csv en el cual se encuentren los siguientes datos de una cadena de supermercados:
    //ID de la Sucursal, Nombre de la sucursal, Direccion, Telefono, No.De Empleados.
    //(Esto seria el encabezado que no estará en el archivo. Ese archivo solo debe contener
    //datos)

    class Program
    {
		struct Sucursal
		{
			public string sucursalId;
			public string nombreSucursal;
			public string direccionSucursal;
			public string sucursalTelefono;
			public string sucursalEmpleados;

		}
		static StreamWriter Escribir;
		static StreamReader Leer;
		public static void Main(string[] args)
		{
			//Identificacion del programa en pantalla
			Console.Title = ("Datos de las sucursales ");
			Console.WriteLine("Datos de las sucursales  ");
			Console.WriteLine("Autor:Brandon Gomez");
           
			//DECLARACION DE VARIABLES
			string rutaArchivo = @"..\..\..\GM20157Guia12Ejercicio5.cvs";
			string linea, resp;
			string coma=",";
			Sucursal sucursales = new Sucursal();
			
			//ENTRADA DE DATOS
			do
			{
				Escribir = new StreamWriter(rutaArchivo, true);
			    Console.WriteLine("Ingrese el Id de la sucursal"); sucursales.sucursalId = Console.ReadLine().ToUpper();
				Console.WriteLine("Ingrese el nombre de la sucursal"); sucursales.nombreSucursal = Console.ReadLine().ToUpper();
				Console.WriteLine("Ingrese la direccion de la sucursal"); sucursales.direccionSucursal = Console.ReadLine().ToUpper();
				Console.WriteLine("Ingrese el numero de telefono de la sucursal"); sucursales.sucursalTelefono = Console.ReadLine().ToUpper();
				Console.WriteLine("Ingrese el numero de empleados en la sucursal"); sucursales.sucursalEmpleados = Console.ReadLine().ToUpper();
				
			//SALIDA DE DATOS
				Escribir.Write(sucursales.sucursalId+coma+sucursales.nombreSucursal+coma+sucursales.direccionSucursal+coma+sucursales.sucursalTelefono+coma+sucursales.sucursalEmpleados+coma);
				Escribir.Close();
				
			//PROCESO DE DATOS
				Console.WriteLine("¿Hay más registros? (s/n): ");
			
				resp = Console.ReadLine().ToLower();
				if (resp == "n")
					Process.Start ( rutaArchivo);
			} 
			while (resp == "s");
			{Console.Clear();
			Leer = new StreamReader(rutaArchivo);
			
			Console.WriteLine("ID de la Sucursal,Nombre de la sucursal,Direccion,Telefono,No.De Empleados");}
			while (!Leer.EndOfStream)
			{
				linea = Leer.ReadLine();
				Console.WriteLine(linea); 
			}
		   Leer.Close();
           Console.ReadKey();
		}
	}
}
