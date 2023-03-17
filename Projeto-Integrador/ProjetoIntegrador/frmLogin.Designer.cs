namespace ProjetoIntegrador
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.btoEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboIDdepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // btoEntrar
            // 
            this.btoEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoEntrar.Location = new System.Drawing.Point(259, 194);
            this.btoEntrar.Name = "btoEntrar";
            this.btoEntrar.Size = new System.Drawing.Size(75, 29);
            this.btoEntrar.TabIndex = 1;
            this.btoEntrar.Text = "&Ok";
            this.btoEntrar.UseVisualStyleBackColor = true;
            this.btoEntrar.Click += new System.EventHandler(this.btoEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(259, 96);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(168, 29);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // btoLimpar
            // 
            this.btoLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoLimpar.Location = new System.Drawing.Point(352, 194);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 29);
            this.btoLimpar.TabIndex = 1;
            this.btoLimpar.Text = "&Cancelar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(261, 38);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(166, 29);
            this.txtLogin.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.cboDepartamento);
            this.groupBox1.Controls.Add(this.cboIDdepartamento);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btoLimpar);
            this.groupBox1.Controls.Add(this.btoEntrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.Enabled = false;
            this.cboDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(306, 150);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 29);
            this.cboDepartamento.TabIndex = 3;
            // 
            // cboIDdepartamento
            // 
            this.cboIDdepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDdepartamento.FormattingEnabled = true;
            this.cboIDdepartamento.Location = new System.Drawing.Point(259, 150);
            this.cboIDdepartamento.Name = "cboIDdepartamento";
            this.cboIDdepartamento.Size = new System.Drawing.Size(41, 29);
            this.cboIDdepartamento.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(306, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(259, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBoxRestaurar);
            this.panel1.Controls.Add(this.pictureBoxMinimizar);
            this.panel1.Controls.Add(this.pictureBoxMaximizar);
            this.panel1.Controls.Add(this.pictureBoxFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 35);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxRestaurar
            // 
            this.pictureBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestaurar.Image")));
            this.pictureBoxRestaurar.Location = new System.Drawing.Point(447, 7);
            this.pictureBoxRestaurar.Name = "pictureBoxRestaurar";
            this.pictureBoxRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestaurar.TabIndex = 0;
            this.pictureBoxRestaurar.TabStop = false;
            this.pictureBoxRestaurar.Visible = false;
            this.pictureBoxRestaurar.Click += new System.EventHandler(this.pictureBoxRestaurar_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(416, 7);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 0;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxMaximizar
            // 
            this.pictureBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaximizar.Image")));
            this.pictureBoxMaximizar.Location = new System.Drawing.Point(447, 7);
            this.pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            this.pictureBoxMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximizar.TabIndex = 0;
            this.pictureBoxMaximizar.TabStop = false;
            this.pictureBoxMaximizar.Click += new System.EventHandler(this.pictureBoxMaximizar_Click);
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFechar.Image")));
            this.pictureBoxFechar.Location = new System.Drawing.Point(478, 7);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 0;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btoEntrar;
        private TextBox txtSenha;
        private Label label2;
        private Button btoLimpar;
        private TextBox txtLogin;
        private GroupBox groupBox1;
        private ComboBox cboDepartamento;
        private ComboBox cboIDdepartamento;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBoxRestaurar;
        private PictureBox pictureBoxMinimizar;
        private PictureBox pictureBoxMaximizar;
        private PictureBox pictureBoxFechar;
    }
}