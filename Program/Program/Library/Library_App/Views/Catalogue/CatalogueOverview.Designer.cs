namespace Library_App.Views.Account
{
    partial class CatalogueOverview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSectionName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbView = new System.Windows.Forms.ListBox();
            this.btnMovieLoad = new System.Windows.Forms.Button();
            this.btnBookLoad = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.lblSectionName.Location = new System.Drawing.Point(6, 36);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(454, 35);
            this.lblSectionName.TabIndex = 21;
            this.lblSectionName.Text = "View Catalogue";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(272, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(99, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(57, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 123);
            this.panel1.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(445, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 50);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMovieLoad);
            this.panel3.Controls.Add(this.btnBookLoad);
            this.panel3.Controls.Add(this.lblSectionName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(57, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 130);
            this.panel3.TabIndex = 18;
            // 
            // lbView
            // 
            this.lbView.FormattingEnabled = true;
            this.lbView.ItemHeight = 20;
            this.lbView.Location = new System.Drawing.Point(63, 133);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(1180, 224);
            this.lbView.TabIndex = 23;
            this.lbView.SelectedIndexChanged += new System.EventHandler(this.lbView_SelectedIndexChanged);
            // 
            // btnMovieLoad
            // 
            this.btnMovieLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnMovieLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieLoad.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMovieLoad.ForeColor = System.Drawing.Color.White;
            this.btnMovieLoad.Location = new System.Drawing.Point(261, 74);
            this.btnMovieLoad.Name = "btnMovieLoad";
            this.btnMovieLoad.Size = new System.Drawing.Size(199, 50);
            this.btnMovieLoad.TabIndex = 22;
            this.btnMovieLoad.Text = "Load Movies";
            this.btnMovieLoad.UseVisualStyleBackColor = false;
            this.btnMovieLoad.Click += new System.EventHandler(this.btnMovieLoad_Click);
            // 
            // btnBookLoad
            // 
            this.btnBookLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnBookLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLoad.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookLoad.ForeColor = System.Drawing.Color.White;
            this.btnBookLoad.Location = new System.Drawing.Point(76, 77);
            this.btnBookLoad.Name = "btnBookLoad";
            this.btnBookLoad.Size = new System.Drawing.Size(167, 50);
            this.btnBookLoad.TabIndex = 18;
            this.btnBookLoad.Text = "Load Books";
            this.btnBookLoad.UseVisualStyleBackColor = false;
            this.btnBookLoad.Click += new System.EventHandler(this.btnBookLoad_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1249, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 488);
            this.panel4.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 488);
            this.panel2.TabIndex = 20;
            // 
            // CatalogueOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "CatalogueOverview";
            this.Size = new System.Drawing.Size(1309, 488);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblSectionName;
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel1;
        private Button btnUpdate;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Button btnMovieLoad;
        private Button btnBookLoad;
        private ListBox lbView;
    }
}
