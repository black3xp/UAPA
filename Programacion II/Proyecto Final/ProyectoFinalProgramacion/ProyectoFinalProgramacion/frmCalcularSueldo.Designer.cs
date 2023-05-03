namespace ProyectoFinalProgramacion
{
    partial class frmCalcularSueldo
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
            this.txtAfp = new System.Windows.Forms.TextBox();
            this.txtArs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCooperativa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDescuentos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AFP";
            // 
            // txtAfp
            // 
            this.txtAfp.Location = new System.Drawing.Point(244, 44);
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.ReadOnly = true;
            this.txtAfp.Size = new System.Drawing.Size(125, 27);
            this.txtAfp.TabIndex = 1;
            this.txtAfp.TextChanged += new System.EventHandler(this.txtAfp_TextChanged);
            // 
            // txtArs
            // 
            this.txtArs.Location = new System.Drawing.Point(244, 105);
            this.txtArs.Name = "txtArs";
            this.txtArs.ReadOnly = true;
            this.txtArs.Size = new System.Drawing.Size(125, 27);
            this.txtArs.TabIndex = 3;
            this.txtArs.TextChanged += new System.EventHandler(this.txtArs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ARS";
            // 
            // txtCooperativa
            // 
            this.txtCooperativa.Location = new System.Drawing.Point(244, 170);
            this.txtCooperativa.Name = "txtCooperativa";
            this.txtCooperativa.ReadOnly = true;
            this.txtCooperativa.Size = new System.Drawing.Size(125, 27);
            this.txtCooperativa.TabIndex = 5;
            this.txtCooperativa.TextChanged += new System.EventHandler(this.txtCooperativa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cooperativa";
            // 
            // txtIsr
            // 
            this.txtIsr.Location = new System.Drawing.Point(244, 240);
            this.txtIsr.Name = "txtIsr";
            this.txtIsr.ReadOnly = true;
            this.txtIsr.Size = new System.Drawing.Size(125, 27);
            this.txtIsr.TabIndex = 7;
            this.txtIsr.TextChanged += new System.EventHandler(this.txtIsr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ISR";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(22, 44);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(178, 27);
            this.txtSueldoBruto.TabIndex = 9;
            this.txtSueldoBruto.TextChanged += new System.EventHandler(this.txtSueldoBruto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingresar sueldo bruto";
            // 
            // txtTotalDescuentos
            // 
            this.txtTotalDescuentos.Location = new System.Drawing.Point(22, 105);
            this.txtTotalDescuentos.Name = "txtTotalDescuentos";
            this.txtTotalDescuentos.ReadOnly = true;
            this.txtTotalDescuentos.Size = new System.Drawing.Size(178, 27);
            this.txtTotalDescuentos.TabIndex = 11;
            this.txtTotalDescuentos.TextChanged += new System.EventHandler(this.txtTotalDescuentos_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total descuentos";
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Location = new System.Drawing.Point(22, 240);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(178, 27);
            this.txtSueldoNeto.TabIndex = 13;
            this.txtSueldoNeto.TextChanged += new System.EventHandler(this.txtSueldoNeto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sueldo neto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(275, 290);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(175, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCalcularSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 342);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSueldoNeto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalDescuentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIsr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCooperativa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAfp);
            this.Controls.Add(this.label1);
            this.Name = "frmCalcularSueldo";
            this.Text = "Calcular Sueldo";
            this.Load += new System.EventHandler(this.frmCalcularSueldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAfp;
        private TextBox txtArs;
        private Label label2;
        private TextBox txtCooperativa;
        private Label label3;
        private TextBox txtIsr;
        private Label label4;
        private TextBox txtSueldoBruto;
        private Label label5;
        private TextBox txtTotalDescuentos;
        private Label label6;
        private TextBox txtSueldoNeto;
        private Label label7;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}