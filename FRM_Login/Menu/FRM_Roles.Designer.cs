namespace FRM_Login.Menu
{
    partial class FRM_Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Roles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.txt_Nivel = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_FiltrarRoles = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.txt_IdRol = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_IdRol);
            this.groupBox1.Controls.Add(this.cmb_IdEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Descrip);
            this.groupBox1.Controls.Add(this.txt_Nivel);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(4, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(790, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.Location = new System.Drawing.Point(542, 31);
            this.cmb_IdEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(139, 25);
            this.cmb_IdEstado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id Estado:";
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descrip.Location = new System.Drawing.Point(164, 146);
            this.txt_Descrip.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descrip.Multiline = true;
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(139, 27);
            this.txt_Descrip.TabIndex = 3;
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nivel.Location = new System.Drawing.Point(164, 89);
            this.txt_Nivel.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nivel.Multiline = true;
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Size = new System.Drawing.Size(139, 27);
            this.txt_Nivel.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(662, 200);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 30);
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
            this.btn_Save.Location = new System.Drawing.Point(512, 200);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 30);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nivel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dgv_Roles);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(2, 272);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(792, 293);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Rol";
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
            this.txt_FiltrarRoles});
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
            this.btn_Refrescar.Text = "toolStripButton1";
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
            this.btn_Modificar.Text = "btn_Modificar";
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
            // txt_FiltrarRoles
            // 
            this.txt_FiltrarRoles.Name = "txt_FiltrarRoles";
            this.txt_FiltrarRoles.Size = new System.Drawing.Size(76, 27);
            this.txt_FiltrarRoles.TextChanged += new System.EventHandler(this.txt_FiltrarRoles_TextChanged);
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.AllowUserToAddRows = false;
            this.dgv_Roles.AllowUserToDeleteRows = false;
            this.dgv_Roles.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Roles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Roles.Location = new System.Drawing.Point(4, 51);
            this.dgv_Roles.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Roles.MultiSelect = false;
            this.dgv_Roles.Name = "dgv_Roles";
            this.dgv_Roles.RowTemplate.Height = 24;
            this.dgv_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Roles.Size = new System.Drawing.Size(781, 237);
            this.dgv_Roles.TabIndex = 0;
            this.dgv_Roles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Roles_CellDoubleClick);
            // 
            // txt_IdRol
            // 
            this.txt_IdRol.Location = new System.Drawing.Point(164, 35);
            this.txt_IdRol.Name = "txt_IdRol";
            this.txt_IdRol.Size = new System.Drawing.Size(139, 23);
            this.txt_IdRol.TabIndex = 29;
            // 
            // FRM_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Roles";
            this.Text = "FRM_Roles";
            this.Load += new System.EventHandler(this.FRM_Roles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.TextBox txt_Nivel;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_IdEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_FiltrarRoles;
        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.TextBox txt_IdRol;
    }
}