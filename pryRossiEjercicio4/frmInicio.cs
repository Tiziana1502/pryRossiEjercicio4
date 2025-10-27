namespace pryRossiEjercicio4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        //Declaración de Matriz
        float[,] vecDatos = new float[5, 4];

        int fila = 0;
        int col = 0;
        int importeMozo = 0;
        string mozoVenta = "";
        int contador = 0;
        int totalCom = 0;
        int totalBebAlcohol = 0;
        int totalBebida = 0;
        int totalPostre = 0;
        int totalFinal = 0;
        int totalAux = 0;


        private void frmInicio_Load(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add(5);
            dgvDatos.Rows[0].Cells[0].Value = "Julio";
            dgvDatos.Rows[1].Cells[0].Value = "Esteban";
            dgvDatos.Rows[2].Cells[0].Value = "Javier";
            dgvDatos.Rows[3].Cells[0].Value = "Gonzalo";
            dgvDatos.Rows[4].Cells[0].Value = "Alberto";

            // configurar la primera columna para que sea de sólo lectura
            dgvDatos.Columns[0].ReadOnly = true;

            //Inicializamos la grilla con valor 0 en todas las posiciones
            for (fila = 0; fila < 5; fila++)
            {
                for (col = 1; col < 5; col++)
                {
                    dgvDatos.Rows[fila].Cells[col].Value = 0;
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ValidarDatos();

        }

        private bool ValidarDatos()
        {
            for (fila = 0; fila < 5; fila++)
            {
                for (col = 1; col < 5; col++)
                {
                    object celda = dgvDatos.Rows[fila].Cells[col].Value;

                    // Si la celda está vacía o nula
                    if (celda == null || celda.ToString() == "")
                    {
                        MessageBox.Show($"Hay una celda vacía en la fila {fila + 1}, columna {col + 1}.",
                            "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        btnTotal.Enabled = false;
                        btnMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }

                    // Si no se puede convertir a número
                    double numero;
                    if (!double.TryParse(celda.ToString(), out numero))
                    {
                        MessageBox.Show($"El valor en la fila {fila + 1}, columna {col + 1} no es numérico.",
                            "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        btnTotal.Enabled = false;
                        btnMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }
                }
            }

            //Si pasó todas las validaciones
            btnMozo.Enabled = true;
            btnTotal.Enabled = true;
            return true;
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            for (fila = 0; fila < 5; fila++)
            {
                contador = 0;
                for (col = 1; col < 5; col++)
                {
                    contador += Convert.ToInt32(dgvDatos.Rows[fila].Cells[col].Value);
                }

                if (contador > importeMozo)
                {
                    importeMozo = contador;
                    mozoVenta = Convert.ToString(dgvDatos.Rows[fila].Cells[0].Value);
                }
            }
            lblImporteMozo.Text = Convert.ToString(importeMozo);
            lblNombreMozo.Text = mozoVenta;
            importeMozo = 0;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            for (col = 1; col < 5; col++)
            {
                totalAux = 0;
                for (fila = 0; fila < 5; fila++)
                {
                    totalAux += Convert.ToInt32(dgvDatos.Rows[fila].Cells[col].Value);
                }
                switch (col)
                {
                    case 1:
                        totalCom = totalAux;
                        break;
                    case 2:
                        totalBebAlcohol = totalAux;
                        break;
                    case 3:
                        totalBebAlcohol = totalAux;
                        break;
                    case 4:
                        totalPostre = totalAux;
                        break;
                }
            }
            totalFinal = totalCom + totalBebAlcohol + totalPostre + totalBebAlcohol;

            //Limpiamos primero el contenido de la lbl
            lstResultado.Items.Clear();

            //Muestro el resultado
            lstResultado.Items.Add("Ventas por categoría:");
            lstResultado.Items.Add("-------------------------");
            lstResultado.Items.Add("Comida: " + totalCom);
            lstResultado.Items.Add("Bebidas con alcohol: " + totalBebAlcohol);
            lstResultado.Items.Add("Bebidas sin alcohol: " + totalBebAlcohol);
            lstResultado.Items.Add("Postres: " + totalPostre);
            lstResultado.Items.Add("-------------------------");
            lstResultado.Items.Add("TOTAL GENERAL: " + totalFinal);
        }
    }
}
