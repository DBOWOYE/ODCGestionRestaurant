namespace GestionRestaurant.Views
{
    partial class FrmAddProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduit));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrix = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.btnImporterImage = new Guna.UI2.WinForms.Guna2Button();
            this.tbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1062, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOUVEAU PRODUIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnFermer.Location = new System.Drawing.Point(229, 383);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(180, 45);
            this.btnFermer.TabIndex = 8;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(431, 383);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(180, 45);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prix :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrix
            // 
            this.tbPrix.BorderColor = System.Drawing.Color.Teal;
            this.tbPrix.BorderRadius = 7;
            this.tbPrix.BorderThickness = 2;
            this.tbPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrix.DefaultText = "";
            this.tbPrix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPrix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrix.Location = new System.Drawing.Point(229, 102);
            this.tbPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.PasswordChar = '\0';
            this.tbPrix.PlaceholderText = "";
            this.tbPrix.SelectedText = "";
            this.tbPrix.Size = new System.Drawing.Size(382, 40);
            this.tbPrix.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPrix.TabIndex = 2;
            this.tbPrix.TextChanged += new System.EventHandler(this.tbPrix_TextChanged);
            this.tbPrix.Leave += new System.EventHandler(this.tbPrix_Leave);
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
            this.label2.Text = "Désignation :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.btnImporterImage);
            this.panel1.Controls.Add(this.tbImage);
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Controls.Add(this.btnEnregistrer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboCategorie);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPrix);
            this.panel1.Controls.Add(this.tbNom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(87, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 496);
            this.panel1.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(228, 216);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(382, 96);
            this.tbDescription.TabIndex = 12;
            this.tbDescription.Text = "";
            // 
            // btnImporterImage
            // 
            this.btnImporterImage.BorderColor = System.Drawing.Color.White;
            this.btnImporterImage.BorderRadius = 10;
            this.btnImporterImage.BorderThickness = 3;
            this.btnImporterImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImporterImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImporterImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImporterImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImporterImage.FillColor = System.Drawing.Color.Transparent;
            this.btnImporterImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImporterImage.ForeColor = System.Drawing.Color.White;
            this.btnImporterImage.Location = new System.Drawing.Point(729, 228);
            this.btnImporterImage.Name = "btnImporterImage";
            this.btnImporterImage.Size = new System.Drawing.Size(170, 44);
            this.btnImporterImage.TabIndex = 11;
            this.btnImporterImage.Text = "Importer image";
            this.btnImporterImage.Click += new System.EventHandler(this.btnImporterImage_Click);
            // 
            // tbImage
            // 
            this.tbImage.BackColor = System.Drawing.Color.Transparent;
            this.tbImage.BorderRadius = 10;
            this.tbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbImage.Image = ((System.Drawing.Image)(resources.GetObject("tbImage.Image")));
            this.tbImage.ImageRotate = 0F;
            this.tbImage.Location = new System.Drawing.Point(729, 64);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(170, 146);
            this.tbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tbImage.TabIndex = 10;
            this.tbImage.TabStop = false;
            this.tbImage.UseTransparentBackground = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Catégorie :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCategorie
            // 
            this.comboCategorie.BackColor = System.Drawing.Color.Transparent;
            this.comboCategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCategorie.ItemHeight = 30;
            this.comboCategorie.Location = new System.Drawing.Point(228, 153);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(382, 36);
            this.comboCategorie.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboCategorie.TabIndex = 5;
            this.comboCategorie.Leave += new System.EventHandler(this.comboCategorie_Leave);
            // 
            // FrmAddProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProduit";
            this.Load += new System.EventHandler(this.FrmAddProduit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnFermer;
        public Guna.UI2.WinForms.Guna2Button btnEnregistrer;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox tbPrix;
        public Guna.UI2.WinForms.Guna2TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox tbImage;
        private Guna.UI2.WinForms.Guna2Button btnImporterImage;
        public System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2ComboBox comboCategorie;
    }
}