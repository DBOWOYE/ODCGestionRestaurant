namespace GestionRestaurant.Views
{
    partial class FrmAddIngredient
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
            this.BtnFermer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIngredient = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFermer
            // 
            this.BtnFermer.BorderColor = System.Drawing.Color.White;
            this.BtnFermer.BorderRadius = 10;
            this.BtnFermer.BorderThickness = 2;
            this.BtnFermer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFermer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFermer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFermer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFermer.FillColor = System.Drawing.Color.Maroon;
            this.BtnFermer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFermer.ForeColor = System.Drawing.Color.White;
            this.BtnFermer.Location = new System.Drawing.Point(197, 172);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(180, 45);
            this.BtnFermer.TabIndex = 7;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.BorderColor = System.Drawing.Color.White;
            this.BtnEnregistrer.BorderRadius = 10;
            this.BtnEnregistrer.BorderThickness = 2;
            this.BtnEnregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEnregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEnregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEnregistrer.FillColor = System.Drawing.Color.Teal;
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer.Location = new System.Drawing.Point(383, 172);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(180, 45);
            this.BtnEnregistrer.TabIndex = 8;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 60);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nouvel Ingrédient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbIngredient
            // 
            this.tbIngredient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIngredient.DefaultText = "";
            this.tbIngredient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIngredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIngredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIngredient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIngredient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIngredient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIngredient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIngredient.Location = new System.Drawing.Point(241, 97);
            this.tbIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIngredient.Name = "tbIngredient";
            this.tbIngredient.PasswordChar = '\0';
            this.tbIngredient.PlaceholderText = "";
            this.tbIngredient.SelectedText = "";
            this.tbIngredient.Size = new System.Drawing.Size(364, 41);
            this.tbIngredient.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrédient :";
            // 
            // FrmAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 251);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIngredient);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddIngredient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnFermer;
        public Guna.UI2.WinForms.Guna2Button BtnEnregistrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox tbIngredient;
        private System.Windows.Forms.Label label2;
    }
}