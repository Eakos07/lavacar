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
            this.groupBox2.Location = new System.Drawing.Point(14, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 409);
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
            this.dgv_Facturas.Location = new System.Drawing.Point(8, 77);
            this.dgv_Facturas.Name = "dgv_Facturas";
            this.dgv_Facturas.RowTemplate.Height = 24;
            this.dgv_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Facturas.Size = new System.Drawing.Size(1168, 322);
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
            this.toolStrip1.Location = new System.Drawing.Point(3, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1176, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.Image")));
            this.btn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(24, 28);
            this.btn_Refrescar.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 28);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(24, 28);
            this.btn_Modificar.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(87, 28);
            this.toolStripLabel2.Text = "Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(63, 28);
            this.toolStripLabel4.Text = "Buscar";
            // 
            // txt_FiltrarFacturas
            // 
            this.txt_FiltrarFacturas.Name = "txt_FiltrarFacturas";
            this.txt_FiltrarFacturas.Size = new System.Drawing.Size(112, 31);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // txt_Ced_Jur
            // 
            this.txt_Ced_Jur.Location = new System.Drawing.Point(213, 305);
            this.txt_Ced_Jur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Ced_Jur.Name = "txt_Ced_Jur";
            this.txt_Ced_Jur.Size = new System.Drawing.Size(236, 31);
            this.txt_Ced_Jur.TabIndex = 14;
            // 
            // cmb_CodServ
            // 
            this.cmb_CodServ.FormattingEnabled = true;
            this.cmb_CodServ.Location = new System.Drawing.Point(214, 172);
            this.cmb_CodServ.Name = "cmb_CodServ";
            this.cmb_CodServ.Size = new System.Drawing.Size(236, 33);
            this.cmb_CodServ.TabIndex = 13;
            this.cmb_CodServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_CodServ_KeyPress);
            // 
            // cmb_NumPlaca
            // 
            this.cmb_NumPlaca.FormattingEnabled = true;
            this.cmb_NumPlaca.Location = new System.Drawing.Point(214, 111);
            this.cmb_NumPlaca.Name = "cmb_NumPlaca";
            this.cmb_NumPlaca.Size = new System.Drawing.Size(236, 33);
            this.cmb_NumPlaca.TabIndex = 12;
            this.cmb_NumPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_NumPlaca_KeyPress);
            // 
            // cmb_IdTipCamb
            // 
            this.cmb_IdTipCamb.FormattingEnabled = true;
            this.cmb_IdTipCamb.Location = new System.Drawing.Point(214, 238);
            this.cmb_IdTipCamb.Name = "cmb_IdTipCamb";
            this.cmb_IdTipCamb.Size = new System.Drawing.Size(236, 33);
            this.cmb_IdTipCamb.TabIndex = 3;
            this.cmb_IdTipCamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdTipCamb_KeyPress);
            // 
            // txt_NumFact
            // 
            this.txt_NumFact.Enabled = false;
            this.txt_NumFact.Location = new System.Drawing.Point(214, 49);
            this.txt_NumFact.Name = "txt_NumFact";
            this.txt_NumFact.Size = new System.Drawing.Size(235, 31);
            this.txt_NumFact.TabIndex = 0;
            this.txt_NumFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumFact_KeyPress);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(986, 365);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(165, 46);
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
            this.btn_Save.Location = new System.Drawing.Point(753, 365);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(165, 46);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_MontoTotal
            // 
            this.txt_MontoTotal.Location = new System.Drawing.Point(753, 111);
            this.txt_MontoTotal.Name = "txt_MontoTotal";
            this.txt_MontoTotal.Size = new System.Drawing.Size(236, 31);
            this.txt_MontoTotal.TabIndex = 7;
            this.txt_MontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoTotal_KeyPress);
            // 
            // txt_Descuent
            // 
            this.txt_Descuent.Location = new System.Drawing.Point(753, 49);
            this.txt_Descuent.Name = "txt_Descuent";
            this.txt_Descuent.Size = new System.Drawing.Size(236, 31);
            this.txt_Descuent.TabIndex = 6;
            this.txt_Descuent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descuent_KeyPress);
            // 
            // txt_MontoNeto
            // 
            this.txt_MontoNeto.Location = new System.Drawing.Point(213, 362);
            this.txt_MontoNeto.Name = "txt_MontoNeto";
            this.txt_MontoNeto.Size = new System.Drawing.Size(236, 31);
            this.txt_MontoNeto.TabIndex = 5;
            this.txt_MontoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoNeto_KeyPress);
            // 
            // cmb_IdTipFactu
            // 
            this.cmb_IdTipFactu.FormattingEnabled = true;
            this.cmb_IdTipFactu.Location = new System.Drawing.Point(753, 238);
            this.cmb_IdTipFactu.Name = "cmb_IdTipFactu";
            this.cmb_IdTipFactu.Size = new System.Drawing.Size(236, 33);
            this.cmb_IdTipFactu.TabIndex = 9;
            this.cmb_IdTipFactu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdTipFactu_KeyPress);
            // 
            // cmb_IdPromo
            // 
            this.cmb_IdPromo.FormattingEnabled = true;
            this.cmb_IdPromo.Location = new System.Drawing.Point(753, 174);
            this.cmb_IdPromo.Name = "cmb_IdPromo";
            this.cmb_IdPromo.Size = new System.Drawing.Size(236, 33);
            this.cmb_IdPromo.TabIndex = 8;
            this.cmb_IdPromo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdPromo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Id Tipo Factura:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Promoción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Monto Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descuento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto Neto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cédula Jurídica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Tipo Cambio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código Servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Factura:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FRM_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 885);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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