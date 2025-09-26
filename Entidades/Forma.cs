using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Entidades
{
    public abstract class Forma 
    {
        public abstract string Name { get; }

        public abstract double CalcularPerimetro();

        public abstract double CalcularArea();

        public virtual string Mostrar()
        {
            return $"A figura {Name} tem área: {CalcularArea()} e perímetro: {CalcularPerimetro()}";
        }
    }
}
