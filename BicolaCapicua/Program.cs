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
            public int DatoInt { get; set; }

            public Node Siguiente { get; set; }
            public Node Anterior { get; set; }

        }

        class Bicola
        {
            public Node Frente { get; set; }
            public Node Final { get; set; }

            public Bicola()
            {
                this.Frente = this.Final = null;
            }

            public void EncolarFrenteInt(int valor)
            {
                Node NuevoBC = new Node();
                NuevoBC.DatoInt = valor;
                NuevoBC.Anterior = null;

                if (this.Frente == null)
                {
                    this.Final = NuevoBC;
                    NuevoBC.Anterior = null;
                }
                else
                {
                    this.Frente.Anterior = NuevoBC;
                    NuevoBC.Siguiente = this.Frente;
                }
                this.Frente = NuevoBC;
            }
            public int DesencolarFinalInt()
            {
                Node aux = this.Final;
                int valor = aux.DatoInt;
                if (this.Frente == this.Final)
                {
                    this.Frente = null;
                    this.Final = null;
                }
                else
                {
                    this.Final = this.Final.Anterior;
                    this.Final.Siguiente = null;

                }

                aux = null;
                return valor;
            }
            public int DesencolarFrenteInt()
            {
                Node aux = this.Frente;
                int valor = aux.DatoInt;

                if (this.Frente == this.Final)
                {
                    this.Frente = null;
                    this.Final = null;
                }
                else
                {
                    this.Frente = this.Frente.Siguiente;
                    this.Frente.Anterior = null;
                }

                aux = null;
            
            }

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