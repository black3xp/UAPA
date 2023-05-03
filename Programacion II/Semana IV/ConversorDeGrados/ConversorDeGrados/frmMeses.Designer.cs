namespace ConversorDeGrados
{
    partial class frmMeses
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
            this.sltNumeroMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar mes de año";
            // 
            // sltNumeroMes
            // 
            this.sltNumeroMes.FormattingEnabled = true;
            this.sltNumeroMes.Location = new System.Drawing.Point(10, 24);
            this.sltNumeroMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sltNumeroMes.Name = "sltNumeroMes";
            this.sltNumeroMes.Size = new System.Drawing.Size(146, 23);
            this.sltNumeroMes.TabIndex = 1;
            this.sltNumeroMes.SelectedIndexChanged += new System.EventHandler(this.sltNumeroMes_SelectedIndexChanged);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(10, 47);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "mes";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 95);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.sltNumeroMes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMeses";
            this.Text = "Meses del año";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox sltNumeroMes;
        private Label lblMes;
    }
}