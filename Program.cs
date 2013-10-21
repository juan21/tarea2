using System;

namespace Herencia2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona persona1 = new Persona();
			persona1.Nombre="Juan";
			persona1.Edad=21;
			Persona persona2 = new Persona();
			persona2.Nombre="Fabiola";
			persona2.Edad=23;
			Console.WriteLine("los datos de las personas son:");
			persona1.Imprimir();
			persona2.Imprimir();
			Empleado empleado1=new Empleado();
			empleado1.Nombre="Laura";
			empleado1.Edad=20;
			empleado1.Sueldo=4566;
			Empleado empleado2=new Empleado();
			empleado2.Nombre="Carolina";
			empleado2.Edad=25;
			empleado2.Sueldo=3456;
			Console.WriteLine("\nlos datos de los empleados son");
			empleado1.Imprimir();
			empleado2.Imprimir();
			
			Console.ReadKey();
		}
	}
}