namespace FRM_Login.Menu
{
    partial class FRM_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Clientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NumVisitas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnAceptarClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoPlacaVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txt_NumPlaca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_RefrescarClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ModificarClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_FiltrarPlaca = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NumVisitas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btnAceptarClientes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoPlacaVehiculo);
            this.groupBox1.Controls.Add(this.cmbTipoVehiculo);
            this.groupBox1.Controls.Add(this.txt_NumPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(788, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // txt_NumVisitas
            // 
            this.txt_NumVisitas.Location = new System.Drawing.Point(539, 19);
            this.txt_NumVisitas.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumVisitas.Name = "txt_NumVisitas";
            this.txt_NumVisitas.Size = new System.Drawing.Size(138, 23);
            this.txt_NumVisitas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero Visitas:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(673, 163);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(86, 30);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptarClientes
            // 
            this.btnAceptarClientes.BackColor = System.Drawing.Color.Aqua;
            this.btnAceptarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarClientes.Location = new System.Drawing.Point(539, 163);
            this.btnAceptarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarClientes.Name = "btnAceptarClientes";
            this.btnAceptarClientes.Size = new System.Drawing.Size(115, 30);
            this.btnAceptarClientes.TabIndex = 4;
            this.btnAceptarClientes.Text = "Aceptar";
            this.btnAceptarClientes.UseVisualStyleBackColor = false;
            this.btnAceptarClientes.Click += new System.EventHandler(this.btnAceptarClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Tipo  Vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Tipo Placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Placa:";
            // 
            // cmbTipoPlacaVehiculo
            // 
            this.cmbTipoPlacaVehiculo.FormattingEnabled = true;
            this.cmbTipoPlacaVehiculo.Location = new System.Drawing.Point(206, 64);
            this.cmbTipoPlacaVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPlacaVehiculo.Name = "cmbTipoPlacaVehiculo";
            this.cmbTipoPlacaVehiculo.Size = new System.Drawing.Size(138, 25);
            this.cmbTipoPlacaVehiculo.TabIndex = 2;
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(206, 116);
            this.cmbTipoVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(138, 25);
            this.cmbTipoVehiculo.TabIndex = 1;
            // 
            // txt_NumPlaca
            // 
            this.txt_NumPlaca.Location = new System.Drawing.Point(206, 19);
            this.txt_NumPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumPlaca.Name = "txt_NumPlaca";
            this.txt_NumPlaca.Size = new System.Drawing.Size(138, 23);
            this.txt_NumPlaca.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(5, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(792, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Cliente";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_RefrescarClientes,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btn_ModificarClientes,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.txt_FiltrarPlaca});
            this.toolStrip1.Location = new System.Drawing.Point(2, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_RefrescarClientes
            // 
            this.btn_RefrescarClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RefrescarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefrescarClientes.Image")));
            this.btn_RefrescarClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RefrescarClientes.Name = "btn_RefrescarClientes";
            this.btn_RefrescarClientes.Size = new System.Drawing.Size(24, 24);
            this.btn_RefrescarClientes.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_ModificarClientes
            // 
            this.btn_ModificarClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ModificarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarClientes.Image")));
            this.btn_ModificarClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ModificarClientes.Name = "btn_ModificarClientes";
            this.btn_ModificarClientes.Size = new System.Drawing.Size(24, 24);
            this.btn_ModificarClientes.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 24);
            this.toolStripLabel2.Text = "Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(42, 24);
            this.toolStripLabel4.Text = "Buscar";
            // 
            // txt_FiltrarPlaca
            // 
            this.txt_FiltrarPlaca.Name = "txt_FiltrarPlaca";
            this.txt_FiltrarPlaca.Size = new System.Drawing.Size(76, 27);
            this.txt_FiltrarPlaca.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FRM_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Clientes";
            this.Text = "FRM_Clientes";
            this.Load += new System.EventHandler(this.FRM_Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NumVisitas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnAceptarClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoPlacaVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txt_NumPlaca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_RefrescarClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_ModificarClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_FiltrarPlaca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}