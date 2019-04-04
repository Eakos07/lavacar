namespace FRM_Login
{
    partial class FRM_Ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Ingreso));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtContrase = new System.Windows.Forms.TextBox();
            this.lLOlvido = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.TituloLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.White;
            this.PanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo.BackgroundImage")));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(280, 330);
            this.PanelLogo.TabIndex = 1;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(357, 86);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(265, 25);
            this.txtUsuarioLogin.TabIndex = 1;
            this.txtUsuarioLogin.Text = "USUARIO";
            this.txtUsuarioLogin.Enter += new System.EventHandler(this.txtUsuarioLogin_Enter);
            this.txtUsuarioLogin.Leave += new System.EventHandler(this.txtUsuarioLogin_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 359;
            this.lineShape1.X2 = 623;
            this.lineShape1.Y1 = 133;
            this.lineShape1.Y2 = 133;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(795, 330);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 357;
            this.lineShape2.X2 = 621;
            this.lineShape2.Y1 = 198;
            this.lineShape2.Y2 = 198;
            // 
            // txtContrase
            // 
            this.txtContrase.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtContrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrase.ForeColor = System.Drawing.Color.Black;
            this.txtContrase.Location = new System.Drawing.Point(359, 170);
            this.txtContrase.Name = "txtContrase";
            this.txtContrase.Size = new System.Drawing.Size(265, 25);
            this.txtContrase.TabIndex = 2;
            this.txtContrase.Text = "CONTRASEÑA";
            this.txtContrase.Enter += new System.EventHandler(this.txtContrase_Enter);
            this.txtContrase.Leave += new System.EventHandler(this.txtContrase_Leave);
            // 
            // lLOlvido
            // 
            this.lLOlvido.AutoSize = true;
            this.lLOlvido.Location = new System.Drawing.Point(356, 218);
            this.lLOlvido.Name = "lLOlvido";
            this.lLOlvido.Size = new System.Drawing.Size(154, 17);
            this.lLOlvido.TabIndex = 3;
            this.lLOlvido.TabStop = true;
            this.lLOlvido.Text = "¿Olvidó la contraseña?";
            this.lLOlvido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Aqua;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(359, 264);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(272, 40);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(747, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(773, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(19, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // TituloLogin
            // 
            this.TituloLogin.AutoSize = true;
            this.TituloLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLogin.ForeColor = System.Drawing.Color.Black;
            this.TituloLogin.Location = new System.Drawing.Point(425, 9);
            this.TituloLogin.Name = "TituloLogin";
            this.TituloLogin.Size = new System.Drawing.Size(113, 37);
            this.TituloLogin.TabIndex = 11;
            this.TituloLogin.Text = "LOGIN";
            // 
            // FRM_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(795, 330);
            this.Controls.Add(this.TituloLogin);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lLOlvido);
            this.Controls.Add(this.txtContrase);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ingreso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Ingreso_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtContrase;
        private System.Windows.Forms.LinkLabel lLOlvido;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label TituloLogin;
    }
}