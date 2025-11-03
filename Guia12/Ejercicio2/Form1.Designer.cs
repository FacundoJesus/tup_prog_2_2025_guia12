namespace Ejercicio2
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
            groupBox1 = new GroupBox();
            tbCapacidad = new TextBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            btnCerrarCamion = new Button();
            btnDescargar = new Button();
            btnCargar = new Button();
            btnCrearCamion = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            btnDescargarCamionRecibido = new Button();
            btnRecibirCamion = new Button();
            label4 = new Label();
            listBox2 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCapacidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(btnCerrarCamion);
            groupBox1.Controls.Add(btnDescargar);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(btnCrearCamion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargas";
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(354, 72);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(63, 23);
            tbCapacidad.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 50);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Capacidad";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(289, 21);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(128, 23);
            dtpFecha.TabIndex = 6;
            // 
            // btnCerrarCamion
            // 
            btnCerrarCamion.Location = new Point(248, 350);
            btnCerrarCamion.Name = "btnCerrarCamion";
            btnCerrarCamion.Size = new Size(75, 64);
            btnCerrarCamion.TabIndex = 5;
            btnCerrarCamion.Text = "Cerrar Camión";
            btnCerrarCamion.UseVisualStyleBackColor = true;
            btnCerrarCamion.Click += btnCerrarCamion_Click;
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(248, 245);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 64);
            btnDescargar.TabIndex = 4;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(248, 144);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 64);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCrearCamion
            // 
            btnCrearCamion.Location = new Point(248, 50);
            btnCrearCamion.Name = "btnCrearCamion";
            btnCrearCamion.Size = new Size(75, 64);
            btnCrearCamion.TabIndex = 2;
            btnCrearCamion.Text = "Crear Camion";
            btnCrearCamion.UseVisualStyleBackColor = true;
            btnCrearCamion.Click += btnCrearCamion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Autos";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 364);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDescargarCamionRecibido);
            groupBox2.Controls.Add(btnRecibirCamion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Location = new Point(454, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 426);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descargas";
            // 
            // btnDescargarCamionRecibido
            // 
            btnDescargarCamionRecibido.Location = new Point(248, 135);
            btnDescargarCamionRecibido.Name = "btnDescargarCamionRecibido";
            btnDescargarCamionRecibido.Size = new Size(75, 64);
            btnDescargarCamionRecibido.TabIndex = 4;
            btnDescargarCamionRecibido.Text = "Descargar Camion Recibido";
            btnDescargarCamionRecibido.UseVisualStyleBackColor = true;
            btnDescargarCamionRecibido.Click += btnDescargarCamionRecibido_Click;
            // 
            // btnRecibirCamion
            // 
            btnRecibirCamion.Location = new Point(248, 50);
            btnRecibirCamion.Name = "btnRecibirCamion";
            btnRecibirCamion.Size = new Size(75, 64);
            btnRecibirCamion.TabIndex = 2;
            btnRecibirCamion.Text = "Recibir Camion";
            btnRecibirCamion.UseVisualStyleBackColor = true;
            btnRecibirCamion.Click += btnRecibirCamion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 1;
            label4.Text = "Lista de Recibidos";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 50);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(219, 364);
            listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpFecha;
        private Button btnCerrarCamion;
        private Button btnDescargar;
        private Button btnCargar;
        private Button btnCrearCamion;
        private Label label1;
        private ListBox listBox1;
        private TextBox tbCapacidad;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnDescargarCamionRecibido;
        private Button btnRecibirCamion;
        private Label label4;
        private ListBox listBox2;
    }
}
