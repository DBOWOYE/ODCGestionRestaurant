namespace GestionRestaurant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdatePassword = new Guna.UI2.WinForms.Guna2Button();
            this.lbRole = new System.Windows.Forms.Label();
            this.SeDeconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClient = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnIngredient = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPlat = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReservation = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCommande = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCategorie = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnUpdatePassword);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Controls.Add(this.SeDeconnecter);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.BtnClient);
            this.panel1.Controls.Add(this.BtnTable);
            this.panel1.Controls.Add(this.btnIngredient);
            this.panel1.Controls.Add(this.BtnPlat);
            this.panel1.Controls.Add(this.BtnReservation);
            this.panel1.Controls.Add(this.BtnCommande);
            this.panel1.Controls.Add(this.BtnCategorie);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1077);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BorderRadius = 10;
            this.btnUpdatePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.Location = new System.Drawing.Point(18, 79);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(244, 45);
            this.btnUpdatePassword.TabIndex = 3;
            this.btnUpdatePassword.Text = "Modifier le mot de passe";
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.Silver;
            this.lbRole.Location = new System.Drawing.Point(48, 50);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(189, 26);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "label2";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeDeconnecter
            // 
            this.SeDeconnecter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SeDeconnecter.BorderRadius = 10;
            this.SeDeconnecter.BorderThickness = 3;
            this.SeDeconnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeDeconnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SeDeconnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SeDeconnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SeDeconnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SeDeconnecter.FillColor = System.Drawing.Color.White;
            this.SeDeconnecter.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeDeconnecter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SeDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("SeDeconnecter.Image")));
            this.SeDeconnecter.Location = new System.Drawing.Point(30, 974);
            this.SeDeconnecter.Name = "SeDeconnecter";
            this.SeDeconnecter.Padding = new System.Windows.Forms.Padding(10);
            this.SeDeconnecter.Size = new System.Drawing.Size(232, 66);
            this.SeDeconnecter.TabIndex = 2;
            this.SeDeconnecter.Text = "Se déconnecter";
            this.SeDeconnecter.Click += new System.EventHandler(this.SeDeconnecter_Click);
            // 
            // lbUser
            // 
            this.lbUser.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUser.Location = new System.Drawing.Point(46, 16);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(197, 34);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "label1";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUser
            // 
            this.btnUser.BorderRadius = 10;
            this.btnUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUser.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUser.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUser.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.CustomizableEdges.BottomRight = false;
            this.btnUser.CustomizableEdges.TopRight = false;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Montserrat SemiBold", 11F);
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUser.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.Location = new System.Drawing.Point(18, 824);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(342, 68);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Utilisateurs";
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.TextOffset = new System.Drawing.Point(10, 0);
            this.btnUser.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnUser.Click += new System.EventHandler(this.onClick_btnUser);
            // 
            // BtnClient
            // 
            this.BtnClient.BorderRadius = 10;
            this.BtnClient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnClient.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnClient.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnClient.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnClient.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClient.CustomizableEdges.BottomRight = false;
            this.BtnClient.CustomizableEdges.TopRight = false;
            this.BtnClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClient.FillColor = System.Drawing.Color.Transparent;
            this.BtnClient.Font = new System.Drawing.Font("Montserrat SemiBold", 11F);
            this.BtnClient.ForeColor = System.Drawing.Color.Black;
            this.BtnClient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClient.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnClient.Image = ((System.Drawing.Image)(resources.GetObject("BtnClient.Image")));
            this.BtnClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClient.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnClient.Location = new System.Drawing.Point(18, 750);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(336, 68);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Clients";
            this.BtnClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClient.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnClient.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnTable
            // 
            this.BtnTable.BorderRadius = 10;
            this.BtnTable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnTable.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnTable.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnTable.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTable.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnTable.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTable.CustomizableEdges.BottomRight = false;
            this.BtnTable.CustomizableEdges.TopRight = false;
            this.BtnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTable.FillColor = System.Drawing.Color.Transparent;
            this.BtnTable.Font = new System.Drawing.Font("Montserrat SemiBold", 11F);
            this.BtnTable.ForeColor = System.Drawing.Color.Black;
            this.BtnTable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnTable.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTable.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnTable.Image = ((System.Drawing.Image)(resources.GetObject("BtnTable.Image")));
            this.BtnTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTable.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnTable.Location = new System.Drawing.Point(18, 676);
            this.BtnTable.Name = "BtnTable";
            this.BtnTable.Size = new System.Drawing.Size(336, 68);
            this.BtnTable.TabIndex = 1;
            this.BtnTable.Text = "Tables";
            this.BtnTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTable.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnTable.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnTable.Click += new System.EventHandler(this.BtnTable_Click);
            // 
            // btnIngredient
            // 
            this.btnIngredient.BorderRadius = 10;
            this.btnIngredient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnIngredient.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnIngredient.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnIngredient.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredient.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnIngredient.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngredient.CustomizableEdges.BottomRight = false;
            this.btnIngredient.CustomizableEdges.TopRight = false;
            this.btnIngredient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngredient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngredient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngredient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngredient.FillColor = System.Drawing.Color.Transparent;
            this.btnIngredient.Font = new System.Drawing.Font("Montserrat SemiBold", 11F);
            this.btnIngredient.ForeColor = System.Drawing.Color.Black;
            this.btnIngredient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngredient.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredient.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnIngredient.Image = ((System.Drawing.Image)(resources.GetObject("btnIngredient.Image")));
            this.btnIngredient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIngredient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIngredient.Location = new System.Drawing.Point(12, 531);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(336, 68);
            this.btnIngredient.TabIndex = 1;
            this.btnIngredient.Text = "Ingrédients";
            this.btnIngredient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIngredient.TextOffset = new System.Drawing.Point(10, 0);
            this.btnIngredient.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // BtnPlat
            // 
            this.BtnPlat.BorderRadius = 10;
            this.BtnPlat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPlat.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnPlat.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnPlat.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlat.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnPlat.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.BtnPlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlat.CustomizableEdges.BottomRight = false;
            this.BtnPlat.CustomizableEdges.TopRight = false;
            this.BtnPlat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPlat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPlat.FillColor = System.Drawing.Color.Transparent;
            this.BtnPlat.Font = new System.Drawing.Font("Montserrat SemiBold", 11F);
            this.BtnPlat.ForeColor = System.Drawing.Color.Black;
            this.BtnPlat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPlat.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlat.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnPlat.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlat.Image")));
            this.BtnPlat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPlat.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPlat.Location = new System.Drawing.Point(12, 457);
            this.BtnPlat.Name = "BtnPlat";
            this.BtnPlat.Size = new System.Drawing.Size(336, 68);
            this.BtnPlat.TabIndex = 1;
            this.BtnPlat.Text = "Plats";
            this.BtnPlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPlat.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnPlat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnPlat.Click += new System.EventHandler(this.BtnPlat_Click);
            // 
            // BtnReservation
            // 
            this.BtnReservation.BorderRadius = 10;
            this.BtnReservation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnReservation.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnReservation.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnReservation.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservation.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnReservation.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.BtnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservation.CustomizableEdges.BottomRight = false;
            this.BtnReservation.CustomizableEdges.TopRight = false;
            this.BtnReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReservation.FillColor = System.Drawing.Color.Transparent;
            this.BtnReservation.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservation.ForeColor = System.Drawing.Color.Black;
            this.BtnReservation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnReservation.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservation.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnReservation.Image = ((System.Drawing.Image)(resources.GetObject("BtnReservation.Image")));
            this.BtnReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnReservation.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnReservation.Location = new System.Drawing.Point(18, 383);
            this.BtnReservation.Name = "BtnReservation";
            this.BtnReservation.Size = new System.Drawing.Size(336, 68);
            this.BtnReservation.TabIndex = 1;
            this.BtnReservation.Text = "Réservations";
            this.BtnReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnReservation.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnReservation.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnReservation.Click += new System.EventHandler(this.BtnReservation_Click);
            // 
            // BtnCommande
            // 
            this.BtnCommande.BorderRadius = 10;
            this.BtnCommande.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCommande.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnCommande.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnCommande.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommande.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCommande.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.BtnCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCommande.CustomizableEdges.BottomRight = false;
            this.BtnCommande.CustomizableEdges.TopRight = false;
            this.BtnCommande.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCommande.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCommande.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCommande.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCommande.FillColor = System.Drawing.Color.Transparent;
            this.BtnCommande.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommande.ForeColor = System.Drawing.Color.Black;
            this.BtnCommande.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCommande.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommande.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCommande.Image = ((System.Drawing.Image)(resources.GetObject("BtnCommande.Image")));
            this.BtnCommande.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCommande.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnCommande.Location = new System.Drawing.Point(18, 309);
            this.BtnCommande.Name = "BtnCommande";
            this.BtnCommande.Size = new System.Drawing.Size(336, 68);
            this.BtnCommande.TabIndex = 1;
            this.BtnCommande.Text = "Commandes";
            this.BtnCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCommande.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnCommande.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnCommande.Click += new System.EventHandler(this.BtnCommande_Click);
            // 
            // BtnCategorie
            // 
            this.BtnCategorie.BorderRadius = 10;
            this.BtnCategorie.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCategorie.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnCategorie.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnCategorie.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorie.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCategorie.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.BtnCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategorie.CustomizableEdges.BottomRight = false;
            this.BtnCategorie.CustomizableEdges.TopRight = false;
            this.BtnCategorie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCategorie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCategorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCategorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCategorie.FillColor = System.Drawing.Color.Transparent;
            this.BtnCategorie.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorie.ForeColor = System.Drawing.Color.Black;
            this.BtnCategorie.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCategorie.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorie.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCategorie.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategorie.Image")));
            this.BtnCategorie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCategorie.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnCategorie.Location = new System.Drawing.Point(12, 605);
            this.BtnCategorie.Name = "BtnCategorie";
            this.BtnCategorie.Size = new System.Drawing.Size(336, 68);
            this.BtnCategorie.TabIndex = 1;
            this.BtnCategorie.Text = "Categories";
            this.BtnCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCategorie.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnCategorie.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnCategorie.Click += new System.EventHandler(this.BtnCategorie_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BorderRadius = 10;
            this.BtnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnMenu.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnMenu.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnMenu.CheckedState.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnMenu.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.CustomizableEdges.BottomRight = false;
            this.BtnMenu.CustomizableEdges.TopRight = false;
            this.BtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMenu.FillColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.Black;
            this.BtnMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMenu.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMenu.Location = new System.Drawing.Point(18, 235);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(336, 68);
            this.BtnMenu.TabIndex = 1;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMenu.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnMenu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "ODC RESTAURANT";
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CenterPanel.Location = new System.Drawing.Point(300, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1500, 1077);
            this.CenterPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1077);
            this.ControlBox = false;
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1620, 1077);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnMenu;
        private Guna.UI2.WinForms.Guna2Button BtnPlat;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button BtnCategorie;
        private Guna.UI2.WinForms.Guna2Button BtnCommande;
        private System.Windows.Forms.Label lbRole;
        private Guna.UI2.WinForms.Guna2Button SeDeconnecter;
        private Guna.UI2.WinForms.Guna2Button BtnClient;
        private Guna.UI2.WinForms.Guna2Button BtnTable;
        private Guna.UI2.WinForms.Guna2Button BtnReservation;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePassword;
        private Guna.UI2.WinForms.Guna2Button btnIngredient;
    }
}