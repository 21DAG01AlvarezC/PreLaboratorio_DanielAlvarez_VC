namespace PreLaboratorio_DanielAlvarez_VC
{
    partial class Tabla
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
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Grado = new DataGridViewTextBoxColumn();
            Seccion = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Condicionado = new DataGridViewCheckBoxColumn();
            NumeroMatricula = new DataGridViewTextBoxColumn();
            Ciclo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Grado, Seccion, Clave, Edad, Numero, Correo, Condicionado, NumeroMatricula, Ciclo });
            dataGridView1.Location = new Point(444, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(688, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Grado
            // 
            Grado.HeaderText = "Grado";
            Grado.MinimumWidth = 8;
            Grado.Name = "Grado";
            Grado.Width = 150;
            // 
            // Seccion
            // 
            Seccion.HeaderText = "Seccion";
            Seccion.MinimumWidth = 8;
            Seccion.Name = "Seccion";
            Seccion.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 8;
            Clave.Name = "Clave";
            Clave.Width = 150;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            Edad.Width = 150;
            // 
            // Numero
            // 
            Numero.HeaderText = "Número de Teléfono";
            Numero.MinimumWidth = 8;
            Numero.Name = "Numero";
            Numero.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.Width = 150;
            // 
            // Condicionado
            // 
            Condicionado.HeaderText = "Condicionado";
            Condicionado.MinimumWidth = 8;
            Condicionado.Name = "Condicionado";
            Condicionado.Width = 150;
            // 
            // NumeroMatricula
            // 
            NumeroMatricula.HeaderText = "Número de Matrícula";
            NumeroMatricula.MinimumWidth = 8;
            NumeroMatricula.Name = "NumeroMatricula";
            NumeroMatricula.Width = 150;
            // 
            // Ciclo
            // 
            Ciclo.HeaderText = "Ciclo Académico";
            Ciclo.MinimumWidth = 8;
            Ciclo.Name = "Ciclo";
            Ciclo.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 3;
            label3.Text = "Grado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 4;
            label4.Text = "Sección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 5;
            label5.Text = "Clave:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 6;
            label6.Text = "Edad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 265);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 7;
            label7.Text = "Número de Teléfono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 304);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 8;
            label8.Text = "Correo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 395);
            label9.Name = "label9";
            label9.Size = new Size(183, 25);
            label9.TabIndex = 9;
            label9.Text = "Número de Matrícula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 438);
            label10.Name = "label10";
            label10.Size = new Size(147, 25);
            label10.TabIndex = 10;
            label10.Text = "Ciclo Académico:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 352);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 29);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Condicionado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 31);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 31);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 178);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 31);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(74, 220);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 31);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(196, 262);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(202, 31);
            textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(88, 301);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(202, 31);
            textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(201, 392);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(202, 31);
            textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(165, 435);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(202, 31);
            textBox10.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(47, 488);
            button1.Name = "button1";
            button1.Size = new Size(249, 62);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button2.Location = new Point(555, 438);
            button2.Name = "button2";
            button2.Size = new Size(167, 47);
            button2.TabIndex = 23;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button3.Location = new Point(752, 438);
            button3.Name = "button3";
            button3.Size = new Size(167, 47);
            button3.TabIndex = 24;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button4.Location = new Point(949, 438);
            button4.Name = "button4";
            button4.Size = new Size(167, 47);
            button4.TabIndex = 25;
            button4.Text = "Créditos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Tabla
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 605);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Tabla";
            Text = "Tabla";
            Load += Tabla_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Grado;
        private DataGridViewTextBoxColumn Seccion;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewCheckBoxColumn Condicionado;
        private DataGridViewTextBoxColumn NumeroMatricula;
        private DataGridViewTextBoxColumn Ciclo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}