using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades
{
    public class Octogono : Forma
    {
        private double lado;

        public Octogono(double lado)
        {
            this.lado = lado;
        }

        public override string Name
        {
            get { return "Octógono"; }
        }

        public override double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 8 * lado;
        }
    }
}
