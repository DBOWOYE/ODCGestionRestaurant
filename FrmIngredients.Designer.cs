namespace GestionRestaurant
{
    partial class FrmIngredients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngredients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewCategorie = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnAddIngredient = new System.Windows.Forms.PictureBox();
            this.tbRechercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 97);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Ingrédients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(28, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "Les Ingrédients";
            // 
            // DataGridViewCategorie
            // 
            this.DataGridViewCategorie.AllowUserToAddRows = false;
            this.DataGridViewCategorie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.DataGridViewCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewCategorie.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewCategorie.ColumnHeadersHeight = 45;
            this.DataGridViewCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvIngredient,
            this.dgvEdit,
            this.dgvDel});
            this.DataGridViewCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCategorie.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewCategorie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCategorie.Location = new System.Drawing.Point(36, 249);
            this.DataGridViewCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewCategorie.Name = "DataGridViewCategorie";
            this.DataGridViewCategorie.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewCategorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewCategorie.RowHeadersVisible = false;
            this.DataGridViewCategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewCategorie.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewCategorie.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.DataGridViewCategorie.RowTemplate.Height = 35;
            this.DataGridViewCategorie.Size = new System.Drawing.Size(929, 509);
            this.DataGridViewCategorie.TabIndex = 15;
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
            // dgvIngredient
            // 
            this.dgvIngredient.HeaderText = "Ingrédient";
            this.dgvIngredient.MinimumWidth = 8;
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.ReadOnly = true;
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
            // BtnAddIngredient
            // 
            this.BtnAddIngredient.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddIngredient.Image")));
            this.BtnAddIngredient.Location = new System.Drawing.Point(36, 127);
            this.BtnAddIngredient.Name = "BtnAddIngredient";
            this.BtnAddIngredient.Size = new System.Drawing.Size(67, 39);
            this.BtnAddIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddIngredient.TabIndex = 17;
            this.BtnAddIngredient.TabStop = false;
            this.BtnAddIngredient.Click += new System.EventHandler(this.BtnAddIngredient_Click);
            // 
            // tbRechercher
            // 
            this.tbRechercher.BorderColor = System.Drawing.Color.Teal;
            this.tbRechercher.BorderRadius = 7;
            this.tbRechercher.BorderThickness = 2;
            this.tbRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRechercher.DefaultText = "";
            this.tbRechercher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRechercher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRechercher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRechercher.IconRight = ((System.Drawing.Image)(resources.GetObject("tbRechercher.IconRight")));
            this.tbRechercher.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbRechercher.Location = new System.Drawing.Point(506, 184);
            this.tbRechercher.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbRechercher.Name = "tbRechercher";
            this.tbRechercher.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tbRechercher.PasswordChar = '\0';
            this.tbRechercher.PlaceholderText = "";
            this.tbRechercher.SelectedText = "";
            this.tbRechercher.Size = new System.Drawing.Size(459, 44);
            this.tbRechercher.TabIndex = 13;
            this.tbRechercher.TextChanged += new System.EventHandler(this.tbRechercher_TextChanged);
            // 
            // FrmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1710, 833);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewCategorie);
            this.Controls.Add(this.BtnAddIngredient);
            this.Controls.Add(this.tbRechercher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIngredients";
            this.Text = "FrmIngredients";
            this.Load += new System.EventHandler(this.FrmIngredients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridViewCategorie;
        private System.Windows.Forms.PictureBox BtnAddIngredient;
        private Guna.UI2.WinForms.Guna2TextBox tbRechercher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIngredient;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
    }
}