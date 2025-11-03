namespace Ejercicio1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            tbPatente = new TextBox();
            cmbTipoVehiculo = new ComboBox();
            rbNuevoCliente = new RadioButton();
            rbDenuncia = new RadioButton();
            btnTicket = new Button();
            label2 = new Label();
            lsbTurnos = new ListBox();
            btnAtenderDenuncias = new Button();
            btnAtenderNuevoCliente = new Button();
            btnExportarTickets = new Button();
            btnImportarVehiculos = new Button();
            tbDNI = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPatente);
            groupBox1.Controls.Add(cmbTipoVehiculo);
            groupBox1.Controls.Add(rbNuevoCliente);
            groupBox1.Controls.Add(rbDenuncia);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 145);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(132, 40);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(91, 23);
            tbPatente.TabIndex = 10;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Items.AddRange(new object[] { "Auto", "Moto", "Equipo de Trabajo", "Bicicleta" });
            cmbTipoVehiculo.Location = new Point(132, 85);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(91, 23);
            cmbTipoVehiculo.TabIndex = 2;
            cmbTipoVehiculo.Text = "Tipo";
            // 
            // rbNuevoCliente
            // 
            rbNuevoCliente.AutoSize = true;
            rbNuevoCliente.Location = new Point(19, 89);
            rbNuevoCliente.Name = "rbNuevoCliente";
            rbNuevoCliente.Size = new Size(100, 19);
            rbNuevoCliente.TabIndex = 1;
            rbNuevoCliente.TabStop = true;
            rbNuevoCliente.Text = "Nuevo Cliente";
            rbNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // rbDenuncia
            // 
            rbDenuncia.AutoSize = true;
            rbDenuncia.Location = new Point(19, 44);
            rbDenuncia.Name = "rbDenuncia";
            rbDenuncia.Size = new Size(75, 19);
            rbDenuncia.TabIndex = 0;
            rbDenuncia.TabStop = true;
            rbDenuncia.Text = "Denuncia";
            rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(266, 70);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(94, 92);
            btnTicket.TabIndex = 2;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Turnos";
            // 
            // lsbTurnos
            // 
            lsbTurnos.FormattingEnabled = true;
            lsbTurnos.ItemHeight = 15;
            lsbTurnos.Location = new Point(12, 230);
            lsbTurnos.Name = "lsbTurnos";
            lsbTurnos.Size = new Size(248, 139);
            lsbTurnos.TabIndex = 4;
            // 
            // btnAtenderDenuncias
            // 
            btnAtenderDenuncias.Location = new Point(12, 375);
            btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            btnAtenderDenuncias.Size = new Size(94, 46);
            btnAtenderDenuncias.TabIndex = 5;
            btnAtenderDenuncias.Text = "Atender Denuncias";
            btnAtenderDenuncias.UseVisualStyleBackColor = true;
            btnAtenderDenuncias.Click += btnAtenderDenuncias_Click;
            // 
            // btnAtenderNuevoCliente
            // 
            btnAtenderNuevoCliente.Location = new Point(167, 375);
            btnAtenderNuevoCliente.Name = "btnAtenderNuevoCliente";
            btnAtenderNuevoCliente.Size = new Size(93, 46);
            btnAtenderNuevoCliente.TabIndex = 6;
            btnAtenderNuevoCliente.Text = "Atender Nuevo Cliente";
            btnAtenderNuevoCliente.UseVisualStyleBackColor = true;
            btnAtenderNuevoCliente.Click += btnAtenderNuevoCliente_Click;
            // 
            // btnExportarTickets
            // 
            btnExportarTickets.Location = new Point(266, 230);
            btnExportarTickets.Name = "btnExportarTickets";
            btnExportarTickets.Size = new Size(94, 46);
            btnExportarTickets.TabIndex = 7;
            btnExportarTickets.Text = "Exportar Tickets";
            btnExportarTickets.UseVisualStyleBackColor = true;
            btnExportarTickets.Click += btnExportarTickets_Click;
            // 
            // btnImportarVehiculos
            // 
            btnImportarVehiculos.Location = new Point(266, 323);
            btnImportarVehiculos.Name = "btnImportarVehiculos";
            btnImportarVehiculos.Size = new Size(94, 46);
            btnImportarVehiculos.TabIndex = 8;
            btnImportarVehiculos.Text = "Importar Vehiculos";
            btnImportarVehiculos.UseVisualStyleBackColor = true;
            btnImportarVehiculos.Click += btnImportarVehiculos_Click;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(48, 9);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(187, 23);
            tbDNI.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 427);
            Controls.Add(tbDNI);
            Controls.Add(btnImportarVehiculos);
            Controls.Add(btnExportarTickets);
            Controls.Add(btnAtenderNuevoCliente);
            Controls.Add(btnAtenderDenuncias);
            Controls.Add(lsbTurnos);
            Controls.Add(label2);
            Controls.Add(btnTicket);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbTipoVehiculo;
        private RadioButton rbNuevoCliente;
        private RadioButton rbDenuncia;
        private Button btnTicket;
        private TextBox tbPatente;
        private Label label2;
        private ListBox lsbTurnos;
        private Button btnAtenderDenuncias;
        private Button btnAtenderNuevoCliente;
        private Button btnExportarTickets;
        private Button btnImportarVehiculos;
        private TextBox tbDNI;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
