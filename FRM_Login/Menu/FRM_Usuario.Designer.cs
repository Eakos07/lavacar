namespace FRM_Login.Menu
{
    partial class FRM_Usuario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Filtrar = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Usuario);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(9, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(788, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla Usuario";
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.AllowUserToAddRows = false;
            this.dgv_Usuario.AllowUserToDeleteRows = false;
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Usuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Usuario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Usuario.Location = new System.Drawing.Point(5, 50);
            this.dgv_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Usuario.MultiSelect = false;
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.RowTemplate.Height = 24;
            this.dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuario.Size = new System.Drawing.Size(779, 209);
            this.dgv_Usuario.TabIndex = 4;
            this.dgv_Usuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuario_CellDoubleClick);
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
            this.txt_Filtrar});
            this.toolStrip1.Location = new System.Drawing.Point(2, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(23, 22);
            this.btn_Refrescar.Text = "toolStripButton1";
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(23, 22);
            this.btn_Modificar.Text = "toolStripButton2";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel2.Text = "Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel4.Text = "Buscar";
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(76, 25);
            this.txt_Filtrar.TextChanged += new System.EventHandler(this.txt_Filtrar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Usuario);
            this.groupBox1.Controls.Add(this.cmb_Rol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.txt_Contraseña);
            this.groupBox1.Controls.Add(this.cmb_Estado);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(204, 45);
            this.txt_Usuario.MaxLength = 20;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(159, 23);
            this.txt_Usuario.TabIndex = 0;
            this.txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Usuario_KeyPress);
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(203, 158);
            this.cmb_Rol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(159, 25);
            this.cmb_Rol.TabIndex = 2;
            this.cmb_Rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Rol_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Id Rol";
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
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Aqua;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(502, 237);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 30);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(204, 101);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Contraseña.MaxLength = 50;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(158, 23);
            this.txt_Contraseña.TabIndex = 1;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(204, 208);
            this.cmb_Estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(159, 25);
            this.cmb_Estado.TabIndex = 3;
            this.cmb_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Estado_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Id Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Estado:";
            // 
            // FRM_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_Usuario";
            this.Text = "FRM_Usuario";
            this.Load += new System.EventHandler(this.FRM_Usuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_Filtrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Usuario;
    }
}