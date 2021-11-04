using Domain.Enums;
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
    public partial class FrmConversiones : Form
    {
        public FrmConversiones()
        {
            InitializeComponent();
        }

        private void FrmConversiones_Load(object sender, EventArgs e)
        {
            cmbTipoGrado.Items.AddRange(Enum.GetValues(typeof(TipoGrado)).Cast<Object>().ToArray());
            cmbGradoConvert.Items.AddRange(Enum.GetValues(typeof(TipoGrado)).Cast<Object>().ToArray());
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (cmbTipoGrado.SelectedIndex == -1)
            {
                MessageBox.Show("Error, no ha seleccionado el tipo de grado", "Mensaje de Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (cmbGradoConvert.SelectedIndex == -1)
            {
                MessageBox.Show("Error, no ha seleccionado el tipo de grado", "Mensaje de Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.ShowDialog();
        }
    }
}

