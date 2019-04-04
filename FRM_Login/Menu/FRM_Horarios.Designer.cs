namespace FRM_Login.Menu
{
    partial class FRM_Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Horarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CantiHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.cmb_IdFamilia = new System.Windows.Forms.ComboBox();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Buscar = new System.Windows.Forms.ToolStripLabel();
            this.txt_FiltrarHorarios = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_CantiHoras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cmb_IdEstado);
            this.groupBox1.Controls.Add(this.cmb_IdFamilia);
            this.groupBox1.Controls.Add(this.txt_Descrip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(7, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1059, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entrada";
            // 
            // txt_CantiHoras
            // 
            this.txt_CantiHoras.Location = new System.Drawing.Point(189, 135);
            this.txt_CantiHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CantiHoras.Name = "txt_CantiHoras";
            this.txt_CantiHoras.Size = new System.Drawing.Size(239, 27);
            this.txt_CantiHoras.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad Horas:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(880, 217);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 37);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aqua;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(681, 217);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(147, 37);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.Location = new System.Drawing.Point(788, 139);
            this.cmb_IdEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(239, 28);
            this.cmb_IdEstado.TabIndex = 3;
            // 
            // cmb_IdFamilia
            // 
            this.cmb_IdFamilia.FormattingEnabled = true;
            this.cmb_IdFamilia.Location = new System.Drawing.Point(189, 42);
            this.cmb_IdFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_IdFamilia.Name = "cmb_IdFamilia";
            this.cmb_IdFamilia.Size = new System.Drawing.Size(239, 28);
            this.cmb_IdFamilia.TabIndex = 0;
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.Location = new System.Drawing.Point(189, 90);
            this.txt_Descrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(239, 27);
            this.txt_Descrip.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Familia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dgv_Horarios);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1056, 392);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Horario";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btn_Modificar,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btn_Buscar,
            this.txt_FiltrarHorarios});
            this.toolStrip1.Location = new System.Drawing.Point(3, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 24);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "btn_Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 24);
            this.toolStripLabel2.Text = "Modificar";
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
            // btn_Buscar
            // 
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(52, 24);
            this.btn_Buscar.Text = "Buscar";
            // 
            // txt_FiltrarHorarios
            // 
            this.txt_FiltrarHorarios.Name = "txt_FiltrarHorarios";
            this.txt_FiltrarHorarios.Size = new System.Drawing.Size(100, 27);
            this.txt_FiltrarHorarios.TextChanged += new System.EventHandler(this.txt_FiltrarHorarios_TextChanged);
            // 
            // dgv_Horarios
            // 
            this.dgv_Horarios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.Location = new System.Drawing.Point(5, 63);
            this.dgv_Horarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.RowTemplate.Height = 24;
            this.dgv_Horarios.Size = new System.Drawing.Size(1041, 310);
            this.dgv_Horarios.TabIndex = 0;
            // 
            // FRM_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 708);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_Horarios";
            this.Text = "FRM_Horarios";
            this.Load += new System.EventHandler(this.FRM_Horarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmb_IdEstado;
        private System.Windows.Forms.ComboBox cmb_IdFamilia;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel btn_Buscar;
        private System.Windows.Forms.ToolStripTextBox txt_FiltrarHorarios;
        private System.Windows.Forms.DataGridView dgv_Horarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CantiHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}