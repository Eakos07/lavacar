namespace FRM_Login.Menu
{
    partial class FRM_Transaccion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Transaccion));
            this.tcArticulos = new System.Windows.Forms.TabControl();
            this.tbTransacciones = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_FechaC = new System.Windows.Forms.MaskedTextBox();
            this.txt_IdTranC = new System.Windows.Forms.TextBox();
            this.txt_CantidadC = new System.Windows.Forms.TextBox();
            this.txt_Doc = new System.Windows.Forms.TextBox();
            this.cmb_Orden = new System.Windows.Forms.ComboBox();
            this.cmb_ArtC = new System.Windows.Forms.ComboBox();
            this.cmb_Prov = new System.Windows.Forms.ComboBox();
            this.txt_MontoC = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_FiltrarArticulos = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_TransCompra = new System.Windows.Forms.DataGridView();
            this.tbTransVentas = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_TransVenta = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_IdTransV = new System.Windows.Forms.TextBox();
            this.txt_FechaV = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.txt_MontoV = new System.Windows.Forms.TextBox();
            this.cmb_ArtV = new System.Windows.Forms.ComboBox();
            this.cmb_Fact = new System.Windows.Forms.ComboBox();
            this.txt_CantidadV = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcArticulos.SuspendLayout();
            this.tbTransacciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransCompra)).BeginInit();
            this.tbTransVentas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransVenta)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tcArticulos
            // 
            this.tcArticulos.Controls.Add(this.tbTransacciones);
            this.tcArticulos.Controls.Add(this.tbTransVentas);
            this.tcArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcArticulos.Location = new System.Drawing.Point(2, 9);
            this.tcArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.tcArticulos.Name = "tcArticulos";
            this.tcArticulos.SelectedIndex = 0;
            this.tcArticulos.Size = new System.Drawing.Size(799, 557);
            this.tcArticulos.TabIndex = 4;
            // 
            // tbTransacciones
            // 
            this.tbTransacciones.Controls.Add(this.groupBox1);
            this.tbTransacciones.Controls.Add(this.groupBox2);
            this.tbTransacciones.Location = new System.Drawing.Point(4, 26);
            this.tbTransacciones.Margin = new System.Windows.Forms.Padding(2);
            this.tbTransacciones.Name = "tbTransacciones";
            this.tbTransacciones.Padding = new System.Windows.Forms.Padding(2);
            this.tbTransacciones.Size = new System.Drawing.Size(791, 527);
            this.tbTransacciones.TabIndex = 0;
            this.tbTransacciones.Text = "Transacciones Compra";
            this.tbTransacciones.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_FechaC);
            this.groupBox1.Controls.Add(this.txt_IdTranC);
            this.groupBox1.Controls.Add(this.txt_CantidadC);
            this.groupBox1.Controls.Add(this.txt_Doc);
            this.groupBox1.Controls.Add(this.cmb_Orden);
            this.groupBox1.Controls.Add(this.cmb_ArtC);
            this.groupBox1.Controls.Add(this.cmb_Prov);
            this.groupBox1.Controls.Add(this.txt_MontoC);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(782, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // txt_FechaC
            // 
            this.txt_FechaC.Location = new System.Drawing.Point(566, 70);
            this.txt_FechaC.Mask = "00/00/0000";
            this.txt_FechaC.Name = "txt_FechaC";
            this.txt_FechaC.Size = new System.Drawing.Size(139, 23);
            this.txt_FechaC.TabIndex = 34;
            this.txt_FechaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FechaC.ValidatingType = typeof(System.DateTime);
            this.txt_FechaC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txt_IdTranC
            // 
            this.txt_IdTranC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTranC.Location = new System.Drawing.Point(209, 31);
            this.txt_IdTranC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdTranC.Multiline = true;
            this.txt_IdTranC.Name = "txt_IdTranC";
            this.txt_IdTranC.Size = new System.Drawing.Size(139, 27);
            this.txt_IdTranC.TabIndex = 12;
            this.txt_IdTranC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // txt_CantidadC
            // 
            this.txt_CantidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantidadC.Location = new System.Drawing.Point(566, 106);
            this.txt_CantidadC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CantidadC.Multiline = true;
            this.txt_CantidadC.Name = "txt_CantidadC";
            this.txt_CantidadC.Size = new System.Drawing.Size(139, 27);
            this.txt_CantidadC.TabIndex = 6;
            this.txt_CantidadC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txt_Doc
            // 
            this.txt_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Doc.Location = new System.Drawing.Point(566, 28);
            this.txt_Doc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Doc.Multiline = true;
            this.txt_Doc.Name = "txt_Doc";
            this.txt_Doc.Size = new System.Drawing.Size(139, 27);
            this.txt_Doc.TabIndex = 4;
            this.txt_Doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cmb_Orden
            // 
            this.cmb_Orden.FormattingEnabled = true;
            this.cmb_Orden.Location = new System.Drawing.Point(209, 69);
            this.cmb_Orden.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Orden.Name = "cmb_Orden";
            this.cmb_Orden.Size = new System.Drawing.Size(139, 25);
            this.cmb_Orden.TabIndex = 1;
            this.cmb_Orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox7_KeyPress);
            // 
            // cmb_ArtC
            // 
            this.cmb_ArtC.FormattingEnabled = true;
            this.cmb_ArtC.Location = new System.Drawing.Point(209, 106);
            this.cmb_ArtC.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ArtC.Name = "cmb_ArtC";
            this.cmb_ArtC.Size = new System.Drawing.Size(139, 25);
            this.cmb_ArtC.TabIndex = 2;
            this.cmb_ArtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox6_KeyPress);
            // 
            // cmb_Prov
            // 
            this.cmb_Prov.FormattingEnabled = true;
            this.cmb_Prov.Location = new System.Drawing.Point(209, 150);
            this.cmb_Prov.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Prov.Name = "cmb_Prov";
            this.cmb_Prov.Size = new System.Drawing.Size(139, 25);
            this.cmb_Prov.TabIndex = 3;
            this.cmb_Prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // txt_MontoC
            // 
            this.txt_MontoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MontoC.Location = new System.Drawing.Point(566, 151);
            this.txt_MontoC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MontoC.Multiline = true;
            this.txt_MontoC.Name = "txt_MontoC";
            this.txt_MontoC.Size = new System.Drawing.Size(139, 27);
            this.txt_MontoC.TabIndex = 7;
            this.txt_MontoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(650, 193);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(110, 30);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Documento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id Artículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Número Orden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Transacciones Compra:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dgv_TransCompra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(2, 247);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(786, 293);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Transaccion Compra";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.txt_FiltrarArticulos});
            this.toolStrip1.Location = new System.Drawing.Point(2, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 24);
            this.toolStripLabel2.Text = "Modificar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "btn_ModiC";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // txt_FiltrarArticulos
            // 
            this.txt_FiltrarArticulos.Name = "txt_FiltrarArticulos";
            this.txt_FiltrarArticulos.Size = new System.Drawing.Size(76, 27);
            // 
            // dgv_TransCompra
            // 
            this.dgv_TransCompra.AllowUserToAddRows = false;
            this.dgv_TransCompra.AllowUserToDeleteRows = false;
            this.dgv_TransCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_TransCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_TransCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TransCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TransCompra.Location = new System.Drawing.Point(4, 51);
            this.dgv_TransCompra.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TransCompra.Name = "dgv_TransCompra";
            this.dgv_TransCompra.RowTemplate.Height = 24;
            this.dgv_TransCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TransCompra.Size = new System.Drawing.Size(767, 228);
            this.dgv_TransCompra.TabIndex = 0;
            // 
            // tbTransVentas
            // 
            this.tbTransVentas.Controls.Add(this.groupBox4);
            this.tbTransVentas.Controls.Add(this.groupBox3);
            this.tbTransVentas.Location = new System.Drawing.Point(4, 26);
            this.tbTransVentas.Margin = new System.Windows.Forms.Padding(2);
            this.tbTransVentas.Name = "tbTransVentas";
            this.tbTransVentas.Padding = new System.Windows.Forms.Padding(2);
            this.tbTransVentas.Size = new System.Drawing.Size(791, 527);
            this.tbTransVentas.TabIndex = 1;
            this.tbTransVentas.Text = "Transacciones Venta";
            this.tbTransVentas.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Controls.Add(this.dgv_TransVenta);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox4.Location = new System.Drawing.Point(0, 246);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(786, 281);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tabla Transaccion Venta";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripLabel6,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.toolStripLabel7,
            this.toolStripButton6,
            this.toolStripSeparator6,
            this.toolStripLabel8,
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(2, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel5.Text = "Refrescar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(58, 24);
            this.toolStripLabel6.Text = "Modificar";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "btn_ModifV";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel7.Text = "Eliminar";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton3";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(42, 24);
            this.toolStripLabel8.Text = "Buscar";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(76, 27);
            // 
            // dgv_TransVenta
            // 
            this.dgv_TransVenta.AllowUserToAddRows = false;
            this.dgv_TransVenta.AllowUserToDeleteRows = false;
            this.dgv_TransVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_TransVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_TransVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TransVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TransVenta.Location = new System.Drawing.Point(4, 51);
            this.dgv_TransVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TransVenta.Name = "dgv_TransVenta";
            this.dgv_TransVenta.RowTemplate.Height = 24;
            this.dgv_TransVenta.Size = new System.Drawing.Size(778, 227);
            this.dgv_TransVenta.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txt_IdTransV);
            this.groupBox3.Controls.Add(this.txt_FechaV);
            this.groupBox3.Controls.Add(this.cmb_Estado);
            this.groupBox3.Controls.Add(this.txt_MontoV);
            this.groupBox3.Controls.Add(this.cmb_ArtV);
            this.groupBox3.Controls.Add(this.cmb_Fact);
            this.groupBox3.Controls.Add(this.txt_CantidadV);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(2, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(782, 240);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venta";
            // 
            // txt_IdTransV
            // 
            this.txt_IdTransV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTransV.Location = new System.Drawing.Point(209, 28);
            this.txt_IdTransV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdTransV.Multiline = true;
            this.txt_IdTransV.Name = "txt_IdTransV";
            this.txt_IdTransV.Size = new System.Drawing.Size(139, 27);
            this.txt_IdTransV.TabIndex = 36;
            // 
            // txt_FechaV
            // 
            this.txt_FechaV.Location = new System.Drawing.Point(209, 152);
            this.txt_FechaV.Mask = "00/00/0000";
            this.txt_FechaV.Name = "txt_FechaV";
            this.txt_FechaV.Size = new System.Drawing.Size(139, 23);
            this.txt_FechaV.TabIndex = 35;
            this.txt_FechaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FechaV.ValidatingType = typeof(System.DateTime);
            this.txt_FechaV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(566, 106);
            this.cmb_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(139, 25);
            this.cmb_Estado.TabIndex = 34;
            this.cmb_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox5_KeyPress);
            // 
            // txt_MontoV
            // 
            this.txt_MontoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MontoV.Location = new System.Drawing.Point(566, 69);
            this.txt_MontoV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MontoV.Multiline = true;
            this.txt_MontoV.Name = "txt_MontoV";
            this.txt_MontoV.Size = new System.Drawing.Size(139, 27);
            this.txt_MontoV.TabIndex = 33;
            this.txt_MontoV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // cmb_ArtV
            // 
            this.cmb_ArtV.FormattingEnabled = true;
            this.cmb_ArtV.Location = new System.Drawing.Point(209, 69);
            this.cmb_ArtV.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ArtV.Name = "cmb_ArtV";
            this.cmb_ArtV.Size = new System.Drawing.Size(139, 25);
            this.cmb_ArtV.TabIndex = 30;
            this.cmb_ArtV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // cmb_Fact
            // 
            this.cmb_Fact.FormattingEnabled = true;
            this.cmb_Fact.Location = new System.Drawing.Point(209, 106);
            this.cmb_Fact.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Fact.Name = "cmb_Fact";
            this.cmb_Fact.Size = new System.Drawing.Size(139, 25);
            this.cmb_Fact.TabIndex = 29;
            this.cmb_Fact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
            // 
            // txt_CantidadV
            // 
            this.txt_CantidadV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantidadV.Location = new System.Drawing.Point(566, 31);
            this.txt_CantidadV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CantidadV.Multiline = true;
            this.txt_CantidadV.Name = "txt_CantidadV";
            this.txt_CantidadV.Size = new System.Drawing.Size(139, 27);
            this.txt_CantidadV.TabIndex = 22;
            this.txt_CantidadV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(650, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(500, 193);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cantidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Id Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(419, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Monto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Fecha:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 72);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Id Artículo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 113);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Id Número Factura:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Id Transacciones Venta:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FRM_Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.tcArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Transaccion";
            this.Text = "FRM_Transaccion";
            this.Load += new System.EventHandler(this.FRM_Transaccion_Load);
            this.tcArticulos.ResumeLayout(false);
            this.tbTransacciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransCompra)).EndInit();
            this.tbTransVentas.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransVenta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcArticulos;
        private System.Windows.Forms.TabPage tbTransacciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Prov;
        private System.Windows.Forms.TextBox txt_MontoC;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_FiltrarArticulos;
        private System.Windows.Forms.DataGridView dgv_TransCompra;
        private System.Windows.Forms.TabPage tbTransVentas;
        private System.Windows.Forms.TextBox txt_CantidadC;
        private System.Windows.Forms.TextBox txt_Doc;
        private System.Windows.Forms.ComboBox cmb_Orden;
        private System.Windows.Forms.ComboBox cmb_ArtC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dgv_TransVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.TextBox txt_MontoV;
        private System.Windows.Forms.ComboBox cmb_ArtV;
        private System.Windows.Forms.ComboBox cmb_Fact;
        private System.Windows.Forms.TextBox txt_CantidadV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_IdTranC;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.MaskedTextBox txt_FechaC;
        private System.Windows.Forms.MaskedTextBox txt_FechaV;
        private System.Windows.Forms.TextBox txt_IdTransV;
    }
}