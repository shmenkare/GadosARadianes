using System;
using System.Collections.Generic;
using System.Text;

namespace GadosARadianes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grados a Radianes 1.0
            /*Una revolución completa es igual a 2? rad
            (o) 360°. 
            1° = 0,017453 radianes y 1 rad = 57,2958°. 
            Para convertir un ángulo de grados a radianes,
            lo multiplicamos por ?/180°. Para convertir un ángulo de radianes a grados,
            lo multiplicamos por 180°/?.*/

            double grados = 1.0;
            double radian = 1.0;

            Console.WriteLine("Introduce los grados a convertir");
            grados= Convert.ToDouble(Console.ReadLine());

            radian = grados*0.017453;

            Console.WriteLine("{0} grados es igual a {1} radianes", grados, radian);

            Console.ReadKey();


        }
    }
}
