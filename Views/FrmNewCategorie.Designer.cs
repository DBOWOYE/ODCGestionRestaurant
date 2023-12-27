namespace GestionRestaurant.Views
{
    partial class FrmNewCategorie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCategorieNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnEnregistrerCategorie = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFermerUpdatePassword = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nouvelle Catégorie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catégorie :";
            // 
            // tbCategorieNom
            // 
            this.tbCategorieNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCategorieNom.DefaultText = "";
            this.tbCategorieNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCategorieNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCategorieNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCategorieNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCategorieNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCategorieNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCategorieNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCategorieNom.Location = new System.Drawing.Point(220, 107);
            this.tbCategorieNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategorieNom.Name = "tbCategorieNom";
            this.tbCategorieNom.PasswordChar = '\0';
            this.tbCategorieNom.PlaceholderText = "";
            this.tbCategorieNom.SelectedText = "";
            this.tbCategorieNom.Size = new System.Drawing.Size(364, 41);
            this.tbCategorieNom.TabIndex = 2;
            // 
            // BtnEnregistrerCategorie
            // 
            this.BtnEnregistrerCategorie.BorderColor = System.Drawing.Color.White;
            this.BtnEnregistrerCategorie.BorderRadius = 10;
            this.BtnEnregistrerCategorie.BorderThickness = 2;
            this.BtnEnregistrerCategorie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnregistrerCategorie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnregistrerCategorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEnregistrerCategorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEnregistrerCategorie.FillColor = System.Drawing.Color.Teal;
            this.BtnEnregistrerCategorie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEnregistrerCategorie.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrerCategorie.Location = new System.Drawing.Point(362, 182);
            this.BtnEnregistrerCategorie.Name = "BtnEnregistrerCategorie";
            this.BtnEnregistrerCategorie.Size = new System.Drawing.Size(180, 45);
            this.BtnEnregistrerCategorie.TabIndex = 3;
            this.BtnEnregistrerCategorie.Text = "Enregistrer";
            this.BtnEnregistrerCategorie.Click += new System.EventHandler(this.BtnEnregistrerCategorie_Click);
            // 
            // BtnFermerUpdatePassword
            // 
            this.BtnFermerUpdatePassword.BorderColor = System.Drawing.Color.White;
            this.BtnFermerUpdatePassword.BorderRadius = 10;
            this.BtnFermerUpdatePassword.BorderThickness = 2;
            this.BtnFermerUpdatePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFermerUpdatePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFermerUpdatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFermerUpdatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFermerUpdatePassword.FillColor = System.Drawing.Color.Maroon;
            this.BtnFermerUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFermerUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.BtnFermerUpdatePassword.Location = new System.Drawing.Point(176, 182);
            this.BtnFermerUpdatePassword.Name = "BtnFermerUpdatePassword";
            this.BtnFermerUpdatePassword.Size = new System.Drawing.Size(180, 45);
            this.BtnFermerUpdatePassword.TabIndex = 3;
            this.BtnFermerUpdatePassword.Text = "Fermer";
            this.BtnFermerUpdatePassword.Click += new System.EventHandler(this.BtnFermerCategorie_Click);
            // 
            // FrmNewCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 256);
            this.Controls.Add(this.BtnFermerUpdatePassword);
            this.Controls.Add(this.BtnEnregistrerCategorie);
            this.Controls.Add(this.tbCategorieNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNewCategorie";
            this.Load += new System.EventHandler(this.FrmNewCategorie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnFermerUpdatePassword;
        public Guna.UI2.WinForms.Guna2TextBox tbCategorieNom;
        public Guna.UI2.WinForms.Guna2Button BtnEnregistrerCategorie;
    }
}