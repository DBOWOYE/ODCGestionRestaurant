namespace GestionRestaurant.Views
{
    partial class FrmPwdUpdate
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
            this.BtnFermerPwd = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEnregistrerPwd = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.panel1.Size = new System.Drawing.Size(702, 60);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modifier le mot de passe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnFermerPwd
            // 
            this.BtnFermerPwd.BorderColor = System.Drawing.Color.White;
            this.BtnFermerPwd.BorderRadius = 10;
            this.BtnFermerPwd.BorderThickness = 2;
            this.BtnFermerPwd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFermerPwd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFermerPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFermerPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFermerPwd.FillColor = System.Drawing.Color.Maroon;
            this.BtnFermerPwd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFermerPwd.ForeColor = System.Drawing.Color.White;
            this.BtnFermerPwd.Location = new System.Drawing.Point(218, 188);
            this.BtnFermerPwd.Name = "BtnFermerPwd";
            this.BtnFermerPwd.Size = new System.Drawing.Size(180, 45);
            this.BtnFermerPwd.TabIndex = 7;
            this.BtnFermerPwd.Text = "Fermer";
            this.BtnFermerPwd.Click += new System.EventHandler(this.BtnFermerPwd_Click);
            // 
            // BtnEnregistrerPwd
            // 
            this.BtnEnregistrerPwd.BorderColor = System.Drawing.Color.White;
            this.BtnEnregistrerPwd.BorderRadius = 10;
            this.BtnEnregistrerPwd.BorderThickness = 2;
            this.BtnEnregistrerPwd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnregistrerPwd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnregistrerPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEnregistrerPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEnregistrerPwd.FillColor = System.Drawing.Color.Teal;
            this.BtnEnregistrerPwd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEnregistrerPwd.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrerPwd.Location = new System.Drawing.Point(404, 188);
            this.BtnEnregistrerPwd.Name = "BtnEnregistrerPwd";
            this.BtnEnregistrerPwd.Size = new System.Drawing.Size(180, 45);
            this.BtnEnregistrerPwd.TabIndex = 8;
            this.BtnEnregistrerPwd.Text = "Enregistrer";
            this.BtnEnregistrerPwd.Click += new System.EventHandler(this.BtnEnregistrerPwd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe :";
            // 
            // tbPass
            // 
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.DefaultText = "";
            this.tbPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPass.Location = new System.Drawing.Point(232, 100);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '\0';
            this.tbPass.PlaceholderText = "";
            this.tbPass.SelectedText = "";
            this.tbPass.Size = new System.Drawing.Size(364, 41);
            this.tbPass.TabIndex = 6;
            // 
            // FrmPwdUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnFermerPwd);
            this.Controls.Add(this.BtnEnregistrerPwd);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPwdUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPwdUpdate";
            this.Load += new System.EventHandler(this.FrmPwdUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnFermerPwd;
        public Guna.UI2.WinForms.Guna2Button BtnEnregistrerPwd;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox tbPass;
    }
}