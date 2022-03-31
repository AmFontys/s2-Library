namespace Library_App.Views
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
            this.btnOpeningHour = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelRowMenu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblManagementLevel = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContentHolder = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelRowMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpeningHour
            // 
            this.btnOpeningHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnOpeningHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpeningHour.FlatAppearance.BorderSize = 0;
            this.btnOpeningHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpeningHour.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpeningHour.ForeColor = System.Drawing.Color.White;
            this.btnOpeningHour.Location = new System.Drawing.Point(792, 0);
            this.btnOpeningHour.Name = "btnOpeningHour";
            this.btnOpeningHour.Size = new System.Drawing.Size(232, 67);
            this.btnOpeningHour.TabIndex = 6;
            this.btnOpeningHour.Text = "Opening Hours";
            this.btnOpeningHour.UseVisualStyleBackColor = false;
            this.btnOpeningHour.Click += new System.EventHandler(this.btnOpeningHour_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnEvent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEvent.ForeColor = System.Drawing.Color.White;
            this.btnEvent.Location = new System.Drawing.Point(528, 0);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(264, 67);
            this.btnEvent.TabIndex = 5;
            this.btnEvent.Text = "Event";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnCatalogue.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCatalogue.FlatAppearance.BorderSize = 0;
            this.btnCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogue.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCatalogue.ForeColor = System.Drawing.Color.White;
            this.btnCatalogue.Location = new System.Drawing.Point(264, 0);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(264, 67);
            this.btnCatalogue.TabIndex = 4;
            this.btnCatalogue.Text = "Catalogue";
            this.btnCatalogue.UseVisualStyleBackColor = false;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(264, 67);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelRowMenu
            // 
            this.panelRowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.panelRowMenu.Controls.Add(this.btnAccount);
            this.panelRowMenu.Controls.Add(this.btnOpeningHour);
            this.panelRowMenu.Controls.Add(this.btnEvent);
            this.panelRowMenu.Controls.Add(this.btnCatalogue);
            this.panelRowMenu.Controls.Add(this.btnEmployee);
            this.panelRowMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRowMenu.Location = new System.Drawing.Point(0, 0);
            this.panelRowMenu.Name = "panelRowMenu";
            this.panelRowMenu.Size = new System.Drawing.Size(1266, 67);
            this.panelRowMenu.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(1024, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(239, 67);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Garet Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.lblWelcome.Location = new System.Drawing.Point(1768, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(484, 36);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome, User!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(2280, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblManagementLevel
            // 
            this.lblManagementLevel.AutoSize = true;
            this.lblManagementLevel.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManagementLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(165)))));
            this.lblManagementLevel.Location = new System.Drawing.Point(12, 9);
            this.lblManagementLevel.Name = "lblManagementLevel";
            this.lblManagementLevel.Size = new System.Drawing.Size(591, 35);
            this.lblManagementLevel.TabIndex = 7;
            this.lblManagementLevel.Text = "General management";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelContentHolder);
            this.panelContent.Controls.Add(this.panelRowMenu);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 125);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1266, 521);
            this.panelContent.TabIndex = 4;
            // 
            // panelContentHolder
            // 
            this.panelContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentHolder.Location = new System.Drawing.Point(0, 67);
            this.panelContentHolder.Name = "panelContentHolder";
            this.panelContentHolder.Size = new System.Drawing.Size(1266, 454);
            this.panelContentHolder.TabIndex = 11;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.BurlyWood;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.lblManagementLevel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1266, 125);
            this.panelHeader.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 646);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelRowMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpeningHour;
        private Button btnEvent;
        private Button btnCatalogue;
        private Button btnEmployee;
        private Panel panelRowMenu;
        private Button btnAccount;
        private Label lblWelcome;
        private PictureBox pictureBox2;
        private Label lblManagementLevel;
        private Panel panelContent;
        private Panel panelContentHolder;
        private Panel panelHeader;
    }
}