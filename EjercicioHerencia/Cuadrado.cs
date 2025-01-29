using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioHerencia
{
    public class Cuadrado:Operaciones
    {
        public double LadoCuadrado { get; set; }

        public double PerimetroCuadrado { get; set; }

        public double AreaCuadrado { get; set; }

        public double VolumenCuadrado { get; set; }

        public void Imprimir()
        {

            Console.WriteLine($"Perimetro de Cuadrado: {Longitud(LadoCuadrado)}");
            Console.WriteLine($"Area de Cuadrado: {Area(LadoCuadrado)}");
            Console.WriteLine($"Area de Cuadrado: {Volumen(LadoCuadrado)}");


        }
    }
}
