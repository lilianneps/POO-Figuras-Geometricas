using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades
{
    public class Hexagono : Forma
    {
        private double lado;

        public Hexagono(double lado)
        {
            this.lado = lado;
        }

        public override string Name
        {
            get { return "Hexágono"; }
        }

        public override double CalcularArea()
        {
            return ((3 * Math.Sqrt(3)) / 2) * lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 6 * lado;
        }
    }
}
