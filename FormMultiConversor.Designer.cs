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
            this.gbDolarReal = new System.Windows.Forms.GroupBox();
            this.gbReal = new System.Windows.Forms.GroupBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.gbDolar = new System.Windows.Forms.GroupBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.gbQuilometrosMilhas = new System.Windows.Forms.GroupBox();
            this.gbQuilometros = new System.Windows.Forms.GroupBox();
            this.txtQuilometro = new System.Windows.Forms.TextBox();
            this.gbMilhas = new System.Windows.Forms.GroupBox();
            this.txtMilha = new System.Windows.Forms.TextBox();
            this.gbHorasMinutos = new System.Windows.Forms.GroupBox();
            this.gbMinutos = new System.Windows.Forms.GroupBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.gbHoras = new System.Windows.Forms.GroupBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtCotacaoDolar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCotacaoEuro = new System.Windows.Forms.ToolStripTextBox();
            this.gbEuroReal = new System.Windows.Forms.GroupBox();
            this.gbRealEuro = new System.Windows.Forms.GroupBox();
            this.txtRealEuro = new System.Windows.Forms.TextBox();
            this.gbEuro = new System.Windows.Forms.GroupBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.gbDiasHoras = new System.Windows.Forms.GroupBox();
            this.gbHorasDias = new System.Windows.Forms.GroupBox();
            this.txtHorasDias = new System.Windows.Forms.TextBox();
            this.gbDias = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.gbFahrenheit.SuspendLayout();
            this.gbCelsius.SuspendLayout();
            this.gbTemperatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbDolarReal.SuspendLayout();
            this.gbReal.SuspendLayout();
            this.gbDolar.SuspendLayout();
            this.gbQuilometrosMilhas.SuspendLayout();
            this.gbQuilometros.SuspendLayout();
            this.gbMilhas.SuspendLayout();
            this.gbHorasMinutos.SuspendLayout();
            this.gbMinutos.SuspendLayout();
            this.gbHoras.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbEuroReal.SuspendLayout();
            this.gbRealEuro.SuspendLayout();
            this.gbEuro.SuspendLayout();
            this.gbDiasHoras.SuspendLayout();
            this.gbHorasDias.SuspendLayout();
            this.gbDias.SuspendLayout();
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
            this.gbTemperatura.Location = new System.Drawing.Point(12, 46);
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
            // gbDolarReal
            // 
            this.gbDolarReal.Controls.Add(this.gbReal);
            this.gbDolarReal.Controls.Add(this.gbDolar);
            this.gbDolarReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDolarReal.Location = new System.Drawing.Point(191, 46);
            this.gbDolarReal.Name = "gbDolarReal";
            this.gbDolarReal.Size = new System.Drawing.Size(176, 161);
            this.gbDolarReal.TabIndex = 3;
            this.gbDolarReal.TabStop = false;
            this.gbDolarReal.Text = "Dólar / Real";
            // 
            // gbReal
            // 
            this.gbReal.Controls.Add(this.txtReal);
            this.gbReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReal.Location = new System.Drawing.Point(6, 91);
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
            this.gbDolar.Location = new System.Drawing.Point(6, 25);
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
            this.gbQuilometrosMilhas.Location = new System.Drawing.Point(593, 46);
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
            // gbHorasMinutos
            // 
            this.gbHorasMinutos.Controls.Add(this.gbMinutos);
            this.gbHorasMinutos.Controls.Add(this.gbHoras);
            this.gbHorasMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHorasMinutos.Location = new System.Drawing.Point(794, 46);
            this.gbHorasMinutos.Name = "gbHorasMinutos";
            this.gbHorasMinutos.Size = new System.Drawing.Size(176, 161);
            this.gbHorasMinutos.TabIndex = 5;
            this.gbHorasMinutos.TabStop = false;
            this.gbHorasMinutos.Text = "Horas / Minutos";
            // 
            // gbMinutos
            // 
            this.gbMinutos.Controls.Add(this.txtMinutos);
            this.gbMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMinutos.Location = new System.Drawing.Point(6, 92);
            this.gbMinutos.Name = "gbMinutos";
            this.gbMinutos.Size = new System.Drawing.Size(161, 61);
            this.gbMinutos.TabIndex = 1;
            this.gbMinutos.TabStop = false;
            this.gbMinutos.Text = "Minutos";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(7, 25);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(148, 26);
            this.txtMinutos.TabIndex = 3;
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutos_KeyPress);
            this.txtMinutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMinutos_KeyUp);
            // 
            // gbHoras
            // 
            this.gbHoras.Controls.Add(this.txtHoras);
            this.gbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoras.Location = new System.Drawing.Point(6, 25);
            this.gbHoras.Name = "gbHoras";
            this.gbHoras.Size = new System.Drawing.Size(161, 61);
            this.gbHoras.TabIndex = 0;
            this.gbHoras.TabStop = false;
            this.gbHoras.Text = "Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(6, 25);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(149, 26);
            this.txtHoras.TabIndex = 2;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            this.txtHoras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHoras_KeyUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtCotacaoDolar,
            this.toolStripSeparator1,
            this.txtCotacaoEuro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.BackColor = System.Drawing.Color.LightGray;
            this.txtCotacaoDolar.Enabled = false;
            this.txtCotacaoDolar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCotacaoEuro
            // 
            this.txtCotacaoEuro.BackColor = System.Drawing.Color.LightGray;
            this.txtCotacaoEuro.Enabled = false;
            this.txtCotacaoEuro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotacaoEuro.Name = "txtCotacaoEuro";
            this.txtCotacaoEuro.Size = new System.Drawing.Size(100, 25);
            // 
            // gbEuroReal
            // 
            this.gbEuroReal.Controls.Add(this.gbRealEuro);
            this.gbEuroReal.Controls.Add(this.gbEuro);
            this.gbEuroReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEuroReal.Location = new System.Drawing.Point(392, 46);
            this.gbEuroReal.Name = "gbEuroReal";
            this.gbEuroReal.Size = new System.Drawing.Size(176, 161);
            this.gbEuroReal.TabIndex = 7;
            this.gbEuroReal.TabStop = false;
            this.gbEuroReal.Text = "Euro / Real";
            // 
            // gbRealEuro
            // 
            this.gbRealEuro.Controls.Add(this.txtRealEuro);
            this.gbRealEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRealEuro.Location = new System.Drawing.Point(6, 91);
            this.gbRealEuro.Name = "gbRealEuro";
            this.gbRealEuro.Size = new System.Drawing.Size(162, 61);
            this.gbRealEuro.TabIndex = 1;
            this.gbRealEuro.TabStop = false;
            this.gbRealEuro.Text = "Real - R$";
            // 
            // txtRealEuro
            // 
            this.txtRealEuro.Location = new System.Drawing.Point(7, 25);
            this.txtRealEuro.Name = "txtRealEuro";
            this.txtRealEuro.Size = new System.Drawing.Size(149, 26);
            this.txtRealEuro.TabIndex = 3;
            this.txtRealEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRealEuro_KeyPress);
            this.txtRealEuro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRealEuro_KeyUp);
            // 
            // gbEuro
            // 
            this.gbEuro.Controls.Add(this.txtEuro);
            this.gbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEuro.Location = new System.Drawing.Point(6, 25);
            this.gbEuro.Name = "gbEuro";
            this.gbEuro.Size = new System.Drawing.Size(162, 61);
            this.gbEuro.TabIndex = 0;
            this.gbEuro.TabStop = false;
            this.gbEuro.Text = "Euro - €";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(6, 25);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(150, 26);
            this.txtEuro.TabIndex = 2;
            this.txtEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEuro_KeyPress);
            this.txtEuro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEuro_KeyUp);
            // 
            // gbDiasHoras
            // 
            this.gbDiasHoras.Controls.Add(this.gbHorasDias);
            this.gbDiasHoras.Controls.Add(this.gbDias);
            this.gbDiasHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiasHoras.Location = new System.Drawing.Point(12, 227);
            this.gbDiasHoras.Name = "gbDiasHoras";
            this.gbDiasHoras.Size = new System.Drawing.Size(154, 161);
            this.gbDiasHoras.TabIndex = 8;
            this.gbDiasHoras.TabStop = false;
            this.gbDiasHoras.Text = "Dias / Horas";
            // 
            // gbHorasDias
            // 
            this.gbHorasDias.Controls.Add(this.txtHorasDias);
            this.gbHorasDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHorasDias.Location = new System.Drawing.Point(6, 92);
            this.gbHorasDias.Name = "gbHorasDias";
            this.gbHorasDias.Size = new System.Drawing.Size(137, 61);
            this.gbHorasDias.TabIndex = 1;
            this.gbHorasDias.TabStop = false;
            this.gbHorasDias.Text = "Horas";
            // 
            // txtHorasDias
            // 
            this.txtHorasDias.Location = new System.Drawing.Point(7, 25);
            this.txtHorasDias.Name = "txtHorasDias";
            this.txtHorasDias.Size = new System.Drawing.Size(124, 26);
            this.txtHorasDias.TabIndex = 3;
            this.txtHorasDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasDias_KeyPress);
            this.txtHorasDias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHorasDias_KeyUp);
            // 
            // gbDias
            // 
            this.gbDias.Controls.Add(this.txtDias);
            this.gbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDias.Location = new System.Drawing.Point(6, 25);
            this.gbDias.Name = "gbDias";
            this.gbDias.Size = new System.Drawing.Size(137, 61);
            this.gbDias.TabIndex = 0;
            this.gbDias.TabStop = false;
            this.gbDias.Text = "Dias";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(6, 25);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(125, 26);
            this.txtDias.TabIndex = 2;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            this.txtDias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDias_KeyUp);
            // 
            // FormMultiConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 639);
            this.Controls.Add(this.gbDiasHoras);
            this.Controls.Add(this.gbEuroReal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbHorasMinutos);
            this.Controls.Add(this.gbQuilometrosMilhas);
            this.Controls.Add(this.gbDolarReal);
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
            this.gbDolarReal.ResumeLayout(false);
            this.gbReal.ResumeLayout(false);
            this.gbReal.PerformLayout();
            this.gbDolar.ResumeLayout(false);
            this.gbDolar.PerformLayout();
            this.gbQuilometrosMilhas.ResumeLayout(false);
            this.gbQuilometros.ResumeLayout(false);
            this.gbQuilometros.PerformLayout();
            this.gbMilhas.ResumeLayout(false);
            this.gbMilhas.PerformLayout();
            this.gbHorasMinutos.ResumeLayout(false);
            this.gbMinutos.ResumeLayout(false);
            this.gbMinutos.PerformLayout();
            this.gbHoras.ResumeLayout(false);
            this.gbHoras.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbEuroReal.ResumeLayout(false);
            this.gbRealEuro.ResumeLayout(false);
            this.gbRealEuro.PerformLayout();
            this.gbEuro.ResumeLayout(false);
            this.gbEuro.PerformLayout();
            this.gbDiasHoras.ResumeLayout(false);
            this.gbHorasDias.ResumeLayout(false);
            this.gbHorasDias.PerformLayout();
            this.gbDias.ResumeLayout(false);
            this.gbDias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.GroupBox gbCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.GroupBox gbTemperatura;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbDolarReal;
        private System.Windows.Forms.GroupBox gbReal;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.GroupBox gbDolar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.GroupBox gbQuilometrosMilhas;
        private System.Windows.Forms.GroupBox gbQuilometros;
        private System.Windows.Forms.TextBox txtQuilometro;
        private System.Windows.Forms.GroupBox gbMilhas;
        private System.Windows.Forms.TextBox txtMilha;
        private System.Windows.Forms.GroupBox gbHorasMinutos;
        private System.Windows.Forms.GroupBox gbMinutos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.GroupBox gbHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtCotacaoDolar;
        private System.Windows.Forms.ToolStripTextBox txtCotacaoEuro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbEuroReal;
        private System.Windows.Forms.GroupBox gbRealEuro;
        private System.Windows.Forms.TextBox txtRealEuro;
        private System.Windows.Forms.GroupBox gbEuro;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.GroupBox gbDiasHoras;
        private System.Windows.Forms.GroupBox gbHorasDias;
        private System.Windows.Forms.TextBox txtHorasDias;
        private System.Windows.Forms.GroupBox gbDias;
        private System.Windows.Forms.TextBox txtDias;
    }
}