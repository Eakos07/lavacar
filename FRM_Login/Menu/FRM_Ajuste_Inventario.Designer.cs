﻿namespace FRM_Login.Menu
{
    partial class FRM_Ajuste_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Ajuste_Inventario));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_FiltrarDescrip = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_Ajuste = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_dolares = new System.Windows.Forms.RadioButton();
            this.rdb_colones = new System.Windows.Forms.RadioButton();
            this.txt_Fecha = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_IdAjus = new System.Windows.Forms.TextBox();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Articulo = new System.Windows.Forms.ComboBox();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ajuste)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dgv_Ajuste);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(5, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(792, 333);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Ajuste Inventario";
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
            this.toolStripButton1,
            this.toolStripLabel4,
            this.txt_FiltrarDescrip});
            this.toolStrip1.Location = new System.Drawing.Point(2, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.Image")));
            this.btn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(24, 24);
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
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
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Buscar";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(42, 24);
            this.toolStripLabel4.Text = "Buscar";
            // 
            // txt_FiltrarDescrip
            // 
            this.txt_FiltrarDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FiltrarDescrip.Name = "txt_FiltrarDescrip";
            this.txt_FiltrarDescrip.Size = new System.Drawing.Size(76, 27);
            this.txt_FiltrarDescrip.TextChanged += new System.EventHandler(this.txt_FiltrarDescrip_TextChanged);
            // 
            // dgv_Ajuste
            // 
            this.dgv_Ajuste.AllowUserToAddRows = false;
            this.dgv_Ajuste.AllowUserToDeleteRows = false;
            this.dgv_Ajuste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Ajuste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Ajuste.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ajuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ajuste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Ajuste.Location = new System.Drawing.Point(4, 57);
            this.dgv_Ajuste.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Ajuste.MultiSelect = false;
            this.dgv_Ajuste.Name = "dgv_Ajuste";
            this.dgv_Ajuste.RowTemplate.Height = 24;
            this.dgv_Ajuste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ajuste.Size = new System.Drawing.Size(781, 264);
            this.dgv_Ajuste.TabIndex = 0;
            this.dgv_Ajuste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ajuste_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdb_dolares);
            this.groupBox1.Controls.Add(this.rdb_colones);
            this.groupBox1.Controls.Add(this.txt_Fecha);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.txt_IdAjus);
            this.groupBox1.Controls.Add(this.txt_Monto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Articulo);
            this.groupBox1.Controls.Add(this.txt_Descrip);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(790, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajustes Inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Moneda";
            // 
            // rdb_dolares
            // 
            this.rdb_dolares.AutoSize = true;
            this.rdb_dolares.Location = new System.Drawing.Point(604, 80);
            this.rdb_dolares.Name = "rdb_dolares";
            this.rdb_dolares.Size = new System.Drawing.Size(75, 21);
            this.rdb_dolares.TabIndex = 7;
            this.rdb_dolares.Text = "Dolares";
            this.rdb_dolares.UseVisualStyleBackColor = true;
            // 
            // rdb_colones
            // 
            this.rdb_colones.AutoSize = true;
            this.rdb_colones.Checked = true;
            this.rdb_colones.Location = new System.Drawing.Point(522, 80);
            this.rdb_colones.Name = "rdb_colones";
            this.rdb_colones.Size = new System.Drawing.Size(77, 21);
            this.rdb_colones.TabIndex = 6;
            this.rdb_colones.TabStop = true;
            this.rdb_colones.Text = "Colones";
            this.rdb_colones.UseVisualStyleBackColor = true;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(242, 153);
            this.txt_Fecha.Mask = "00/00/0000";
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(150, 23);
            this.txt_Fecha.TabIndex = 4;
            this.txt_Fecha.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(532, 39);
            this.txt_Cantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // txt_IdAjus
            // 
            this.txt_IdAjus.Enabled = false;
            this.txt_IdAjus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdAjus.Location = new System.Drawing.Point(242, 33);
            this.txt_IdAjus.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdAjus.Multiline = true;
            this.txt_IdAjus.Name = "txt_IdAjus";
            this.txt_IdAjus.Size = new System.Drawing.Size(150, 27);
            this.txt_IdAjus.TabIndex = 1;
            this.txt_IdAjus.TabStop = false;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto.Location = new System.Drawing.Point(522, 108);
            this.txt_Monto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Monto.Multiline = true;
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(83, 27);
            this.txt_Monto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cantidad:";
            // 
            // cmb_Articulo
            // 
            this.cmb_Articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Articulo.FormattingEnabled = true;
            this.cmb_Articulo.Location = new System.Drawing.Point(242, 72);
            this.cmb_Articulo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Articulo.Name = "cmb_Articulo";
            this.cmb_Articulo.Size = new System.Drawing.Size(150, 25);
            this.cmb_Articulo.TabIndex = 2;
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descrip.Location = new System.Drawing.Point(242, 111);
            this.txt_Descrip.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descrip.Multiline = true;
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(150, 27);
            this.txt_Descrip.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(652, 170);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 30);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aqua;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.Location = new System.Drawing.Point(490, 170);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 30);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Id Artículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Transaciones Ajuste Inventario:";
            // 
            // FRM_Ajuste_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Ajuste_Inventario";
            this.Text = "FRM_Ajuste_Inventario";
            this.Load += new System.EventHandler(this.FRM_Ajuste_Inventario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ajuste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_FiltrarDescrip;
        private System.Windows.Forms.DataGridView dgv_Ajuste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Articulo;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdAjus;
        private System.Windows.Forms.MaskedTextBox txt_Fecha;
        private System.Windows.Forms.NumericUpDown txt_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb_dolares;
        private System.Windows.Forms.RadioButton rdb_colones;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}