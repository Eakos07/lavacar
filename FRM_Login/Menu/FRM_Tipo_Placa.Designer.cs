﻿namespace FRM_Login.Menu
{
    partial class FRM_Tipo_Placa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Tipo_Placa));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Filtrar = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_TipoPlaca = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_IdTipoPlaca = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoPlaca)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dgv_TipoPlaca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(5, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(792, 333);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Tipo Placa:";
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
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripLabel4,
            this.txt_Filtrar});
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
            // txt_Filtrar
            // 
            this.txt_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(76, 27);
            this.txt_Filtrar.TextChanged += new System.EventHandler(this.txt_Filtrar_TextChanged);
            // 
            // dgv_TipoPlaca
            // 
            this.dgv_TipoPlaca.AllowUserToAddRows = false;
            this.dgv_TipoPlaca.AllowUserToDeleteRows = false;
            this.dgv_TipoPlaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_TipoPlaca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_TipoPlaca.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TipoPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TipoPlaca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TipoPlaca.Location = new System.Drawing.Point(4, 51);
            this.dgv_TipoPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TipoPlaca.MultiSelect = false;
            this.dgv_TipoPlaca.Name = "dgv_TipoPlaca";
            this.dgv_TipoPlaca.RowTemplate.Height = 24;
            this.dgv_TipoPlaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TipoPlaca.Size = new System.Drawing.Size(781, 277);
            this.dgv_TipoPlaca.TabIndex = 0;
            this.dgv_TipoPlaca.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TipoPlaca_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_IdTipoPlaca);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(790, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Placa:";
            // 
            // txt_IdTipoPlaca
            // 
            this.txt_IdTipoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTipoPlaca.Location = new System.Drawing.Point(202, 38);
            this.txt_IdTipoPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdTipoPlaca.Multiline = true;
            this.txt_IdTipoPlaca.Name = "txt_IdTipoPlaca";
            this.txt_IdTipoPlaca.Size = new System.Drawing.Size(150, 27);
            this.txt_IdTipoPlaca.TabIndex = 1;
            this.txt_IdTipoPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdTipoPlaca_KeyPress);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(202, 108);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(150, 27);
            this.txt_Descripcion.TabIndex = 2;
            this.txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descripcion_KeyPress);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Aqua;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Enabled = false;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.Location = new System.Drawing.Point(652, 170);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(110, 30);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Aqua;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.Location = new System.Drawing.Point(490, 170);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 30);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Tipo Placa:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FRM_Tipo_Placa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Tipo_Placa";
            this.Text = "FRM_Tipo_Placa";
            this.Load += new System.EventHandler(this.FRM_Tipo_Placa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoPlaca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_Filtrar;
        private System.Windows.Forms.DataGridView dgv_TipoPlaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdTipoPlaca;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}