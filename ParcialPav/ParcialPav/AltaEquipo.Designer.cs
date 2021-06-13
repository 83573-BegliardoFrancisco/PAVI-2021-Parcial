namespace ParcialPav
{
    partial class AltaEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDeEquipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NroJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarJugador = new System.Windows.Forms.Button();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNroJugador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNroNuevoEquipo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.btnAgregarJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de nuevo equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNroNuevoEquipo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbCategorias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreDeEquipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(458, 64);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorias.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoría:";
            // 
            // txtNombreDeEquipo
            // 
            this.txtNombreDeEquipo.Location = new System.Drawing.Point(284, 64);
            this.txtNombreDeEquipo.Name = "txtNombreDeEquipo";
            this.txtNombreDeEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDeEquipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de equipo:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(58, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Controls.Add(this.dataGridView1);
            this.btnAgregarJugador.Controls.Add(this.label8);
            this.btnAgregarJugador.Controls.Add(this.button1);
            this.btnAgregarJugador.Controls.Add(this.btnBuscarJugador);
            this.btnAgregarJugador.Controls.Add(this.cmbPosicion);
            this.btnAgregarJugador.Controls.Add(this.label7);
            this.btnAgregarJugador.Controls.Add(this.textBox1);
            this.btnAgregarJugador.Controls.Add(this.txtNroJugador);
            this.btnAgregarJugador.Controls.Add(this.label6);
            this.btnAgregarJugador.Controls.Add(this.label5);
            this.btnAgregarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.Location = new System.Drawing.Point(27, 197);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(585, 340);
            this.btnAgregarJugador.TabIndex = 6;
            this.btnAgregarJugador.TabStop = false;
            this.btnAgregarJugador.Text = "Jugadores del equipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroJugador,
            this.NombreJugador,
            this.NroPosicion});
            this.dataGridView1.Location = new System.Drawing.Point(9, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 193);
            this.dataGridView1.TabIndex = 13;
            // 
            // NroJugador
            // 
            this.NroJugador.HeaderText = "Nro del jugador";
            this.NroJugador.Name = "NroJugador";
            this.NroJugador.Width = 150;
            // 
            // NombreJugador
            // 
            this.NombreJugador.HeaderText = "Nombre del jugador";
            this.NombreJugador.Name = "NombreJugador";
            this.NombreJugador.Width = 220;
            // 
            // NroPosicion
            // 
            this.NroPosicion.HeaderText = "Nro de posición";
            this.NroPosicion.Name = "NroPosicion";
            this.NroPosicion.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Equipo formado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar jugador";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarJugador
            // 
            this.btnBuscarJugador.Location = new System.Drawing.Point(167, 34);
            this.btnBuscarJugador.Name = "btnBuscarJugador";
            this.btnBuscarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarJugador.TabIndex = 10;
            this.btnBuscarJugador.Text = "Buscar";
            this.btnBuscarJugador.UseVisualStyleBackColor = true;
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(336, 69);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Posicion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtNroJugador
            // 
            this.txtNroJugador.Location = new System.Drawing.Point(84, 36);
            this.txtNroJugador.Name = "txtNroJugador";
            this.txtNroJugador.Size = new System.Drawing.Size(74, 20);
            this.txtNroJugador.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre del jugador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jugador n°:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Confirmar equipo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nro nuevo equipo:";
            // 
            // txtNroNuevoEquipo
            // 
            this.txtNroNuevoEquipo.Location = new System.Drawing.Point(125, 28);
            this.txtNroNuevoEquipo.Name = "txtNroNuevoEquipo";
            this.txtNroNuevoEquipo.Size = new System.Drawing.Size(73, 20);
            this.txtNroNuevoEquipo.TabIndex = 14;
            // 
            // AltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AltaEquipo";
            this.Text = "AltaEquipo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnAgregarJugador.ResumeLayout(false);
            this.btnAgregarJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreDeEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox btnAgregarJugador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarJugador;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNroJugador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPosicion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNroNuevoEquipo;
        private System.Windows.Forms.Label label9;
    }
}