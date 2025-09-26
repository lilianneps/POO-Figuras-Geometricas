using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades
{
    public class Retangulo : Forma
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override string Name
        {
            get { return "Retângulo"; }
        }

        public override double CalcularArea()
        {
            return largura * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }
    }
}
