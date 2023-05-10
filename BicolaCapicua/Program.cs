using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        class Node
        {
           
            
        }

        class Bicola
        {
           

            public bool EsCapicua()
            {
                while (this.Frente != null)
                {
                    if (this.DesencolarFrenteInt() != this.DesencolarFinalInt())
                        return false;

                    if (this.Frente == this.Final)
                        break;
                }

                return true;
            }

            internal class Program
            {

                static void Main(string[] args)
                {
                    Bicola bicolaCapicua = new Bicola();
                    int numero;
                    Console.Write("Ingrese un número: ");
                    numero = int.Parse(Console.ReadLine());

                    while (numero % 10 != 0)
                    {
                        bicolaCapicua.EncolarFrenteInt(numero % 10);
                        numero /= 10;
                    }

                    if (bicolaCapicua.EsCapicua())
                        Console.WriteLine("El número es capicúa.");
                    else
                        Console.WriteLine("El número no es capicúa.");


                }
            }
        }
    }
}