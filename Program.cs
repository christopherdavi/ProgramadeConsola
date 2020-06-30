using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_programa
{
    class Principal

    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su nombre: ");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.Write("Escriba su primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba su segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado;

            resultado = num1 + num2;

            Console.WriteLine("El resultado es " + nombre);
            Console.WriteLine("El resultado es " + resultado);

            Console.ReadLine();

        }


    }
}


