namespace UnidadVDataGridView
{
    partial class frmEntradaDiario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTotalDebito = new System.Windows.Forms.TextBox();
            this.txtTotalCredito = new System.Windows.Forms.TextBox();
            this.sltTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(41, 84);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(82, 27);
            this.txtCuenta.TabIndex = 0;
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Location = new System.Drawing.Point(129, 84);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.Size = new System.Drawing.Size(425, 27);
            this.txtNombreCuenta.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(692, 84);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(104, 27);
            this.txtMonto.TabIndex = 2;
            // 
            // txtTotalDebito
            // 
            this.txtTotalDebito.Location = new System.Drawing.Point(640, 400);
            this.txtTotalDebito.Name = "txtTotalDebito";
            this.txtTotalDebito.Size = new System.Drawing.Size(125, 27);
            this.txtTotalDebito.TabIndex = 3;
            this.txtTotalDebito.Text = "0";
            // 
            // txtTotalCredito
            // 
            this.txtTotalCredito.Location = new System.Drawing.Point(771, 400);
            this.txtTotalCredito.Name = "txtTotalCredito";
            this.txtTotalCredito.Size = new System.Drawing.Size(125, 27);
            this.txtTotalCredito.TabIndex = 4;
            this.txtTotalCredito.Text = "0";
            // 
            // sltTipo
            // 
            this.sltTipo.FormattingEnabled = true;
            this.sltTipo.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
            this.sltTipo.Location = new System.Drawing.Point(560, 84);
            this.sltTipo.Name = "sltTipo";
            this.sltTipo.Size = new System.Drawing.Size(126, 28);
            this.sltTipo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(802, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta,
            this.nombreCuenta,
            this.debito,
            this.credito});
            this.dgvEntradas.Location = new System.Drawing.Point(41, 117);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.RowTemplate.Height = 29;
            this.dgvEntradas.Size = new System.Drawing.Size(855, 244);
            this.dgvEntradas.TabIndex = 7;
            this.dgvEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "Cuenta";
            this.cuenta.MinimumWidth = 6;
            this.cuenta.Name = "cuenta";
            this.cuenta.Width = 125;
            // 
            // nombreCuenta
            // 
            this.nombreCuenta.HeaderText = "Nombre Cuenta";
            this.nombreCuenta.MinimumWidth = 6;
            this.nombreCuenta.Name = "nombreCuenta";
            this.nombreCuenta.Width = 425;
            // 
            // debito
            // 
            this.debito.HeaderText = "Debito";
            this.debito.MinimumWidth = 6;
            this.debito.Name = "debito";
            this.debito.Width = 125;
            // 
            // credito
            // 
            this.credito.HeaderText = "Credito";
            this.credito.MinimumWidth = 6;
            this.credito.Name = "credito";
            this.credito.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Debito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Credito";
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Location = new System.Drawing.Point(41, 398);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(134, 29);
            this.btnEliminarFila.TabIndex = 14;
            this.btnEliminarFila.Text = "Eliminar Fila";
            this.btnEliminarFila.UseVisualStyleBackColor = true;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
            // 
            // frmEntradaDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.sltTipo);
            this.Controls.Add(this.txtTotalCredito);
            this.Controls.Add(this.txtTotalDebito);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombreCuenta);
            this.Controls.Add(this.txtCuenta);
            this.Name = "frmEntradaDiario";
            this.Text = "Entrada de Diario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCuenta;
        private TextBox txtNombreCuenta;
        private TextBox txtMonto;
        private TextBox txtTotalDebito;
        private TextBox txtTotalCredito;
        private ComboBox sltTipo;
        private Button btnAgregar;
        private DataGridView dgvEntradas;
        private DataGridViewTextBoxColumn cuenta;
        private DataGridViewTextBoxColumn nombreCuenta;
        private DataGridViewTextBoxColumn debito;
        private DataGridViewTextBoxColumn credito;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEliminarFila;
    }
}