namespace Library_App.Views.Account
{
    partial class CatalogueNew
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
            this.nudTimeMin = new System.Windows.Forms.NumericUpDown();
            this.nudPages = new System.Windows.Forms.NumericUpDown();
            this.txtDemographic = new System.Windows.Forms.TextBox();
            this.lblDemographic = new System.Windows.Forms.Label();
            this.lblTimeMin = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBook = new System.Windows.Forms.RadioButton();
            this.rdMovie = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTimeMin
            // 
            this.nudTimeMin.Location = new System.Drawing.Point(762, 206);
            this.nudTimeMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeMin.Name = "nudTimeMin";
            this.nudTimeMin.Size = new System.Drawing.Size(125, 27);
            this.nudTimeMin.TabIndex = 82;
            this.nudTimeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPages
            // 
            this.nudPages.Location = new System.Drawing.Point(425, 176);
            this.nudPages.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPages.Name = "nudPages";
            this.nudPages.Size = new System.Drawing.Size(125, 27);
            this.nudPages.TabIndex = 81;
            this.nudPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDemographic
            // 
            this.txtDemographic.Location = new System.Drawing.Point(762, 238);
            this.txtDemographic.Name = "txtDemographic";
            this.txtDemographic.Size = new System.Drawing.Size(67, 27);
            this.txtDemographic.TabIndex = 80;
            // 
            // lblDemographic
            // 
            this.lblDemographic.AutoSize = true;
            this.lblDemographic.Location = new System.Drawing.Point(635, 241);
            this.lblDemographic.Name = "lblDemographic";
            this.lblDemographic.Size = new System.Drawing.Size(100, 20);
            this.lblDemographic.TabIndex = 79;
            this.lblDemographic.Text = "Demographic";
            // 
            // lblTimeMin
            // 
            this.lblTimeMin.AutoSize = true;
            this.lblTimeMin.Location = new System.Drawing.Point(635, 208);
            this.lblTimeMin.Name = "lblTimeMin";
            this.lblTimeMin.Size = new System.Drawing.Size(111, 20);
            this.lblTimeMin.TabIndex = 78;
            this.lblTimeMin.Text = "time in minutes";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(762, 172);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(171, 27);
            this.txtProducer.TabIndex = 77;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(635, 182);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(68, 20);
            this.lblProducer.TabIndex = 76;
            this.lblProducer.Text = "Producer";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(17, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 50);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.Location = new System.Drawing.Point(563, 330);
            this.txtSubtitle.Multiline = true;
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(323, 109);
            this.txtSubtitle.TabIndex = 75;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(563, 307);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(66, 20);
            this.lblSubtitle.TabIndex = 74;
            this.lblSubtitle.Text = "Subtitles";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(425, 242);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(204, 27);
            this.txtPublisher.TabIndex = 73;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(350, 245);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(69, 20);
            this.lblPublisher.TabIndex = 72;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(425, 209);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(204, 27);
            this.txtAuthor.TabIndex = 71;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(350, 205);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 20);
            this.lblAuthor.TabIndex = 70;
            this.lblAuthor.Text = "Author";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(350, 175);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(47, 20);
            this.lblPages.TabIndex = 69;
            this.lblPages.Text = "Pages";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(154, 242);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(190, 27);
            this.txtCost.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Cost";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(63, 330);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(473, 109);
            this.txtDescription.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Description";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(154, 205);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(190, 27);
            this.txtLanguage.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Language";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(154, 172);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 27);
            this.txtISBN.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "ISBN";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 27);
            this.txtName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(57, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 123);
            this.panel1.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSectionName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(57, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 130);
            this.panel3.TabIndex = 55;
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(165)))));
            this.lblSectionName.Location = new System.Drawing.Point(6, 36);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(438, 35);
            this.lblSectionName.TabIndex = 21;
            this.lblSectionName.Text = "New Catalogue";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1004, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 579);
            this.panel4.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 579);
            this.panel2.TabIndex = 57;
            // 
            // rdBook
            // 
            this.rdBook.AutoSize = true;
            this.rdBook.Checked = true;
            this.rdBook.Location = new System.Drawing.Point(586, 134);
            this.rdBook.Name = "rdBook";
            this.rdBook.Size = new System.Drawing.Size(70, 24);
            this.rdBook.TabIndex = 83;
            this.rdBook.TabStop = true;
            this.rdBook.Text = "Books";
            this.rdBook.UseVisualStyleBackColor = true;
            this.rdBook.CheckedChanged += new System.EventHandler(this.rdBook_CheckedChanged);
            // 
            // rdMovie
            // 
            this.rdMovie.AutoSize = true;
            this.rdMovie.Location = new System.Drawing.Point(662, 134);
            this.rdMovie.Name = "rdMovie";
            this.rdMovie.Size = new System.Drawing.Size(71, 24);
            this.rdMovie.TabIndex = 84;
            this.rdMovie.Text = "Movie";
            this.rdMovie.UseVisualStyleBackColor = true;
            this.rdMovie.CheckedChanged += new System.EventHandler(this.rdMovie_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Whick type do you want to add?";
            // 
            // CatalogueNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdMovie);
            this.Controls.Add(this.rdBook);
            this.Controls.Add(this.nudTimeMin);
            this.Controls.Add(this.nudPages);
            this.Controls.Add(this.txtDemographic);
            this.Controls.Add(this.lblDemographic);
            this.Controls.Add(this.lblTimeMin);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.txtSubtitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "CatalogueNew";
            this.Size = new System.Drawing.Size(1064, 579);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudTimeMin;
        private NumericUpDown nudPages;
        private TextBox txtDemographic;
        private Label lblDemographic;
        private Label lblTimeMin;
        private TextBox txtProducer;
        private Label lblProducer;
        private Button btnAdd;
        private TextBox txtSubtitle;
        private Label lblSubtitle;
        private TextBox txtPublisher;
        private Label lblPublisher;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private Label lblPages;
        private TextBox txtCost;
        private Label label5;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtLanguage;
        private Label label3;
        private TextBox txtISBN;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label lblSectionName;
        private Panel panel4;
        private Panel panel2;
        private RadioButton rdBook;
        private RadioButton rdMovie;
        private Label label6;
    }
}
