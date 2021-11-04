
namespace ClasePractica.Formularios
{
    partial class FrmConversiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoGrado = new System.Windows.Forms.ComboBox();
            this.cmbGradoConvert = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(125, 183);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(77, 32);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlInfo.Controls.Add(this.lblTitulo);
            this.pnlInfo.Location = new System.Drawing.Point(1, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlInfo.Size = new System.Drawing.Size(544, 60);
            this.pnlInfo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(152, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de Temperaturas";
            // 
            // cmbTipoGrado
            // 
            this.cmbTipoGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGrado.FormattingEnabled = true;
            this.cmbTipoGrado.Location = new System.Drawing.Point(81, 75);
            this.cmbTipoGrado.Name = "cmbTipoGrado";
            this.cmbTipoGrado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoGrado.TabIndex = 4;
            // 
            // cmbGradoConvert
            // 
            this.cmbGradoConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradoConvert.FormattingEnabled = true;
            this.cmbGradoConvert.Location = new System.Drawing.Point(323, 75);
            this.cmbGradoConvert.Name = "cmbGradoConvert";
            this.cmbGradoConvert.Size = new System.Drawing.Size(121, 21);
            this.cmbGradoConvert.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(81, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 7;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(323, 113);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(121, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(323, 183);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(77, 32);
            this.btnHistorial.TabIndex = 9;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // FrmConversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 227);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGradoConvert);
            this.Controls.Add(this.cmbTipoGrado);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Name = "FrmConversiones";
            this.Text = "FrmConversiones";
            this.Load += new System.EventHandler(this.FrmConversiones_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipoGrado;
        private System.Windows.Forms.ComboBox cmbGradoConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnHistorial;
    }
}