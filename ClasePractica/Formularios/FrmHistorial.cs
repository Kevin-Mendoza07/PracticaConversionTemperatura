using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePractica.Formularios
{
    public partial class FrmHistorial : Form
    {
        public Formulas formulas { get; set; }
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dtgHistorial.DataSource = null;
            dtgHistorial.DataSource = formulas.Mostrar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
