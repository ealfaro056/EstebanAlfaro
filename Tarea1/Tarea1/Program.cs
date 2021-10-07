using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double num1, num2, total;
            int num3 = 0;
            int num4 = 0;
            String palindromo,  inverso, num5;
            int largo;

            do
            {


                Console.WriteLine("***Menu***");
                Console.WriteLine("------------------------------ ");
                Console.WriteLine(" ");
                Console.WriteLine("1. Suma\n" + "2. Resta\n" + "3. Multiplicacion\n"
                    + "4. Division\n" + "5. Numero Primo\n" + "6. Numero Palíndromo\n" + "7. Salir");
                Console.WriteLine("------------------------------ ");

                Console.Write("Indique la operacion: ");


                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Sumar:");
                        Console.WriteLine("------------------------------ ");
                        Console.WriteLine("Ingrese un numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        total = num1 + num2;

                        Console.WriteLine("Total: " + total);
                        Console.ReadKey();

                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Restar:");
                        Console.WriteLine("------------------------------ ");
                        Console.WriteLine("Ingrese un numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        total = num1 - num2;

                        Console.WriteLine("Total: " + total);
                        Console.ReadKey();

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("Multiplicar:");
                        Console.WriteLine("------------------------------ ");
                        Console.WriteLine("Ingrese un numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        total = num1 * num2;

                        Console.WriteLine("Total: " + total);
                        Console.ReadKey();

                        break;
                    case 4:

                        Console.Clear();
                        Console.WriteLine("Dividir:");
                        Console.WriteLine("------------------------------ ");
                        Console.WriteLine("Ingrese un numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        total = num1 / num2;

                        Console.WriteLine("Total: " + total);
                        Console.ReadKey();

                        break;

                    case 5:
                        Console.WriteLine("Numero Primo:");
                        Console.WriteLine("------------------------------ ");
                        Console.WriteLine("Ingrese un numero: ");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < (num3+1); i++)
                        {
                            if (num3%i==0)
                            {
                                num4++;
                            }

                        }
                        if (num4!=2)
                        {
                            Console.WriteLine("No es numero Primo");

                        }
                        else
                        {
                            Console.WriteLine("Es numero Primo");
                        }
                        Console.ReadKey();

                        break;
                    case 6:
                        Console.WriteLine("Numero Palíndromo:");
                        Console.WriteLine("------------------------------ ");
                        Console.WriteLine("Ingrese un numero: ");
                        palindromo = Console.ReadLine();
                        largo = palindromo.Length;
                        inverso = "";
                        
                            for (int i = largo - 1; i >= 0; i--)
                            {
                                num5 = palindromo.Substring(i, 1);
                                inverso = inverso +  num5;
                            }
                            
                            if (palindromo==inverso)
                            {
                                Console.WriteLine("EL numero es palindromo");
                                Console.WriteLine("EL numero inverso es: " + inverso);


                        }

                        else
                            {
                                Console.WriteLine("EL numero no es palindromo");
                            }

                        Console.ReadKey();

                        break;
                    case 7:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida, precione ENTER para volver al Menu");
                        break;

                }


               


            } while (opcion != 7);

            Console.Write("Seleccione 7 para salir o enter para volver al menu: ");




        }
    }
}
