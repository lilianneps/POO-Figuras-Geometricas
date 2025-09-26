using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades
{
    public class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public override string Name
        {
            get
            {
                return "Círculo";
            }
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
