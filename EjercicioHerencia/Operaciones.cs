using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {

        public double Longitud(double dimension)
        {
            return 4*dimension;
        }

        public double Area(double dimension)
        {
            return dimension * dimension;
        }

        public double Volumen(double dimension)
        {
            return dimension * dimension * dimension;
        }

    }
}
