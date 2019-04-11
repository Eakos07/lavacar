namespace FRM_Login.Menu
{
    partial class FRM_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Factura));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Facturas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_FiltrarFacturas = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Ced_Jur = new System.Windows.Forms.TextBox();
            this.cmb_CodServ = new System.Windows.Forms.ComboBox();
            this.cmb_NumPlaca = new System.Windows.Forms.ComboBox();
            this.cmb_IdTipCamb = new System.Windows.Forms.ComboBox();
            this.txt_NumFact = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_MontoTotal = new System.Windows.Forms.TextBox();
            this.txt_Descuent = new System.Windows.Forms.TextBox();
            this.txt_MontoNeto = new System.Windows.Forms.TextBox();
            this.cmb_IdTipFactu = new System.Windows.Forms.ComboBox();
            this.cmb_IdPromo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Facturas);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(9, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(788, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Factura";
            // 
            // dgv_Facturas
            // 
            this.dgv_Facturas.AllowUserToAddRows = false;
            this.dgv_Facturas.AllowUserToDeleteRows = false;
            this.dgv_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Facturas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Facturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Facturas.Location = new System.Drawing.Point(5, 50);
            this.dgv_Facturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Facturas.Name = "dgv_Facturas";
            this.dgv_Facturas.RowTemplate.Height = 24;
            this.dgv_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Facturas.Size = new System.Drawing.Size(779, 209);
            this.dgv_Facturas.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Refrescar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btn_Modificar,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.txt_FiltrarFacturas});
            this.toolStrip1.Location = new System.Drawing.Point(2, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.Image")));
            this.btn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(24, 24);
            this.btn_Refrescar.Text = "toolStripButton1";
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
            // btn_Modificar
            // 
            this.btn_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(24, 24);
            this.btn_Modificar.Text = "toolStripButton2";
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
            // txt_FiltrarFacturas
            // 
            this.txt_FiltrarFacturas.Name = "txt_FiltrarFacturas";
            this.txt_FiltrarFacturas.Size = new System.Drawing.Size(76, 27);
            this.txt_FiltrarFacturas.TextChanged += new System.EventHandler(this.txt_FiltrarFacturas_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Ced_Jur);
            this.groupBox1.Controls.Add(this.cmb_CodServ);
            this.groupBox1.Controls.Add(this.cmb_NumPlaca);
            this.groupBox1.Controls.Add(this.cmb_IdTipCamb);
            this.groupBox1.Controls.Add(this.txt_NumFact);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_MontoTotal);
            this.groupBox1.Controls.Add(this.txt_Descuent);
            this.groupBox1.Controls.Add(this.txt_MontoNeto);
            this.groupBox1.Controls.Add(this.cmb_IdTipFactu);
            this.groupBox1.Controls.Add(this.cmb_IdPromo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(791, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // txt_Ced_Jur
            // 
            this.txt_Ced_Jur.Location = new System.Drawing.Point(142, 198);
            this.txt_Ced_Jur.Name = "txt_Ced_Jur";
            this.txt_Ced_Jur.Size = new System.Drawing.Size(159, 23);
            this.txt_Ced_Jur.TabIndex = 14;
            // 
            // cmb_CodServ
            // 
            this.cmb_CodServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodServ.FormattingEnabled = true;
            this.cmb_CodServ.Location = new System.Drawing.Point(143, 112);
            this.cmb_CodServ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_CodServ.Name = "cmb_CodServ";
            this.cmb_CodServ.Size = new System.Drawing.Size(159, 25);
            this.cmb_CodServ.TabIndex = 13;
            this.cmb_CodServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_CodServ_KeyPress);
            // 
            // cmb_NumPlaca
            // 
            this.cmb_NumPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NumPlaca.FormattingEnabled = true;
            this.cmb_NumPlaca.Location = new System.Drawing.Point(143, 72);
            this.cmb_NumPlaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_NumPlaca.Name = "cmb_NumPlaca";
            this.cmb_NumPlaca.Size = new System.Drawing.Size(159, 25);
            this.cmb_NumPlaca.TabIndex = 12;
            this.cmb_NumPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_NumPlaca_KeyPress);
            // 
            // cmb_IdTipCamb
            // 
            this.cmb_IdTipCamb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdTipCamb.FormattingEnabled = true;
            this.cmb_IdTipCamb.Location = new System.Drawing.Point(143, 155);
            this.cmb_IdTipCamb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_IdTipCamb.Name = "cmb_IdTipCamb";
            this.cmb_IdTipCamb.Size = new System.Drawing.Size(159, 25);
            this.cmb_IdTipCamb.TabIndex = 3;
            this.cmb_IdTipCamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdTipCamb_KeyPress);
            // 
            // txt_NumFact
            // 
            this.txt_NumFact.Enabled = false;
            this.txt_NumFact.Location = new System.Drawing.Point(143, 32);
            this.txt_NumFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NumFact.Name = "txt_NumFact";
            this.txt_NumFact.Size = new System.Drawing.Size(158, 23);
            this.txt_NumFact.TabIndex = 0;
            this.txt_NumFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumFact_KeyPress);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(657, 237);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 30);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aqua;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(502, 237);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 30);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_MontoTotal
            // 
            this.txt_MontoTotal.Location = new System.Drawing.Point(502, 72);
            this.txt_MontoTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MontoTotal.Name = "txt_MontoTotal";
            this.txt_MontoTotal.Size = new System.Drawing.Size(159, 23);
            this.txt_MontoTotal.TabIndex = 7;
            this.txt_MontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoTotal_KeyPress);
            // 
            // txt_Descuent
            // 
            this.txt_Descuent.Location = new System.Drawing.Point(502, 32);
            this.txt_Descuent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Descuent.Name = "txt_Descuent";
            this.txt_Descuent.Size = new System.Drawing.Size(159, 23);
            this.txt_Descuent.TabIndex = 6;
            this.txt_Descuent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descuent_KeyPress);
            // 
            // txt_MontoNeto
            // 
            this.txt_MontoNeto.Location = new System.Drawing.Point(142, 235);
            this.txt_MontoNeto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MontoNeto.Name = "txt_MontoNeto";
            this.txt_MontoNeto.Size = new System.Drawing.Size(159, 23);
            this.txt_MontoNeto.TabIndex = 5;
            this.txt_MontoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoNeto_KeyPress);
            // 
            // cmb_IdTipFactu
            // 
            this.cmb_IdTipFactu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdTipFactu.FormattingEnabled = true;
            this.cmb_IdTipFactu.Location = new System.Drawing.Point(502, 155);
            this.cmb_IdTipFactu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_IdTipFactu.Name = "cmb_IdTipFactu";
            this.cmb_IdTipFactu.Size = new System.Drawing.Size(159, 25);
            this.cmb_IdTipFactu.TabIndex = 9;
            this.cmb_IdTipFactu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdTipFactu_KeyPress);
            // 
            // cmb_IdPromo
            // 
            this.cmb_IdPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdPromo.FormattingEnabled = true;
            this.cmb_IdPromo.Location = new System.Drawing.Point(502, 113);
            this.cmb_IdPromo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_IdPromo.Name = "cmb_IdPromo";
            this.cmb_IdPromo.Size = new System.Drawing.Size(159, 25);
            this.cmb_IdPromo.TabIndex = 8;
            this.cmb_IdPromo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdPromo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Id Tipo Factura:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Promoción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Monto Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descuento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto Neto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cédula Jurídica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Tipo Cambio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código Servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Factura:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FRM_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_Factura";
            this.Text = "FRM_Factura";
            this.Load += new System.EventHandler(this.FRM_Factura_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Facturas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_FiltrarFacturas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_IdTipCamb;
        private System.Windows.Forms.TextBox txt_NumFact;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_MontoTotal;
        private System.Windows.Forms.TextBox txt_Descuent;
        private System.Windows.Forms.TextBox txt_MontoNeto;
        private System.Windows.Forms.ComboBox cmb_IdTipFactu;
        private System.Windows.Forms.ComboBox cmb_IdPromo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_CodServ;
        private System.Windows.Forms.ComboBox cmb_NumPlaca;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TextBox txt_Ced_Jur;
    }
}