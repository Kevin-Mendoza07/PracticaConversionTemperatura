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
            operaciones.Add(op);
        }

        public List<Operaciones> Mostrar()
        {
            return operaciones;
        }

        public decimal FhtToCls(decimal valor)
        {
            return valor;
        }

        public decimal ClsToFht(decimal valor)
        {
            return valor;
        }

        public decimal FhtToKvn(decimal valor)
        {
            return valor;
        }

        public decimal KvnToFht(decimal valor)
        {
            return valor;
        }

        public decimal ClsToKvn(decimal valor)
        {
            return valor;
        }

        public decimal KvnToCls(decimal valor)
        {
            return valor;
        }
    }
}
