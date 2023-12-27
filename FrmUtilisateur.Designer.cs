namespace GestionRestaurant
{
    partial class FrmUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtilisateur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbRechercheUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvActif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvActive = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPasswordReinitialise = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbRechercheUser
            // 
            this.tbRechercheUser.BorderColor = System.Drawing.Color.Teal;
            this.tbRechercheUser.BorderRadius = 7;
            this.tbRechercheUser.BorderThickness = 2;
            this.tbRechercheUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRechercheUser.DefaultText = "";
            this.tbRechercheUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRechercheUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRechercheUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercheUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercheUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercheUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRechercheUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercheUser.IconRight = ((System.Drawing.Image)(resources.GetObject("tbRechercheUser.IconRight")));
            this.tbRechercheUser.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbRechercheUser.Location = new System.Drawing.Point(775, 197);
            this.tbRechercheUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbRechercheUser.Name = "tbRechercheUser";
            this.tbRechercheUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tbRechercheUser.PasswordChar = '\0';
            this.tbRechercheUser.PlaceholderText = "";
            this.tbRechercheUser.SelectedText = "";
            this.tbRechercheUser.Size = new System.Drawing.Size(400, 44);
            this.tbRechercheUser.TabIndex = 2;
            this.tbRechercheUser.TextChanged += new System.EventHandler(this.tbRechercheUser_TextChanged);
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.AllowUserToAddRows = false;
            this.DataGridViewUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewUser.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewUser.ColumnHeadersHeight = 45;
            this.DataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvNom,
            this.dgvtel,
            this.dgvadress,
            this.dgvpass,
            this.dgvrole,
            this.dgvActif,
            this.dgvEdit,
            this.dgvDel,
            this.dgvActive});
            this.DataGridViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewUser.Location = new System.Drawing.Point(28, 264);
            this.DataGridViewUser.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewUser.RowHeadersVisible = false;
            this.DataGridViewUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewUser.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.DataGridViewUser.RowTemplate.Height = 35;
            this.DataGridViewUser.Size = new System.Drawing.Size(1450, 677);
            this.DataGridViewUser.TabIndex = 5;
            this.DataGridViewUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.DataGridViewUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewUser.ThemeStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridViewUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.DataGridViewUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUser.ThemeStyle.HeaderStyle.Height = 45;
            this.DataGridViewUser.ThemeStyle.ReadOnly = true;
            this.DataGridViewUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.DataGridViewUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewUser.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridViewUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.DataGridViewUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewUser.VirtualMode = true;
            this.DataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUser_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvid.FillWeight = 50F;
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 8;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            this.dgvid.Width = 150;
            // 
            // dgvNom
            // 
            this.dgvNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvNom.FillWeight = 150F;
            this.dgvNom.HeaderText = "Nom";
            this.dgvNom.MinimumWidth = 8;
            this.dgvNom.Name = "dgvNom";
            this.dgvNom.ReadOnly = true;
            this.dgvNom.Width = 150;
            // 
            // dgvtel
            // 
            this.dgvtel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvtel.HeaderText = "Téléphone";
            this.dgvtel.MinimumWidth = 8;
            this.dgvtel.Name = "dgvtel";
            this.dgvtel.ReadOnly = true;
            this.dgvtel.Width = 150;
            // 
            // dgvadress
            // 
            this.dgvadress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvadress.FillWeight = 200F;
            this.dgvadress.HeaderText = "Adresse";
            this.dgvadress.MinimumWidth = 8;
            this.dgvadress.Name = "dgvadress";
            this.dgvadress.ReadOnly = true;
            this.dgvadress.Width = 200;
            // 
            // dgvpass
            // 
            this.dgvpass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvpass.HeaderText = "Password";
            this.dgvpass.MinimumWidth = 8;
            this.dgvpass.Name = "dgvpass";
            this.dgvpass.ReadOnly = true;
            this.dgvpass.Visible = false;
            this.dgvpass.Width = 200;
            // 
            // dgvrole
            // 
            this.dgvrole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvrole.FillWeight = 70F;
            this.dgvrole.HeaderText = "Role";
            this.dgvrole.MinimumWidth = 8;
            this.dgvrole.Name = "dgvrole";
            this.dgvrole.ReadOnly = true;
            this.dgvrole.Width = 150;
            // 
            // dgvActif
            // 
            this.dgvActif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvActif.HeaderText = "Est actif ?";
            this.dgvActif.MinimumWidth = 8;
            this.dgvActif.Name = "dgvActif";
            this.dgvActif.ReadOnly = true;
            this.dgvActif.Width = 150;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 25F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = ((System.Drawing.Image)(resources.GetObject("dgvEdit.Image")));
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 8;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Width = 25;
            // 
            // dgvDel
            // 
            this.dgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDel.FillWeight = 25F;
            this.dgvDel.HeaderText = "";
            this.dgvDel.Image = ((System.Drawing.Image)(resources.GetObject("dgvDel.Image")));
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 8;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDel.Width = 25;
            // 
            // dgvActive
            // 
            this.dgvActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvActive.FillWeight = 25F;
            this.dgvActive.HeaderText = "";
            this.dgvActive.Image = ((System.Drawing.Image)(resources.GetObject("dgvActive.Image")));
            this.dgvActive.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvActive.MinimumWidth = 8;
            this.dgvActive.Name = "dgvActive";
            this.dgvActive.ReadOnly = true;
            this.dgvActive.Width = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(18, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Liste des utilisateurs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 97);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Utilisateurs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPasswordReinitialise
            // 
            this.btnPasswordReinitialise.BorderRadius = 10;
            this.btnPasswordReinitialise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPasswordReinitialise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPasswordReinitialise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPasswordReinitialise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPasswordReinitialise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPasswordReinitialise.ForeColor = System.Drawing.Color.White;
            this.btnPasswordReinitialise.Location = new System.Drawing.Point(444, 205);
            this.btnPasswordReinitialise.Name = "btnPasswordReinitialise";
            this.btnPasswordReinitialise.Size = new System.Drawing.Size(303, 35);
            this.btnPasswordReinitialise.TabIndex = 8;
            this.btnPasswordReinitialise.Text = "Reinitialiser mot de passe";
            this.btnPasswordReinitialise.Click += new System.EventHandler(this.btnPasswordReinitialise_Click);
            // 
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1500, 1022);
            this.Controls.Add(this.btnPasswordReinitialise);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewUser);
            this.Controls.Add(this.tbRechercheUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUtilisateur";
            this.Text = "FrmUtilisateur";
            this.Load += new System.EventHandler(this.FrmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbRechercheUser;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridViewUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvadress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvActif;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private System.Windows.Forms.DataGridViewImageColumn dgvActive;
        private Guna.UI2.WinForms.Guna2Button btnPasswordReinitialise;
    }
}