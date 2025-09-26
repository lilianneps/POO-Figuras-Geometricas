using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades.Forma
{
    internal class Quadrado: Forma
    {
        private double lado;
        public Quadrado(double lado)
        {
            this.lado = lado;
        }
        public override string Name
        {
            get {
                return "Quadrado";
            }
        } 

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

    }
}
