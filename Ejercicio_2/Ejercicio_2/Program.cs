using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Andy Ramiro Garzón Toaza

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("Elige una de las siguintes opciones:");
                Console.WriteLine("1. Número positivo, negativo o cero");//Escribe un programa que evalúe si un número ingresado por el usuario es positivo, negativo o cero.
                Console.WriteLine("2. Aprobado o Reprobado");//Crea un programa que solicita al usuario ingresar una calificación y luego muestre un mensaje según la calificación ingresada 
                Console.WriteLine("3. Rango de un número");//Desarrolla un programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra 
                Console.WriteLine("4. Días de la semana");//Escribe un programa que solicite al usuario ingresar un número del 1 al 7 y luego muestre el día de la semana correspondiente 
                Console.WriteLine("5. Pperaciones matemáticas");//Ingresar 2 números y luego un carácter indicando la operación a realizar (+, -, *, /) y reportar el resultado de la operación utilizando la sentencia switch.
                Console.WriteLine("0. Salir");//fin de las opciones 
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        EvaluarNumero();
                        break;
                    case 2:
                        EvaluarCalificacion();
                        break;
                    case 3:
                        DeterminarRango();
                        break;
                    case 4:
                        MostrarDiaSemana();
                        break;
                    case 5:
                        RealizarOperacion();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo");
                        break;
                    default:
                        Console.WriteLine("¡ERROR, VUELVE A INTENTAR!");
                        break;
                }

                Console.WriteLine(); 
            } while (opcion != 0);
        }
        




        static void EvaluarNumero()
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            string resultado = (numero > 0) ? "El numero es positivo" :
                               (numero < 0) ? "El número es negativo" :
                               "El número es cero";
            Console.WriteLine(resultado);
        }

        static void EvaluarCalificacion()
        {
            Console.Write("Ingrese la nota obtenida: ");
            double calificacion = Convert.ToDouble(Console.ReadLine()); 
            string resultado = (calificacion >= 60) ? "Aprobado" : "Reprobado";
            Console.WriteLine(resultado);
        }

        static void DeterminarRango()
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            string resultado = (numero < 10) ? "Menor que 10" :
                               (numero >= 10 && numero <= 20) ? "Entre 10 y 20" :
                               "Mayor que 20";
            Console.WriteLine(resultado);
        }




        static void MostrarDiaSemana()
        {
            Console.Write("Ingrese un número del 1 al 7: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            string diaS;
            switch (dia)
            {
                case 1:
                    diaS = "Lunes";
                    break;
                case 2:
                    diaS = "Martes";
                    break;
                case 3:
                    diaS = "Miércoles";
                    break;
                case 4:
                    diaS = "Jueves";
                    break;
                case 5:
                    diaS = "Viernes";
                    break;
                case 6:
                    diaS = "Sábado";
                    break;
                case 7:
                    diaS = "Domingo";
                    break;
                default:
                    diaS = "Número no válido, debe ser entre 1 o 7."; 
                    break;
            }
            Console.WriteLine(diaS);
        }

        static void RealizarOperacion() 
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese que operación desea realizar: (+, -, *, /): ");
            char operacion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double resultado;

            switch (operacion)             {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
        }
    }
}