using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class Formulas
    {
        private List<Operaciones> operaciones;

        public Formulas(List<Operaciones> operaciones)
        {
            this.operaciones = operaciones;
        }

        public void Agregar(Operaciones op)
        {
            if (op == null)
            {
                throw new ArgumentNullException(nameof(op));
            }
            operaciones.Add(op);
        }

        public List<Operaciones> Mostrar()
        {
            return operaciones;
        }

        public decimal FhtToCls(decimal valor)
        {
            return (valor - 32) / 1.8M;
        }

        public decimal ClsToFht(decimal valor)
        {
            return (valor*1.8M)+32;
        }

        public decimal FhtToKvn(decimal valor)
        {
            return 5/9*(valor-32)+273.15M;
        }

        public decimal KvnToFht(decimal valor)
        {
            return 1.8M*(valor-273.15M)+32;
        }

        public decimal ClsToKvn(decimal valor)
        {
            return valor+273.15M;
        }

        public decimal KvnToCls(decimal valor)
        {
            return valor-273.15M;
        }
    }
}
