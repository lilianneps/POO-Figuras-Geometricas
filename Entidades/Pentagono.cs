using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades
{
    public class Pentagono : Forma
    {
        private double lado;

        public Pentagono(double lado)
        {
            this.lado = lado;
        }

        public override string Name
        {
            get { return "Pentágono"; }
        }

        public override double CalcularArea()
        {
            return (5 * lado * lado) / (4 * Math.Tan(Math.PI / 5));
        }

        public override double CalcularPerimetro()
        {
            return 5 * lado;
        }
    }
}
