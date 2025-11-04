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
        string mozosGanadores = "";

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

            //Para que al iniciar tenga foco en columna de comidas y no en mozos
            dgvDatos.CurrentCell = dgvDatos.Rows[0].Cells[1];            
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
                        MessageBox.Show($"Hay una celda vacía",
                            "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvDatos.Rows[fila].Cells[col].Style.BackColor = Color.Orange;
                        dgvDatos.Rows[fila].Cells[col].Value = 0;
                        btnTotal.Enabled = false;
                        btnMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }
                   
                    // Si no se puede convertir a número
                    double numero;
                    if (!double.TryParse(celda.ToString(), out numero))
                    {
                        dgvDatos.Rows[fila].Cells[col].Style.BackColor = Color.LightBlue;
                        dgvDatos.Rows[fila].Cells[col].Value = 0;                        
                        btnTotal.Enabled = false;
                        btnMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }
                    else if (numero < 0)
                    {
                        dgvDatos.Rows[fila].Cells[col].Style.BackColor = Color.Pink;                        
                        MessageBox.Show("Se encontraron valores negativos en la grilla.",
                        "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnMozo.Enabled = false;
                        btnTotal.Enabled = false;
                    }
                    else
                    {
                        dgvDatos.Rows[fila].Cells[col].Style.BackColor = Color.White;
                    }
                }               
            }
            //Se muestra el mensaje de datos validados correctamente
            
                MessageBox.Show("Los datos han sido validados correctamente.",
                "Datos Validados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMozo.Enabled = true;
                btnTotal.Enabled = true;
                return true;

            //Grabo datos en matriz
            for (int fila = 0; fila < 5; fila++)
            {
                // Recorremos las columnas de la grilla
                for (int colGrilla = 1; colGrilla < 5; colGrilla++)
                {
                    // Calculamos el índice correcto para la matriz (una columna menos)
                    int colMatriz = colGrilla - 1;

                    // Convertimos el valor de la celda a float
                    float valorCelda = Convert.ToSingle(dgvDatos.Rows[fila].Cells[colGrilla].Value);

                    // Guardamos en la matriz
                    vecDatos[fila, colMatriz] = valorCelda;
                }
            }
            return true;
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            
            int altoImporte = 0;            

            //Buscar el importe mayor de ventas
            for (int fila = 0; fila < 5; fila++)
            {
                int ventaMozoActual = 0;                
                for (int col = 1; col < 5; col++)
                {
                    
                    if (dgvDatos.Rows[fila].Cells[col].Value != null)
                    {
                        ventaMozoActual += Convert.ToInt32(dgvDatos.Rows[fila].Cells[col].Value);
                    }
                }

                // Si encontramos una venta mayor, actualizamos el máximo.
                if (ventaMozoActual > altoImporte)
                {
                    altoImporte = ventaMozoActual;
                }
            }          

            //Identificar y Concatenar los Nombres de los Mozos con el Importe Máximo
            for (int fila = 0; fila < 5; fila++)
            {
                int ventaMozoActual = 0;
                for (int col = 1; col < 5; col++)
                {
                    if (dgvDatos.Rows[fila].Cells[col].Value != null)
                    {
                        ventaMozoActual += Convert.ToInt32(dgvDatos.Rows[fila].Cells[col].Value);
                    }
                }

                // Si la venta actual es igual al importe más alto
                if (ventaMozoActual == altoImporte)
                {
                    string nombreMozo = Convert.ToString(dgvDatos.Rows[fila].Cells[0].Value);

                    if (!string.IsNullOrEmpty(mozosGanadores))
                    {
                        // Si ya hay nombres, separamos con " y ".
                        mozosGanadores += " y ";
                    }
                    // Agregamos el nombre del mozo actual.
                    mozosGanadores += nombreMozo;
                }
            } 
            
            lblImporteMozo.Text = Convert.ToString(altoImporte);
            lblNombreMozo.Text = mozosGanadores;
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
