namespace testCcharp
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenuBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 658);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 172);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.Black;
            this.panelMenuBar.Controls.Add(this.lblTitleChildForm);
            this.panelMenuBar.Controls.Add(this.iconCurrentChildForm);
            this.panelMenuBar.Controls.Add(this.btnMinimize);
            this.panelMenuBar.Controls.Add(this.btnMaximize);
            this.panelMenuBar.Controls.Add(this.btnExit);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(293, 0);
            this.panelMenuBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(1278, 62);
            this.panelMenuBar.TabIndex = 1;
            this.panelMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(59, 23);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(64, 25);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(293, 62);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1278, 596);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(293, 62);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1278, 6);
            this.panelShadow.TabIndex = 3;
            this.panelShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShadow_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::testCcharp.Properties.Resources.Majda;
            this.pictureBox1.Location = new System.Drawing.Point(300, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(8, 15);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 39);
            this.iconCurrentChildForm.TabIndex = 3;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 22;
            this.btnMinimize.Location = new System.Drawing.Point(1167, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 62);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 22;
            this.btnMaximize.Location = new System.Drawing.Point(1204, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 62);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 22;
            this.btnExit.Location = new System.Drawing.Point(1241, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 62);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 221);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(293, 49);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Team management";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 172);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(293, 49);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Player management";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::testCcharp.Properties.Resources.Majda;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(293, 169);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 658);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelMenuBar.ResumeLayout(false);
            this.panelMenuBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenuBar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}