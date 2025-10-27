namespace pryRossiEjercicio4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        string comida = "";
        string bebida = "";
        string bebidaAlc = "";
        string postres = "";
        int fila = 0;
        int col = 0;
        int total = 0;



        private void frmInicio_Load(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add("Julio", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Esteban", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Javier", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Gonzalo", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Alberto", 0, 0, 0, 0);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            fila = 0;
            while (fila < 4)
            {
                col = 1;
                while (col < 5)
                {
                    if (Convert.ToDecimal(dgvDatos.Rows[fila].Cells[col].Value) < 0)
                    {
                        MessageBox.Show("Los valores ingresados son incorrectos");
                        dgvDatos.Rows[fila].Cells[col].Value = 0;
                    }
                    col++;
                }
                fila++;

                //Mensaje de datos validados correctamente
                if (fila == 5 && col == 4)
                {
                    MessageBox.Show("Los datos ingresados son correctos");
                    btnMozo.Enabled = true;
                    btnTotal.Enabled = true;

                }
            }



        }
               

        private void btnMozo_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
