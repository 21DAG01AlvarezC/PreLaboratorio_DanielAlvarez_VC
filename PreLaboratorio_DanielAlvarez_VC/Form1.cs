namespace PreLaboratorio_DanielAlvarez_VC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Si la contraseņa escrita es igual a "Hola123"
            if (textBox1.Text == "Hola123")
            {
                //Se nombra la ventana de la Tabla
                Tabla ventana = new Tabla();
                ventana.Show();//Se muestra la ventana de Tabla
                this.Hide();//Se esconde el login
            }
            else //Si no coincide la contraseņa
            {
                //Se muestra un mensaje de Contraseņa Incorrecta
                MessageBox.Show("Contraseņa Incorrecta");
            }
        }
    }
}
