namespace GestionRestaurant
{
    partial class FrmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddTable = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewCategorie = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbRechercheTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLibererTable = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 97);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Tables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnAddTable
            // 
            this.BtnAddTable.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddTable.Image")));
            this.BtnAddTable.Location = new System.Drawing.Point(25, 119);
            this.BtnAddTable.Name = "BtnAddTable";
            this.BtnAddTable.Size = new System.Drawing.Size(67, 39);
            this.BtnAddTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddTable.TabIndex = 16;
            this.BtnAddTable.TabStop = false;
            this.BtnAddTable.Click += new System.EventHandler(this.BtnAddTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(29, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nos Tables";
            // 
            // DataGridViewCategorie
            // 
            this.DataGridViewCategorie.AllowUserToAddRows = false;
            this.DataGridViewCategorie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewCategorie.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCategorie.ColumnHeadersHeight = 45;
            this.DataGridViewCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvNom,
            this.dgvPlaces,
            this.dgvDispo,
            this.dgvEdit,
            this.dgvDel});
            this.DataGridViewCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCategorie.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewCategorie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCategorie.Location = new System.Drawing.Point(25, 246);
            this.DataGridViewCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewCategorie.Name = "DataGridViewCategorie";
            this.DataGridViewCategorie.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewCategorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewCategorie.RowHeadersVisible = false;
            this.DataGridViewCategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewCategorie.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewCategorie.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.DataGridViewCategorie.RowTemplate.Height = 35;
            this.DataGridViewCategorie.Size = new System.Drawing.Size(929, 744);
            this.DataGridViewCategorie.TabIndex = 14;
            this.DataGridViewCategorie.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.DataGridViewCategorie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewCategorie.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewCategorie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCategorie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewCategorie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCategorie.ThemeStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridViewCategorie.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCategorie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.DataGridViewCategorie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCategorie.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCategorie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewCategorie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewCategorie.ThemeStyle.HeaderStyle.Height = 45;
            this.DataGridViewCategorie.ThemeStyle.ReadOnly = true;
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.DataGridViewCategorie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewCategorie.VirtualMode = true;
            this.DataGridViewCategorie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCategorie_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.FillWeight = 50F;
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 8;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvNom
            // 
            this.dgvNom.HeaderText = "Nom de la Table";
            this.dgvNom.MinimumWidth = 8;
            this.dgvNom.Name = "dgvNom";
            this.dgvNom.ReadOnly = true;
            // 
            // dgvPlaces
            // 
            this.dgvPlaces.HeaderText = "Places";
            this.dgvPlaces.MinimumWidth = 8;
            this.dgvPlaces.Name = "dgvPlaces";
            this.dgvPlaces.ReadOnly = true;
            // 
            // dgvDispo
            // 
            this.dgvDispo.HeaderText = "Disponible";
            this.dgvDispo.MinimumWidth = 8;
            this.dgvDispo.Name = "dgvDispo";
            this.dgvDispo.ReadOnly = true;
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
            // tbRechercheTable
            // 
            this.tbRechercheTable.BorderColor = System.Drawing.Color.Teal;
            this.tbRechercheTable.BorderRadius = 7;
            this.tbRechercheTable.BorderThickness = 2;
            this.tbRechercheTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRechercheTable.DefaultText = "";
            this.tbRechercheTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRechercheTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRechercheTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercheTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercheTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercheTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRechercheTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercheTable.IconRight = ((System.Drawing.Image)(resources.GetObject("tbRechercheTable.IconRight")));
            this.tbRechercheTable.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbRechercheTable.Location = new System.Drawing.Point(495, 192);
            this.tbRechercheTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbRechercheTable.Name = "tbRechercheTable";
            this.tbRechercheTable.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tbRechercheTable.PasswordChar = '\0';
            this.tbRechercheTable.PlaceholderText = "";
            this.tbRechercheTable.SelectedText = "";
            this.tbRechercheTable.Size = new System.Drawing.Size(418, 44);
            this.tbRechercheTable.TabIndex = 12;
            this.tbRechercheTable.TextChanged += new System.EventHandler(this.tbRechercheTable_TextChanged);
            // 
            // BtnLibererTable
            // 
            this.BtnLibererTable.BackColor = System.Drawing.Color.Transparent;
            this.BtnLibererTable.BorderColor = System.Drawing.Color.White;
            this.BtnLibererTable.BorderRadius = 10;
            this.BtnLibererTable.BorderThickness = 2;
            this.BtnLibererTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLibererTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLibererTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLibererTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLibererTable.FillColor = System.Drawing.Color.Maroon;
            this.BtnLibererTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLibererTable.ForeColor = System.Drawing.Color.White;
            this.BtnLibererTable.Location = new System.Drawing.Point(929, 194);
            this.BtnLibererTable.Name = "BtnLibererTable";
            this.BtnLibererTable.Size = new System.Drawing.Size(180, 44);
            this.BtnLibererTable.TabIndex = 17;
            this.BtnLibererTable.Text = "Libérer la table";
            this.BtnLibererTable.Click += new System.EventHandler(this.BtnLibererTable_Click);
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1343, 961);
            this.Controls.Add(this.BtnLibererTable);
            this.Controls.Add(this.BtnAddTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewCategorie);
            this.Controls.Add(this.tbRechercheTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTable";
            this.Text = "FrmTable";
            this.Load += new System.EventHandler(this.FrmTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnAddTable;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridViewCategorie;
        private Guna.UI2.WinForms.Guna2TextBox tbRechercheTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDispo;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2Button BtnLibererTable;
    }
}