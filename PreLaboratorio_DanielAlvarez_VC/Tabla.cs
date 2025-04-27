using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLaboratorio_DanielAlvarez_VC
{
    public partial class Tabla : Form
    {
        //Se crea una variable de índice
        int index;
        public Tabla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            //Crea un método llamado limpiar
            textBox1.Text = "";//El texto en cada TextBox se vuelve vacío
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            checkBox1.Checked = false;//El checkBox ya no está en estado checked
            textBox9.Text = "";
            textBox10.Text = "";

            textBox1.Focus();//Vuelve a enfocarse en el textBox1 para escribir
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Crea un objecto de tipo vector en el que se almacenan los datos que se van a ingresar
            Object[] datos = {textBox1.Text,//Se almacena el texto de cada textBox en cada posición
            textBox2.Text,
            textBox3.Text,
            textBox4.Text,
            textBox5.Text,
            textBox6.Text,
            textBox7.Text,
            textBox8.Text,
            checkBox1.Checked, //El estado del CheckBox se almacena
            textBox9.Text,
            textBox10.Text};

            dataGridView1.Rows.Add(datos);//Se ingresan los datos al dataGridView

            Limpiar();//Se ejecuta el método limpiar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se revisa si está seleccionada una fila
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;//En la fila seleccionada,
                dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;//Se cambia el valor que ya existe
                dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;//Por el que tiene textBox correspondiente
                dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
                dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
                dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
                dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
                dataGridView1.CurrentRow.Cells[8].Value = checkBox1.Checked;//También el estado del CheckBox
                dataGridView1.CurrentRow.Cells[9].Value = textBox9.Text;
                dataGridView1.CurrentRow.Cells[10].Value = textBox10.Text;
            }
            Limpiar();//Se ejecuta el método limpiar
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            //Al iniciar el formulario se ejecuta el método limpiar
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //En el caso de que hagamos click en el dataGridView, se revisa si el índice es mayor o igual a
            //0 para determinar si está seleccionada una fila
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                index = dataGridView1.CurrentCell.RowIndex;//Se almacena el índice seleccionado en la variable index

                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//El texto de cada textBox
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//ahora es el que estaba en 
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//el dataGridView, con el fin de
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();//modificarlo
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                ////Se almacena el valor del checkBox, boolean porque es true o false
                checkBox1.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value);

                textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Si está seleccionada una fila
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                //Se elimina la fila -------- con el índice seleccionado
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            //Se ejecuta el método limpiar
            Limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Se nombra la ventana créditos
            Creditos ventana = new Creditos();
            ventana.Show();//Se muestra la ventana créditos
            this.Hide();//Se esconde esta ventana
        }
    }
}
