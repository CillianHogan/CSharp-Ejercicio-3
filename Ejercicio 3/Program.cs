using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Ejercicio 3. Crea un programa que guarde dos números (elegidos por el usuario) en dos variables,
            y a continuación muestre por pantalla las cinco operaciones aritméticas básicas: Suma, resta, multiplicación, división y resto.
           */

            int num1 = 0; // Declaración de la primera variable para guardar un número
            int num2 = 0; // Declaración de la segunda variable para guardar otro número

            // Solicita al usuario que escriba el primer número y lo almacena en num1
            Console.WriteLine("Escribe el primer dígito");
            num1 = int.Parse(Console.ReadLine());

            // Solicita al usuario que escriba el segundo número y lo almacena en num2
            Console.WriteLine("Escribe el segundon dígito");
            num2 = int.Parse(Console.ReadLine());

            // Realiza y muestra la suma de las dos variables
            Console.WriteLine("Suma = " + (num1 + num2));

            // Realiza y muestra la resta de las dos variables
            Console.WriteLine("Resta = " + (num1 - num2));

            // Realiza y muestra la multiplicación de las dos variables
            Console.WriteLine("Multiplicación = " + (num1 * num2));

            // Realiza y muestra la división de las dos variables
            Console.WriteLine("División = " + (num1 / num2));

            // Realiza y muestra el resto de la división de las dos variables
            Console.WriteLine("Resto = " + (num1 % num2));

        }
    }
}
