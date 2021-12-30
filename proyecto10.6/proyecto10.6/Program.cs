using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escriba la cantidad de triangulos que vamos a analizar: ");
                int cantidad = int.Parse(Console.ReadLine());
                //float[] bases = new float[cantidad];
                //float[] alturas = new float[cantidad];
                //float[] superficies = new float[cantidad];
                int SuperficiesMayorA12 = 0;
                int posicion;
                float bases, altura, superficie;

                for (int i = 0; i < cantidad; i++)
                {
                    posicion = i + 1;

                    Console.Write("Escribe el valor de la base del triangulo #" + posicion + ": ");
                    bases = float.Parse(Console.ReadLine());

                    Console.Write("Escribe el valor de la altura del triangulo #" + posicion + ": ");
                    altura = float.Parse(Console.ReadLine());

                    superficie = bases * (altura / 2);

                    if (superficie > 12)
                    {
                        SuperficiesMayorA12 = SuperficiesMayorA12 + 1;
                    }
                    Console.WriteLine("El triangulo #" + posicion + " tiene una base de " + bases + " metros, " + altura + " metros y una superficie de " + superficie + " metros");
                    Console.WriteLine();
                }
                Console.WriteLine("Hay "+SuperficiesMayorA12+" triangulos con una superficie mayor a 12 metros.");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
