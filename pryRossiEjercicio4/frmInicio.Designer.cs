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
            btnValidar = new Button();
            dgvDatos = new DataGridView();
            colMozos = new DataGridViewTextBoxColumn();
            colComida = new DataGridViewTextBoxColumn();
            colBebida = new DataGridViewTextBoxColumn();
            colBebidaAlc = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnMozo = new Button();
            btnTotal = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblTotal = new Label();
            lblMozo = new Label();
            lblRMozo = new Label();
            lstTotales = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.SteelBlue;
            btnValidar.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnValidar.ForeColor = SystemColors.ControlLightLight;
            btnValidar.Location = new Point(139, 377);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(123, 31);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComida, colBebida, colBebidaAlc, colPostres });
            dgvDatos.Location = new Point(12, 73);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(541, 179);
            dgvDatos.TabIndex = 0;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.Name = "colMozos";
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebida
            // 
            colBebida.HeaderText = "Bebida sin alcohol";
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
            btnMozo.BackColor = Color.SteelBlue;
            btnMozo.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMozo.ForeColor = SystemColors.ControlLightLight;
            btnMozo.Location = new Point(315, 377);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(111, 31);
            btnMozo.TabIndex = 1;
            btnMozo.Text = "Mozo del Día";
            btnMozo.UseVisualStyleBackColor = false;
            btnMozo.Click += btnMozo_Click;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.SteelBlue;
            btnTotal.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnTotal.ForeColor = SystemColors.ControlLightLight;
            btnTotal.Location = new Point(470, 377);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(83, 31);
            btnTotal.TabIndex = 2;
            btnTotal.Text = "Totales";
            btnTotal.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SteelBlue;
            btnLimpiar.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(18, 377);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 31);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Cerrar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(292, 29);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Ingrese los importes de Venta";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 310);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(115, 19);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total General:";
            // 
            // lblMozo
            // 
            lblMozo.AutoSize = true;
            lblMozo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMozo.Location = new Point(12, 278);
            lblMozo.Name = "lblMozo";
            lblMozo.Size = new Size(113, 19);
            lblMozo.TabIndex = 9;
            lblMozo.Text = "Mozo del Día:";
            // 
            // lblRMozo
            // 
            lblRMozo.AutoSize = true;
            lblRMozo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRMozo.Location = new Point(146, 278);
            lblRMozo.Name = "lblRMozo";
            lblRMozo.Size = new Size(89, 19);
            lblRMozo.TabIndex = 10;
            lblRMozo.Text = ". . . . . . . . . . ";
            // 
            // lstTotales
            // 
            lstTotales.FormattingEnabled = true;
            lstTotales.ItemHeight = 15;
            lstTotales.Location = new Point(146, 310);
            lstTotales.Name = "lstTotales";
            lstTotales.Size = new Size(158, 49);
            lstTotales.TabIndex = 11;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 438);
            Controls.Add(lstTotales);
            Controls.Add(lblRMozo);
            Controls.Add(lblMozo);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDatos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnValidar);
            Controls.Add(btnTotal);
            Controls.Add(btnMozo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas La Milanga";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDatos;
        private Button btnMozo;
        private Button btnTotal;
        private Button btnValidar;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblTotal;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebida;
        private DataGridViewTextBoxColumn colBebidaAlc;
        private DataGridViewTextBoxColumn colPostres;
        private Label lblMozo;
        private Label lblRMozo;
        private ListBox lstTotales;
    }
}
