using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace l16_LERT_1071922
{
    class PruebaVector2
    {

        private int[] edad;
        private string[] nombres;


        public void Cargar()
        {
            string opcion;
            int numero1, numero2;

            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1: ------>  Empleados");
            Console.WriteLine("Presione 2: ------>  puestos");
            Console.WriteLine("Presione 3: ------>  Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":

                    string[] nombres = new string[5];
                    int[] calculo = new int[5];
                    int[] edad = new int[5];

                    for (int i = 0; i < nombres.Length; i++)
                    {
                        Console.Write("Ingrese el nombre: ");
                        nombres[i] = Console.ReadLine();
                        Console.Write("Ingrese el año que nacio de: " + nombres[i]);
                        edad[i] = int.Parse(Console.ReadLine());
                        calculo[i] = 2022 - edad[i];
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(nombres[i] + "tiene" + calculo[i] + "años");
                    }


                    break;


                case "2":
                    string[] puesto = new string[5];
                    double[] salario = new double[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Ingrese el puesto: ");
                        puesto[i] = Console.ReadLine();
                        Console.Write("Ingrese el salario de: " + puesto[i]);
                        salario[i] = double.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(puesto[i] + "el salario es de" + salario[i]);
                    }

                    break;
                case "3":
                    Console.WriteLine("Chao");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Aqui no es ");
                    break;

            }
            Console.ReadKey();
        }
    }
}

           
