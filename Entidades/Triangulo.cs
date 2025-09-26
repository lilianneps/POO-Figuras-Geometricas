using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace FormasGeometricas.Entidades
{
    public class Triangulo : Forma
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            if (!PodeExistirTriangulo(ladoA, ladoB, ladoC))
                throw new ArgumentException("Os lados fornecidos não formam um triângulo válido.");

            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public override string Name
        {
            get { return "Triângulo"; }
        }

        public override double CalcularArea()
        {
            
            double semiPerimetro = CalcularPerimetro() / 2;
            return Math.Sqrt(semiPerimetro *
                             (semiPerimetro - ladoA) *
                             (semiPerimetro - ladoB) *
                             (semiPerimetro - ladoC));
        }

        public override double CalcularPerimetro()
        {
            return ladoA + ladoB + ladoC;
        }

        private bool PodeExistirTriangulo(double a, double b, double c)
        {        
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
