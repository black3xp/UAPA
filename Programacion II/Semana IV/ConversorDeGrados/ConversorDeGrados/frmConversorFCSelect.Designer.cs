namespace ConversorDeGrados
{
    partial class frmConversorFCSelect
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sltTipoConversion = new System.Windows.Forms.ComboBox();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // sltTipoConversion
            // 
            this.sltTipoConversion.FormattingEnabled = true;
            this.sltTipoConversion.Items.AddRange(new object[] {
            "Celsius a Fahrenheit",
            "Fahrenheit a Celsius"});
            this.sltTipoConversion.Location = new System.Drawing.Point(141, 24);
            this.sltTipoConversion.Name = "sltTipoConversion";
            this.sltTipoConversion.Size = new System.Drawing.Size(225, 28);
            this.sltTipoConversion.TabIndex = 3;
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(141, 58);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(125, 27);
            this.txtGrados.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(141, 91);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(125, 27);
            this.txtResultado.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(272, 58);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(94, 29);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // frmConversorFCSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 147);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.sltTipoConversion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConversorFCSelect";
            this.Text = "Convertir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox sltTipoConversion;
        private TextBox txtGrados;
        private TextBox txtResultado;
        private Button btnConvertir;
    }
}