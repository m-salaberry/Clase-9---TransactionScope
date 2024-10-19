namespace UI
{
    partial class Form1
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
            btnListar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnConfirmar = new Button();
            btnCargar = new Button();
            txtSueldoBruto = new TextBox();
            label5 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            dgvEmpleados = new DataGridView();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(707, 500);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 41);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 72);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(txtSueldoBruto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 473);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carga de empleados";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(109, 381);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(216, 40);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar carga";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(109, 288);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(216, 40);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(109, 195);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.Size = new Size(266, 23);
            txtSueldoBruto.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 198);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 7;
            label5.Text = "Sueldo Bruto:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(109, 153);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(266, 23);
            txtDni.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 156);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(109, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(266, 23);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 114);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 23);
            txtNombre.TabIndex = 2;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(459, 90);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(541, 404);
            dgvEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(459, 35);
            label2.Name = "label2";
            label2.Size = new Size(306, 45);
            label2.TabIndex = 4;
            label2.Text = "Lista de empleados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 553);
            Controls.Add(label2);
            Controls.Add(dgvEmpleados);
            Controls.Add(groupBox1);
            Controls.Add(btnListar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private DataGridView dgvEmpleados;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtSueldoBruto;
        private Label label5;
        private TextBox txtDni;
        private Label label4;
        private Button btnConfirmar;
        private Button btnCargar;
    }
}
