namespace converterFahrenheitCelsius
{
    partial class converterTemperaturas
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
            this.labelTopText = new System.Windows.Forms.Label();
            this.labelDigiteTemperatura = new System.Windows.Forms.Label();
            this.labelFº = new System.Windows.Forms.Label();
            this.labelCº = new System.Windows.Forms.Label();
            this.txtEntradaValorr = new System.Windows.Forms.TextBox();
            this.txtSaidaCº = new System.Windows.Forms.TextBox();
            this.txtSaisaFº = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.comboBoxSelecionarFouC = new System.Windows.Forms.ComboBox();
            this.labelSelecioneConversão = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTopText
            // 
            this.labelTopText.AutoSize = true;
            this.labelTopText.Location = new System.Drawing.Point(178, 9);
            this.labelTopText.Name = "labelTopText";
            this.labelTopText.Size = new System.Drawing.Size(336, 32);
            this.labelTopText.TabIndex = 0;
            this.labelTopText.Text = "Conversor de Temperatura";
            // 
            // labelDigiteTemperatura
            // 
            this.labelDigiteTemperatura.AutoSize = true;
            this.labelDigiteTemperatura.Location = new System.Drawing.Point(266, 64);
            this.labelDigiteTemperatura.Name = "labelDigiteTemperatura";
            this.labelDigiteTemperatura.Size = new System.Drawing.Size(181, 32);
            this.labelDigiteTemperatura.TabIndex = 1;
            this.labelDigiteTemperatura.Text = "Digite o valor:";
            // 
            // labelFº
            // 
            this.labelFº.AutoSize = true;
            this.labelFº.Location = new System.Drawing.Point(217, 269);
            this.labelFº.Name = "labelFº";
            this.labelFº.Size = new System.Drawing.Size(41, 32);
            this.labelFº.TabIndex = 2;
            this.labelFº.Text = "Fº";
            // 
            // labelCº
            // 
            this.labelCº.AutoSize = true;
            this.labelCº.Location = new System.Drawing.Point(562, 269);
            this.labelCº.Name = "labelCº";
            this.labelCº.Size = new System.Drawing.Size(44, 32);
            this.labelCº.TabIndex = 3;
            this.labelCº.Text = "Cº";
            // 
            // txtEntradaValorr
            // 
            this.txtEntradaValorr.Location = new System.Drawing.Point(303, 99);
            this.txtEntradaValorr.Name = "txtEntradaValorr";
            this.txtEntradaValorr.Size = new System.Drawing.Size(100, 38);
            this.txtEntradaValorr.TabIndex = 4;
            this.txtEntradaValorr.TextChanged += new System.EventHandler(this.txtEntradaValorr_TextChanged);
            // 
            // txtSaidaCº
            // 
            this.txtSaidaCº.Location = new System.Drawing.Point(456, 266);
            this.txtSaidaCº.Name = "txtSaidaCº";
            this.txtSaidaCº.Size = new System.Drawing.Size(100, 38);
            this.txtSaidaCº.TabIndex = 5;
            // 
            // txtSaisaFº
            // 
            this.txtSaisaFº.Location = new System.Drawing.Point(111, 266);
            this.txtSaisaFº.Name = "txtSaisaFº";
            this.txtSaisaFº.Size = new System.Drawing.Size(100, 38);
            this.txtSaisaFº.TabIndex = 6;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(284, 248);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(148, 75);
            this.btnConverter.TabIndex = 7;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // comboBoxSelecionarFouC
            // 
            this.comboBoxSelecionarFouC.FormattingEnabled = true;
            this.comboBoxSelecionarFouC.Items.AddRange(new object[] {
            "F -> C",
            "C -> F"});
            this.comboBoxSelecionarFouC.Location = new System.Drawing.Point(303, 193);
            this.comboBoxSelecionarFouC.Name = "comboBoxSelecionarFouC";
            this.comboBoxSelecionarFouC.Size = new System.Drawing.Size(100, 40);
            this.comboBoxSelecionarFouC.TabIndex = 8;
            // 
            // labelSelecioneConversão
            // 
            this.labelSelecioneConversão.AutoSize = true;
            this.labelSelecioneConversão.Location = new System.Drawing.Point(214, 151);
            this.labelSelecioneConversão.Name = "labelSelecioneConversão";
            this.labelSelecioneConversão.Size = new System.Drawing.Size(297, 32);
            this.labelSelecioneConversão.TabIndex = 9;
            this.labelSelecioneConversão.Text = "Selecione a conversão:";
            this.labelSelecioneConversão.Click += new System.EventHandler(this.labelSelecioneConversão_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Location = new System.Drawing.Point(495, 99);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(190, 31);
            this.txtMensagem.TabIndex = 10;
            this.txtMensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // converterTemperaturas
            // 
            this.ClientSize = new System.Drawing.Size(709, 335);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.labelSelecioneConversão);
            this.Controls.Add(this.comboBoxSelecionarFouC);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtSaisaFº);
            this.Controls.Add(this.txtSaidaCº);
            this.Controls.Add(this.txtEntradaValorr);
            this.Controls.Add(this.labelCº);
            this.Controls.Add(this.labelFº);
            this.Controls.Add(this.labelDigiteTemperatura);
            this.Controls.Add(this.labelTopText);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "converterTemperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConversorTemperaturas;
        private System.Windows.Forms.ComboBox comboBoxFahrenheitCelsius;
        private System.Windows.Forms.Label labelSelecioneFC;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox txtEntradaValor;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button bntConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTopText;
        private System.Windows.Forms.Label labelDigiteTemperatura;
        private System.Windows.Forms.Label labelFº;
        private System.Windows.Forms.Label labelCº;
        private System.Windows.Forms.TextBox txtEntradaValorr;
        private System.Windows.Forms.TextBox txtSaidaCº;
        private System.Windows.Forms.TextBox txtSaisaFº;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.ComboBox comboBoxSelecionarFouC;
        private System.Windows.Forms.Label labelSelecioneConversão;
        private System.Windows.Forms.TextBox txtMensagem;
    }
}

