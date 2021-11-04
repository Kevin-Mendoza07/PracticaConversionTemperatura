using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Operaciones
    {
        public decimal Convertir { get; set; }
        public TipoGrado GradoOriginal { get; set; }
        public decimal Valor { get; set; }
        public TipoGrado TipoGrado { get; set; }
    }
}
