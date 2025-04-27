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
            //Si la contraseña escrita es igual a "Hola123"
            if (textBox1.Text == "Hola123")
            {
                //Se nombra la ventana de la Tabla
                Tabla ventana = new Tabla();
                ventana.Show();//Se muestra la ventana de Tabla
                this.Hide();//Se esconde el login
            }
            else //Si no coincide la contraseña
            {
                //Se muestra un mensaje de Contraseña Incorrecta
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
    }
}
