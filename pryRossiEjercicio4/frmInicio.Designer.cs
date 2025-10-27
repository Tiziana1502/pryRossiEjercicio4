namespace pryRossiEjercicio4
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            gbVentas = new GroupBox();
            btnValidar = new Button();
            dgvDatos = new DataGridView();
            colComida = new DataGridViewTextBoxColumn();
            colBebida = new DataGridViewTextBoxColumn();
            colBebidaAlc = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnMozo = new Button();
            btnTotal = new Button();
            gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(btnValidar);
            gbVentas.Controls.Add(dgvDatos);
            gbVentas.Location = new Point(24, 30);
            gbVentas.Name = "gbVentas";
            gbVentas.Size = new Size(464, 246);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            gbVentas.Text = "Registro Venta";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(377, 209);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(72, 31);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colComida, colBebida, colBebidaAlc, colPostres });
            dgvDatos.Location = new Point(13, 24);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(436, 179);
            dgvDatos.TabIndex = 0;
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebida
            // 
            colBebida.HeaderText = "Bebida s/ alcohol";
            colBebida.Name = "colBebida";
            // 
            // colBebidaAlc
            // 
            colBebidaAlc.HeaderText = "Bebidas";
            colBebidaAlc.Name = "colBebidaAlc";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // btnMozo
            // 
            btnMozo.Location = new Point(37, 294);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(85, 31);
            btnMozo.TabIndex = 1;
            btnMozo.Text = "Mozo del Día";
            btnMozo.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(128, 294);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(72, 31);
            btnTotal.TabIndex = 2;
            btnTotal.Text = "Totales";
            btnTotal.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 424);
            Controls.Add(btnTotal);
            Controls.Add(btnMozo);
            Controls.Add(gbVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas La Milanga";
            Load += frmInicio_Load;
            gbVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbVentas;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebida;
        private DataGridViewTextBoxColumn colBebidaAlc;
        private DataGridViewTextBoxColumn colPostres;
        private Button btnMozo;
        private Button btnTotal;
        private Button btnValidar;
    }
}
