namespace Library_App.Views.Account
{
    partial class CatalogueUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblTimeMin = new System.Windows.Forms.Label();
            this.txtDemographic = new System.Windows.Forms.TextBox();
            this.lblDemographic = new System.Windows.Forms.Label();
            this.nudPages = new System.Windows.Forms.NumericUpDown();
            this.nudTimeMin = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(165)))));
            this.lblSectionName.Location = new System.Drawing.Point(6, 36);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(525, 35);
            this.lblSectionName.TabIndex = 21;
            this.lblSectionName.Text = "Update Catalogue";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(57, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 123);
            this.panel1.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(17, 19);
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
            this.panel3.Controls.Add(this.lblSectionName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(57, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 130);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1075, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 568);
            this.panel4.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 568);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 27);
            this.txtName.TabIndex = 30;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(154, 172);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 27);
            this.txtISBN.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ISBN";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(154, 205);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(190, 27);
            this.txtLanguage.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Language";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(63, 330);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(473, 109);
            this.txtDescription.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Description";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(154, 242);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(190, 27);
            this.txtCost.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cost";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(350, 142);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(47, 20);
            this.lblPages.TabIndex = 39;
            this.lblPages.Text = "Pages";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(425, 176);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(204, 27);
            this.txtAuthor.TabIndex = 42;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(350, 172);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 20);
            this.lblAuthor.TabIndex = 41;
            this.lblAuthor.Text = "Author";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(425, 209);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(204, 27);
            this.txtPublisher.TabIndex = 44;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(350, 212);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(69, 20);
            this.lblPublisher.TabIndex = 43;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.Location = new System.Drawing.Point(563, 330);
            this.txtSubtitle.Multiline = true;
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(323, 109);
            this.txtSubtitle.TabIndex = 46;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(563, 307);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(66, 20);
            this.lblSubtitle.TabIndex = 45;
            this.lblSubtitle.Text = "Subtitles";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(787, 139);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(171, 27);
            this.txtProducer.TabIndex = 48;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(660, 149);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(68, 20);
            this.lblProducer.TabIndex = 47;
            this.lblProducer.Text = "Producer";
            // 
            // lblTimeMin
            // 
            this.lblTimeMin.AutoSize = true;
            this.lblTimeMin.Location = new System.Drawing.Point(660, 175);
            this.lblTimeMin.Name = "lblTimeMin";
            this.lblTimeMin.Size = new System.Drawing.Size(111, 20);
            this.lblTimeMin.TabIndex = 49;
            this.lblTimeMin.Text = "time in minutes";
            // 
            // txtDemographic
            // 
            this.txtDemographic.Location = new System.Drawing.Point(787, 205);
            this.txtDemographic.Name = "txtDemographic";
            this.txtDemographic.Size = new System.Drawing.Size(67, 27);
            this.txtDemographic.TabIndex = 52;
            // 
            // lblDemographic
            // 
            this.lblDemographic.AutoSize = true;
            this.lblDemographic.Location = new System.Drawing.Point(660, 208);
            this.lblDemographic.Name = "lblDemographic";
            this.lblDemographic.Size = new System.Drawing.Size(100, 20);
            this.lblDemographic.TabIndex = 51;
            this.lblDemographic.Text = "Demographic";
            // 
            // nudPages
            // 
            this.nudPages.Location = new System.Drawing.Point(425, 143);
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
            this.nudPages.TabIndex = 53;
            this.nudPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTimeMin
            // 
            this.nudTimeMin.Location = new System.Drawing.Point(787, 173);
            this.nudTimeMin.Maximum = new decimal(new int[] {
            5000,
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
            this.nudTimeMin.TabIndex = 54;
            this.nudTimeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CatalogueUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "CatalogueUpdate";
            this.Size = new System.Drawing.Size(1135, 568);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSectionName;
        private Panel panel1;
        private Button btnUpdate;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtISBN;
        private Label label2;
        private TextBox txtLanguage;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtCost;
        private Label label5;
        private Label lblPages;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private TextBox txtPublisher;
        private Label lblPublisher;
        private TextBox txtSubtitle;
        private Label lblSubtitle;
        private TextBox txtProducer;
        private Label lblProducer;
        private Label lblTimeMin;
        private TextBox txtDemographic;
        private Label lblDemographic;
        private NumericUpDown nudPages;
        private NumericUpDown nudTimeMin;
    }
}
