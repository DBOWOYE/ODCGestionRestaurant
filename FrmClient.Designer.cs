namespace GestionRestaurant
{
    partial class FrmClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClient));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewClient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbRechercheClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddClient = new System.Windows.Forms.PictureBox();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1779, 97);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(16, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nos Clients";
            // 
            // DataGridViewClient
            // 
            this.DataGridViewClient.AllowUserToAddRows = false;
            this.DataGridViewClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewClient.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewClient.ColumnHeadersHeight = 45;
            this.DataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvNom,
            this.dgvPrenom,
            this.dgvtel,
            this.dgvadress,
            this.dgvGenre,
            this.dgvEdit,
            this.dgvDel});
            this.DataGridViewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewClient.Location = new System.Drawing.Point(24, 327);
            this.DataGridViewClient.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewClient.MinimumSize = new System.Drawing.Size(1000, 25);
            this.DataGridViewClient.Name = "DataGridViewClient";
            this.DataGridViewClient.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewClient.RowHeadersVisible = false;
            this.DataGridViewClient.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewClient.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewClient.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.DataGridViewClient.RowTemplate.Height = 40;
            this.DataGridViewClient.Size = new System.Drawing.Size(1700, 528);
            this.DataGridViewClient.TabIndex = 10;
            this.DataGridViewClient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.DataGridViewClient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewClient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewClient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewClient.ThemeStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridViewClient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewClient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.DataGridViewClient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewClient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewClient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewClient.ThemeStyle.HeaderStyle.Height = 45;
            this.DataGridViewClient.ThemeStyle.ReadOnly = true;
            this.DataGridViewClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.DataGridViewClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewClient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClient.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridViewClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.DataGridViewClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewClient.VirtualMode = true;
            this.DataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClient_CellClick);
            // 
            // tbRechercheClient
            // 
            this.tbRechercheClient.BorderColor = System.Drawing.Color.Teal;
            this.tbRechercheClient.BorderRadius = 7;
            this.tbRechercheClient.BorderThickness = 2;
            this.tbRechercheClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRechercheClient.DefaultText = "";
            this.tbRechercheClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRechercheClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRechercheClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercheClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercheClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercheClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRechercheClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercheClient.IconRight = ((System.Drawing.Image)(resources.GetObject("tbRechercheClient.IconRight")));
            this.tbRechercheClient.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbRechercheClient.Location = new System.Drawing.Point(767, 232);
            this.tbRechercheClient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbRechercheClient.Name = "tbRechercheClient";
            this.tbRechercheClient.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tbRechercheClient.PasswordChar = '\0';
            this.tbRechercheClient.PlaceholderText = "";
            this.tbRechercheClient.SelectedText = "";
            this.tbRechercheClient.Size = new System.Drawing.Size(400, 44);
            this.tbRechercheClient.TabIndex = 8;
            this.tbRechercheClient.TextChanged += new System.EventHandler(this.tbRechercheClient_TextChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.Location = new System.Drawing.Point(19, 117);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddClient.Size = new System.Drawing.Size(63, 64);
            this.btnAddClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.TabStop = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
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
            this.dgvid.Width = 50;
            // 
            // dgvNom
            // 
            this.dgvNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNom.FillWeight = 80F;
            this.dgvNom.HeaderText = "Nom";
            this.dgvNom.MinimumWidth = 8;
            this.dgvNom.Name = "dgvNom";
            this.dgvNom.ReadOnly = true;
            // 
            // dgvPrenom
            // 
            this.dgvPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPrenom.FillWeight = 80F;
            this.dgvPrenom.HeaderText = "Prénom";
            this.dgvPrenom.MinimumWidth = 8;
            this.dgvPrenom.Name = "dgvPrenom";
            this.dgvPrenom.ReadOnly = true;
            // 
            // dgvtel
            // 
            this.dgvtel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtel.FillWeight = 80F;
            this.dgvtel.HeaderText = "Téléphone";
            this.dgvtel.MinimumWidth = 8;
            this.dgvtel.Name = "dgvtel";
            this.dgvtel.ReadOnly = true;
            // 
            // dgvadress
            // 
            this.dgvadress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvadress.HeaderText = "Adresse";
            this.dgvadress.MinimumWidth = 8;
            this.dgvadress.Name = "dgvadress";
            this.dgvadress.ReadOnly = true;
            // 
            // dgvGenre
            // 
            this.dgvGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGenre.FillWeight = 70F;
            this.dgvGenre.HeaderText = "Genre";
            this.dgvGenre.MinimumWidth = 8;
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.ReadOnly = true;
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
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1779, 908);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewClient);
            this.Controls.Add(this.tbRechercheClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClient";
            this.Text = "FrmClient";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridViewClient;
        private Guna.UI2.WinForms.Guna2TextBox tbRechercheClient;
        private System.Windows.Forms.PictureBox btnAddClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvadress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenre;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
    }
}