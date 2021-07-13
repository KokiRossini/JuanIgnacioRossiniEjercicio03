using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanIgnacioRossiniEjercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            int finTabla, inicioTabla;
            double temperaturaConvertida;
            double mayorTemp, promedioTemp, sumaTemp;

            inicioTabla = 1;
            mayorTemp = -100;
            sumaTemp = 0;
            promedioTemp = 0;

            Console.WriteLine("ingrese por que temperatura quiere que inicie la tabla");
            inicioTabla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese en que temperatura quiere que finalice la tabla");
            finTabla = Convert.ToInt32(Console.ReadLine());

            if (finTabla>-70 && finTabla<60 && inicioTabla>-70 &&inicioTabla<60)
            {
                for (inicioTabla=inicioTabla; inicioTabla <=finTabla; inicioTabla++)
                {
                    temperaturaConvertida = 1.8 * inicioTabla + 32;

                    Console.WriteLine($"{inicioTabla}ºC = {temperaturaConvertida}º Fharenheit");
                    if (temperaturaConvertida>mayorTemp)
                    {
                        mayorTemp = temperaturaConvertida;
                    }
                    sumaTemp += temperaturaConvertida;
                }
                promedioTemp = sumaTemp / finTabla;
                Console.WriteLine("fin tabla...");
                Console.WriteLine($"la mayor temperatura registrada fue:{mayorTemp}");
                Console.WriteLine($"el promedio de las temperaturas fue:{promedioTemp}");
            }
            else
            {
                Console.WriteLine("ingrese una temperatura entre -70 y 60");
            }
            Console.ReadLine();
        }
    }
}
