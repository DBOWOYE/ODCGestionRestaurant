namespace GestionRestaurant
{
    partial class FrmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFermer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Controls.Add(this.btnEnregistrer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboRole);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbAdress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbTel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(183, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 433);
            this.panel1.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.BorderColor = System.Drawing.Color.White;
            this.btnFermer.BorderRadius = 10;
            this.btnFermer.BorderThickness = 2;
            this.btnFermer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFermer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFermer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFermer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFermer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFermer.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(228, 353);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(180, 45);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BorderColor = System.Drawing.Color.White;
            this.btnEnregistrer.BorderRadius = 10;
            this.btnEnregistrer.BorderThickness = 2;
            this.btnEnregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnregistrer.FillColor = System.Drawing.Color.Teal;
            this.btnEnregistrer.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(430, 353);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(180, 45);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 40);
            this.label7.TabIndex = 3;
            this.label7.Text = "Role :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.Transparent;
            this.comboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboRole.ItemHeight = 30;
            this.comboRole.Location = new System.Drawing.Point(228, 215);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(382, 36);
            this.comboRole.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAdress
            // 
            this.tbAdress.BorderColor = System.Drawing.Color.Teal;
            this.tbAdress.BorderRadius = 7;
            this.tbAdress.BorderThickness = 2;
            this.tbAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdress.DefaultText = "";
            this.tbAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdress.Location = new System.Drawing.Point(229, 158);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.PasswordChar = '\0';
            this.tbAdress.PlaceholderText = "";
            this.tbAdress.SelectedText = "";
            this.tbAdress.Size = new System.Drawing.Size(382, 40);
            this.tbAdress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbAdress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTel
            // 
            this.tbTel.BorderColor = System.Drawing.Color.Teal;
            this.tbTel.BorderRadius = 7;
            this.tbTel.BorderThickness = 2;
            this.tbTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTel.DefaultText = "";
            this.tbTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTel.Location = new System.Drawing.Point(229, 103);
            this.tbTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTel.Name = "tbTel";
            this.tbTel.PasswordChar = '\0';
            this.tbTel.PlaceholderText = "";
            this.tbTel.SelectedText = "";
            this.tbTel.Size = new System.Drawing.Size(382, 40);
            this.tbTel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbTel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Téléphone :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNom
            // 
            this.tbNom.BorderColor = System.Drawing.Color.Teal;
            this.tbNom.BorderRadius = 7;
            this.tbNom.BorderThickness = 2;
            this.tbNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNom.DefaultText = "";
            this.tbNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNom.Location = new System.Drawing.Point(229, 48);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNom.Name = "tbNom";
            this.tbNom.PasswordChar = '\0';
            this.tbNom.PlaceholderText = "";
            this.tbNom.SelectedText = "";
            this.tbNom.Size = new System.Drawing.Size(382, 40);
            this.tbNom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(851, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOUVEL UTILISATEUR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 182);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(135, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FrmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(851, 524);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewUser";
            this.Load += new System.EventHandler(this.FrmAddNewUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnFermer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox tbNom;
        public Guna.UI2.WinForms.Guna2TextBox tbTel;
        public Guna.UI2.WinForms.Guna2TextBox tbAdress;
        public Guna.UI2.WinForms.Guna2ComboBox comboRole;
        public Guna.UI2.WinForms.Guna2Button btnEnregistrer;
    }
}