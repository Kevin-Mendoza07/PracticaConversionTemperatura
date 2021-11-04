using Domain;
using Domain.Enums;
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
    public partial class FrmConversiones : Form
    {
        public Formulas formulas;
        public Operaciones operaciones;
        public FrmConversiones()
        {
            formulas = new Formulas();
            InitializeComponent();
        }

        private void FrmConversiones_Load(object sender, EventArgs e)
        {
            cmbTipoGrado.Items.AddRange(Enum.GetValues(typeof(TipoGrado)).Cast<object>().ToArray());
            cmbGradoConvert.Items.AddRange(Enum.GetValues(typeof(TipoGrado)).Cast<object>().ToArray());
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

            decimal valor;
            switch (cmbTipoGrado.SelectedIndex)
            {
                case 0:
                    if(cmbGradoConvert.SelectedIndex == 0)
                    {
                        valor = nudValor.Value;
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Celsius,
                            Valor = valor,
                            TipoGrado = TipoGrado.Celsius
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    } 
                    if (cmbGradoConvert.SelectedIndex == 1) {
                        valor = formulas.ClsToFht(nudValor.Value);
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Celsius,
                            Valor = valor,
                            TipoGrado = TipoGrado.Fahrenheit
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    if (cmbGradoConvert.SelectedIndex == 2)
                    {
                        valor = formulas.ClsToKvn(nudValor.Value);
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Celsius,
                            Valor = valor,
                            TipoGrado = TipoGrado.Kelvin
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    break;
                case 1:
                    if(cmbGradoConvert.SelectedIndex == 0)
                    {
                        valor = formulas.FhtToCls(nudValor.Value);
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Fahrenheit,
                            Valor = valor,
                            TipoGrado = TipoGrado.Celsius
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    if(cmbGradoConvert.SelectedIndex == 1)
                    {
                        valor = nudValor.Value;
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Fahrenheit,
                            Valor = valor,
                            TipoGrado = TipoGrado.Fahrenheit
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    if(cmbGradoConvert.SelectedIndex == 2)
                    {
                        valor = formulas.FhtToKvn(nudValor.Value);
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Fahrenheit,
                            Valor = valor,
                            TipoGrado = TipoGrado.Kelvin
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    break;
                case 2:
                    if (cmbGradoConvert.SelectedIndex == 0)
                    {
                        valor = formulas.KvnToCls(nudValor.Value);
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Kelvin,
                            Valor = valor,
                            TipoGrado = TipoGrado.Celsius
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    if (cmbGradoConvert.SelectedIndex == 1)
                    {
                        valor = formulas.KvnToFht(nudValor.Value);
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Kelvin,
                            Valor = valor,
                            TipoGrado = TipoGrado.Fahrenheit
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    if (cmbGradoConvert.SelectedIndex == 2)
                    {
                        valor = nudValor.Value;
                        Operaciones operaciones = new Operaciones()
                        {
                            Convertir = nudValor.Value,
                            GradoOriginal = TipoGrado.Kelvin,
                            Valor = valor,
                            TipoGrado = TipoGrado.Kelvin
                        };
                        formulas.Agregar(operaciones);
                        txtResultado.Text = valor.ToString();
                    }
                    break;
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.formulas = formulas;
            frmHistorial.ShowDialog();
        }
    }
}

