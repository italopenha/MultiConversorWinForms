namespace MultiConversor
{
    partial class FormMultiConversor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultiConversor));
            this.gbFahrenheit = new System.Windows.Forms.GroupBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.gbCelsius = new System.Windows.Forms.GroupBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.gbTemperatura = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMoeda = new System.Windows.Forms.GroupBox();
            this.gbCotacaoDolar = new System.Windows.Forms.GroupBox();
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.gbReal = new System.Windows.Forms.GroupBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.gbDolar = new System.Windows.Forms.GroupBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.gbQuilometrosMilhas = new System.Windows.Forms.GroupBox();
            this.gbQuilometros = new System.Windows.Forms.GroupBox();
            this.txtQuilometro = new System.Windows.Forms.TextBox();
            this.gbMilhas = new System.Windows.Forms.GroupBox();
            this.txtMilha = new System.Windows.Forms.TextBox();
            this.gbFahrenheit.SuspendLayout();
            this.gbCelsius.SuspendLayout();
            this.gbTemperatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbMoeda.SuspendLayout();
            this.gbCotacaoDolar.SuspendLayout();
            this.gbReal.SuspendLayout();
            this.gbDolar.SuspendLayout();
            this.gbQuilometrosMilhas.SuspendLayout();
            this.gbQuilometros.SuspendLayout();
            this.gbMilhas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFahrenheit
            // 
            this.gbFahrenheit.Controls.Add(this.txtFahrenheit);
            this.gbFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFahrenheit.Location = new System.Drawing.Point(6, 25);
            this.gbFahrenheit.Name = "gbFahrenheit";
            this.gbFahrenheit.Size = new System.Drawing.Size(137, 61);
            this.gbFahrenheit.TabIndex = 0;
            this.gbFahrenheit.TabStop = false;
            this.gbFahrenheit.Text = "Fahrenheit - °F";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(6, 25);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(125, 26);
            this.txtFahrenheit.TabIndex = 2;
            this.txtFahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFahrenheit_KeyPress);
            this.txtFahrenheit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFahrenheit_KeyUp);
            // 
            // gbCelsius
            // 
            this.gbCelsius.Controls.Add(this.txtCelsius);
            this.gbCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCelsius.Location = new System.Drawing.Point(6, 92);
            this.gbCelsius.Name = "gbCelsius";
            this.gbCelsius.Size = new System.Drawing.Size(137, 61);
            this.gbCelsius.TabIndex = 1;
            this.gbCelsius.TabStop = false;
            this.gbCelsius.Text = "Celsius - °C";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(7, 25);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(124, 26);
            this.txtCelsius.TabIndex = 3;
            this.txtCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelsius_KeyPress);
            this.txtCelsius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCelsius_KeyUp);
            // 
            // gbTemperatura
            // 
            this.gbTemperatura.Controls.Add(this.gbCelsius);
            this.gbTemperatura.Controls.Add(this.gbFahrenheit);
            this.gbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTemperatura.Location = new System.Drawing.Point(12, 12);
            this.gbTemperatura.Name = "gbTemperatura";
            this.gbTemperatura.Size = new System.Drawing.Size(154, 161);
            this.gbTemperatura.TabIndex = 2;
            this.gbTemperatura.TabStop = false;
            this.gbTemperatura.Text = "Temperatura";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbMoeda
            // 
            this.gbMoeda.Controls.Add(this.gbCotacaoDolar);
            this.gbMoeda.Controls.Add(this.gbReal);
            this.gbMoeda.Controls.Add(this.gbDolar);
            this.gbMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMoeda.Location = new System.Drawing.Point(198, 12);
            this.gbMoeda.Name = "gbMoeda";
            this.gbMoeda.Size = new System.Drawing.Size(178, 228);
            this.gbMoeda.TabIndex = 3;
            this.gbMoeda.TabStop = false;
            this.gbMoeda.Text = "Moeda";
            // 
            // gbCotacaoDolar
            // 
            this.gbCotacaoDolar.Controls.Add(this.txtCotacaoDolar);
            this.gbCotacaoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCotacaoDolar.Location = new System.Drawing.Point(6, 25);
            this.gbCotacaoDolar.Name = "gbCotacaoDolar";
            this.gbCotacaoDolar.Size = new System.Drawing.Size(162, 61);
            this.gbCotacaoDolar.TabIndex = 4;
            this.gbCotacaoDolar.TabStop = false;
            this.gbCotacaoDolar.Text = "Cotação Dólar Hoje";
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Location = new System.Drawing.Point(6, 25);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(150, 26);
            this.txtCotacaoDolar.TabIndex = 2;
            // 
            // gbReal
            // 
            this.gbReal.Controls.Add(this.txtReal);
            this.gbReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReal.Location = new System.Drawing.Point(6, 159);
            this.gbReal.Name = "gbReal";
            this.gbReal.Size = new System.Drawing.Size(162, 61);
            this.gbReal.TabIndex = 1;
            this.gbReal.TabStop = false;
            this.gbReal.Text = "Real - R$";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(7, 25);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(149, 26);
            this.txtReal.TabIndex = 3;
            this.txtReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReal_KeyPress);
            this.txtReal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReal_KeyUp);
            // 
            // gbDolar
            // 
            this.gbDolar.Controls.Add(this.txtDolar);
            this.gbDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDolar.Location = new System.Drawing.Point(6, 92);
            this.gbDolar.Name = "gbDolar";
            this.gbDolar.Size = new System.Drawing.Size(162, 61);
            this.gbDolar.TabIndex = 0;
            this.gbDolar.TabStop = false;
            this.gbDolar.Text = "Dólar - US$";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(6, 25);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(150, 26);
            this.txtDolar.TabIndex = 2;
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            this.txtDolar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDolar_KeyUp);
            // 
            // gbQuilometrosMilhas
            // 
            this.gbQuilometrosMilhas.Controls.Add(this.gbQuilometros);
            this.gbQuilometrosMilhas.Controls.Add(this.gbMilhas);
            this.gbQuilometrosMilhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuilometrosMilhas.Location = new System.Drawing.Point(408, 12);
            this.gbQuilometrosMilhas.Name = "gbQuilometrosMilhas";
            this.gbQuilometrosMilhas.Size = new System.Drawing.Size(176, 161);
            this.gbQuilometrosMilhas.TabIndex = 4;
            this.gbQuilometrosMilhas.TabStop = false;
            this.gbQuilometrosMilhas.Text = "Milhas / Quilômetros";
            // 
            // gbQuilometros
            // 
            this.gbQuilometros.Controls.Add(this.txtQuilometro);
            this.gbQuilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuilometros.Location = new System.Drawing.Point(6, 92);
            this.gbQuilometros.Name = "gbQuilometros";
            this.gbQuilometros.Size = new System.Drawing.Size(161, 61);
            this.gbQuilometros.TabIndex = 1;
            this.gbQuilometros.TabStop = false;
            this.gbQuilometros.Text = "Quilômetros - Km/h";
            // 
            // txtQuilometro
            // 
            this.txtQuilometro.Location = new System.Drawing.Point(7, 25);
            this.txtQuilometro.Name = "txtQuilometro";
            this.txtQuilometro.Size = new System.Drawing.Size(148, 26);
            this.txtQuilometro.TabIndex = 3;
            this.txtQuilometro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuilometro_KeyPress);
            this.txtQuilometro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuilometro_KeyUp);
            // 
            // gbMilhas
            // 
            this.gbMilhas.Controls.Add(this.txtMilha);
            this.gbMilhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMilhas.Location = new System.Drawing.Point(6, 25);
            this.gbMilhas.Name = "gbMilhas";
            this.gbMilhas.Size = new System.Drawing.Size(161, 61);
            this.gbMilhas.TabIndex = 0;
            this.gbMilhas.TabStop = false;
            this.gbMilhas.Text = "Milhas - M/h";
            // 
            // txtMilha
            // 
            this.txtMilha.Location = new System.Drawing.Point(6, 25);
            this.txtMilha.Name = "txtMilha";
            this.txtMilha.Size = new System.Drawing.Size(149, 26);
            this.txtMilha.TabIndex = 2;
            this.txtMilha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilha_KeyPress);
            this.txtMilha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMilha_KeyUp);
            // 
            // FormMultiConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 639);
            this.Controls.Add(this.gbQuilometrosMilhas);
            this.Controls.Add(this.gbMoeda);
            this.Controls.Add(this.gbTemperatura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMultiConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiConversor";
            this.Load += new System.EventHandler(this.FormMultiConversor_Load);
            this.gbFahrenheit.ResumeLayout(false);
            this.gbFahrenheit.PerformLayout();
            this.gbCelsius.ResumeLayout(false);
            this.gbCelsius.PerformLayout();
            this.gbTemperatura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbMoeda.ResumeLayout(false);
            this.gbCotacaoDolar.ResumeLayout(false);
            this.gbCotacaoDolar.PerformLayout();
            this.gbReal.ResumeLayout(false);
            this.gbReal.PerformLayout();
            this.gbDolar.ResumeLayout(false);
            this.gbDolar.PerformLayout();
            this.gbQuilometrosMilhas.ResumeLayout(false);
            this.gbQuilometros.ResumeLayout(false);
            this.gbQuilometros.PerformLayout();
            this.gbMilhas.ResumeLayout(false);
            this.gbMilhas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.GroupBox gbCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.GroupBox gbTemperatura;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbMoeda;
        private System.Windows.Forms.GroupBox gbReal;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.GroupBox gbDolar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.GroupBox gbCotacaoDolar;
        private System.Windows.Forms.TextBox txtCotacaoDolar;
        private System.Windows.Forms.GroupBox gbQuilometrosMilhas;
        private System.Windows.Forms.GroupBox gbQuilometros;
        private System.Windows.Forms.TextBox txtQuilometro;
        private System.Windows.Forms.GroupBox gbMilhas;
        private System.Windows.Forms.TextBox txtMilha;
    }
}