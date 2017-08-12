namespace Review_Classifier
{
    partial class ReviewClassifier
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
            this.applicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.reviewsDataGridView = new System.Windows.Forms.DataGridView();
            this.EmotionPanel = new System.Windows.Forms.Panel();
            this.ENeutralPanel = new System.Windows.Forms.Panel();
            this.ENeutralCheckBox = new System.Windows.Forms.CheckBox();
            this.ENegativePanel = new System.Windows.Forms.Panel();
            this.ENegativeCheckBox = new System.Windows.Forms.CheckBox();
            this.EPositivePanel = new System.Windows.Forms.Panel();
            this.EPositiveCheckBox = new System.Windows.Forms.CheckBox();
            this.FunctionalRequirementsPanel = new System.Windows.Forms.Panel();
            this.FRMiscellaneousPanel = new System.Windows.Forms.Panel();
            this.FRMiscellaneousCheckBox = new System.Windows.Forms.CheckBox();
            this.UserRequirementPanel = new System.Windows.Forms.Panel();
            this.UserRequirementCheckBox = new System.Windows.Forms.CheckBox();
            this.BugReportPanel = new System.Windows.Forms.Panel();
            this.BugReportCheckBox = new System.Windows.Forms.CheckBox();
            this.NFRPanel = new System.Windows.Forms.Panel();
            this.NFRMiscellaneousPanel = new System.Windows.Forms.Panel();
            this.NFRMiscellaneousCheckBox = new System.Windows.Forms.CheckBox();
            this.UsabilityPanel = new System.Windows.Forms.Panel();
            this.UsabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.SupportabilityPanel = new System.Windows.Forms.Panel();
            this.SupportabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.PerformancePanel = new System.Windows.Forms.Panel();
            this.PerformanceCheckBox = new System.Windows.Forms.CheckBox();
            this.DependabilityPanel = new System.Windows.Forms.Panel();
            this.DependabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataGridView)).BeginInit();
            this.EmotionPanel.SuspendLayout();
            this.ENeutralPanel.SuspendLayout();
            this.ENegativePanel.SuspendLayout();
            this.EPositivePanel.SuspendLayout();
            this.FunctionalRequirementsPanel.SuspendLayout();
            this.FRMiscellaneousPanel.SuspendLayout();
            this.UserRequirementPanel.SuspendLayout();
            this.BugReportPanel.SuspendLayout();
            this.NFRPanel.SuspendLayout();
            this.NFRMiscellaneousPanel.SuspendLayout();
            this.UsabilityPanel.SuspendLayout();
            this.SupportabilityPanel.SuspendLayout();
            this.PerformancePanel.SuspendLayout();
            this.DependabilityPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationsDataGridView
            // 
            this.applicationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsDataGridView.Location = new System.Drawing.Point(8, 36);
            this.applicationsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.applicationsDataGridView.Name = "applicationsDataGridView";
            this.applicationsDataGridView.RowTemplate.Height = 28;
            this.applicationsDataGridView.Size = new System.Drawing.Size(1055, 179);
            this.applicationsDataGridView.TabIndex = 0;
            // 
            // reviewsDataGridView
            // 
            this.reviewsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reviewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsDataGridView.Location = new System.Drawing.Point(8, 248);
            this.reviewsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.reviewsDataGridView.Name = "reviewsDataGridView";
            this.reviewsDataGridView.RowTemplate.Height = 28;
            this.reviewsDataGridView.Size = new System.Drawing.Size(1055, 212);
            this.reviewsDataGridView.TabIndex = 1;
            this.reviewsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reviewsDataGridView_KeyDown);
            this.reviewsDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.reviewsDataGridView_KeyUp);
            // 
            // EmotionPanel
            // 
            this.EmotionPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmotionPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmotionPanel.Controls.Add(this.ENeutralPanel);
            this.EmotionPanel.Controls.Add(this.ENegativePanel);
            this.EmotionPanel.Controls.Add(this.EPositivePanel);
            this.EmotionPanel.Location = new System.Drawing.Point(12, 599);
            this.EmotionPanel.Name = "EmotionPanel";
            this.EmotionPanel.Size = new System.Drawing.Size(504, 100);
            this.EmotionPanel.TabIndex = 2;
            // 
            // ENeutralPanel
            // 
            this.ENeutralPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ENeutralPanel.Controls.Add(this.ENeutralCheckBox);
            this.ENeutralPanel.Location = new System.Drawing.Point(343, 18);
            this.ENeutralPanel.Name = "ENeutralPanel";
            this.ENeutralPanel.Size = new System.Drawing.Size(134, 64);
            this.ENeutralPanel.TabIndex = 2;
            this.ENeutralPanel.Click += new System.EventHandler(this.ENeutralPanel_Click);
            // 
            // ENeutralCheckBox
            // 
            this.ENeutralCheckBox.AutoSize = true;
            this.ENeutralCheckBox.Location = new System.Drawing.Point(18, 24);
            this.ENeutralCheckBox.Name = "ENeutralCheckBox";
            this.ENeutralCheckBox.Size = new System.Drawing.Size(101, 17);
            this.ENeutralCheckBox.TabIndex = 0;
            this.ENeutralCheckBox.Text = "Neutral Emotion";
            this.ENeutralCheckBox.UseVisualStyleBackColor = true;
            this.ENeutralCheckBox.CheckedChanged += new System.EventHandler(this.ENeutralCheckBox_CheckedChanged);
            // 
            // ENegativePanel
            // 
            this.ENegativePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ENegativePanel.Controls.Add(this.ENegativeCheckBox);
            this.ENegativePanel.Location = new System.Drawing.Point(185, 18);
            this.ENegativePanel.Name = "ENegativePanel";
            this.ENegativePanel.Size = new System.Drawing.Size(134, 64);
            this.ENegativePanel.TabIndex = 2;
            this.ENegativePanel.Click += new System.EventHandler(this.ENegativePanel_Click);
            // 
            // ENegativeCheckBox
            // 
            this.ENegativeCheckBox.AutoSize = true;
            this.ENegativeCheckBox.Location = new System.Drawing.Point(15, 24);
            this.ENegativeCheckBox.Name = "ENegativeCheckBox";
            this.ENegativeCheckBox.Size = new System.Drawing.Size(110, 17);
            this.ENegativeCheckBox.TabIndex = 0;
            this.ENegativeCheckBox.Text = "Negative Emotion";
            this.ENegativeCheckBox.UseVisualStyleBackColor = true;
            this.ENegativeCheckBox.CheckedChanged += new System.EventHandler(this.ENegativeCheckBox_CheckedChanged);
            // 
            // EPositivePanel
            // 
            this.EPositivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EPositivePanel.Controls.Add(this.EPositiveCheckBox);
            this.EPositivePanel.Location = new System.Drawing.Point(21, 18);
            this.EPositivePanel.Name = "EPositivePanel";
            this.EPositivePanel.Size = new System.Drawing.Size(134, 64);
            this.EPositivePanel.TabIndex = 1;
            this.EPositivePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EPositivePanel_MouseClick);
            // 
            // EPositiveCheckBox
            // 
            this.EPositiveCheckBox.AutoSize = true;
            this.EPositiveCheckBox.Location = new System.Drawing.Point(17, 24);
            this.EPositiveCheckBox.Name = "EPositiveCheckBox";
            this.EPositiveCheckBox.Size = new System.Drawing.Size(104, 17);
            this.EPositiveCheckBox.TabIndex = 0;
            this.EPositiveCheckBox.Text = "Positive Emotion";
            this.EPositiveCheckBox.UseVisualStyleBackColor = true;
            this.EPositiveCheckBox.Click += new System.EventHandler(this.EPositiveCheckBox_Click);
            // 
            // FunctionalRequirementsPanel
            // 
            this.FunctionalRequirementsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FunctionalRequirementsPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FunctionalRequirementsPanel.Controls.Add(this.FRMiscellaneousPanel);
            this.FunctionalRequirementsPanel.Controls.Add(this.UserRequirementPanel);
            this.FunctionalRequirementsPanel.Controls.Add(this.BugReportPanel);
            this.FunctionalRequirementsPanel.Location = new System.Drawing.Point(534, 599);
            this.FunctionalRequirementsPanel.Name = "FunctionalRequirementsPanel";
            this.FunctionalRequirementsPanel.Size = new System.Drawing.Size(529, 100);
            this.FunctionalRequirementsPanel.TabIndex = 3;
            // 
            // FRMiscellaneousPanel
            // 
            this.FRMiscellaneousPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRMiscellaneousPanel.Controls.Add(this.FRMiscellaneousCheckBox);
            this.FRMiscellaneousPanel.Location = new System.Drawing.Point(376, 18);
            this.FRMiscellaneousPanel.Name = "FRMiscellaneousPanel";
            this.FRMiscellaneousPanel.Size = new System.Drawing.Size(134, 64);
            this.FRMiscellaneousPanel.TabIndex = 2;
            this.FRMiscellaneousPanel.Click += new System.EventHandler(this.FRMiscellaneousPanel_Click);
            // 
            // FRMiscellaneousCheckBox
            // 
            this.FRMiscellaneousCheckBox.AutoSize = true;
            this.FRMiscellaneousCheckBox.Location = new System.Drawing.Point(24, 24);
            this.FRMiscellaneousCheckBox.Name = "FRMiscellaneousCheckBox";
            this.FRMiscellaneousCheckBox.Size = new System.Drawing.Size(93, 17);
            this.FRMiscellaneousCheckBox.TabIndex = 0;
            this.FRMiscellaneousCheckBox.Text = "Miscellaneous";
            this.FRMiscellaneousCheckBox.UseVisualStyleBackColor = true;
            this.FRMiscellaneousCheckBox.CheckedChanged += new System.EventHandler(this.FRMiscellaneousCheckBox_CheckedChanged);
            // 
            // UserRequirementPanel
            // 
            this.UserRequirementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserRequirementPanel.Controls.Add(this.UserRequirementCheckBox);
            this.UserRequirementPanel.Location = new System.Drawing.Point(205, 18);
            this.UserRequirementPanel.Name = "UserRequirementPanel";
            this.UserRequirementPanel.Size = new System.Drawing.Size(134, 64);
            this.UserRequirementPanel.TabIndex = 2;
            this.UserRequirementPanel.Click += new System.EventHandler(this.UserRequirementPanel_Click);
            // 
            // UserRequirementCheckBox
            // 
            this.UserRequirementCheckBox.AutoSize = true;
            this.UserRequirementCheckBox.Location = new System.Drawing.Point(14, 24);
            this.UserRequirementCheckBox.Name = "UserRequirementCheckBox";
            this.UserRequirementCheckBox.Size = new System.Drawing.Size(111, 17);
            this.UserRequirementCheckBox.TabIndex = 0;
            this.UserRequirementCheckBox.Text = "User Requirement";
            this.UserRequirementCheckBox.UseVisualStyleBackColor = true;
            this.UserRequirementCheckBox.CheckedChanged += new System.EventHandler(this.UserRequirementCheckBox_CheckedChanged);
            // 
            // BugReportPanel
            // 
            this.BugReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BugReportPanel.Controls.Add(this.BugReportCheckBox);
            this.BugReportPanel.Location = new System.Drawing.Point(33, 18);
            this.BugReportPanel.Name = "BugReportPanel";
            this.BugReportPanel.Size = new System.Drawing.Size(134, 64);
            this.BugReportPanel.TabIndex = 2;
            this.BugReportPanel.Click += new System.EventHandler(this.BugReportPanel_Click);
            // 
            // BugReportCheckBox
            // 
            this.BugReportCheckBox.AutoSize = true;
            this.BugReportCheckBox.Location = new System.Drawing.Point(24, 24);
            this.BugReportCheckBox.Name = "BugReportCheckBox";
            this.BugReportCheckBox.Size = new System.Drawing.Size(80, 17);
            this.BugReportCheckBox.TabIndex = 0;
            this.BugReportCheckBox.Text = "Bug Report";
            this.BugReportCheckBox.UseVisualStyleBackColor = true;
            this.BugReportCheckBox.CheckedChanged += new System.EventHandler(this.BugReportCheckBox_CheckedChanged);
            // 
            // NFRPanel
            // 
            this.NFRPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NFRPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NFRPanel.Controls.Add(this.NFRMiscellaneousPanel);
            this.NFRPanel.Controls.Add(this.UsabilityPanel);
            this.NFRPanel.Controls.Add(this.SupportabilityPanel);
            this.NFRPanel.Controls.Add(this.PerformancePanel);
            this.NFRPanel.Controls.Add(this.DependabilityPanel);
            this.NFRPanel.Location = new System.Drawing.Point(13, 712);
            this.NFRPanel.Name = "NFRPanel";
            this.NFRPanel.Size = new System.Drawing.Size(758, 112);
            this.NFRPanel.TabIndex = 3;
            // 
            // NFRMiscellaneousPanel
            // 
            this.NFRMiscellaneousPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NFRMiscellaneousPanel.Controls.Add(this.NFRMiscellaneousCheckBox);
            this.NFRMiscellaneousPanel.Location = new System.Drawing.Point(609, 22);
            this.NFRMiscellaneousPanel.Name = "NFRMiscellaneousPanel";
            this.NFRMiscellaneousPanel.Size = new System.Drawing.Size(134, 64);
            this.NFRMiscellaneousPanel.TabIndex = 2;
            this.NFRMiscellaneousPanel.Click += new System.EventHandler(this.NFRMiscellaneousPanel_Click);
            // 
            // NFRMiscellaneousCheckBox
            // 
            this.NFRMiscellaneousCheckBox.AutoSize = true;
            this.NFRMiscellaneousCheckBox.Location = new System.Drawing.Point(24, 24);
            this.NFRMiscellaneousCheckBox.Name = "NFRMiscellaneousCheckBox";
            this.NFRMiscellaneousCheckBox.Size = new System.Drawing.Size(93, 17);
            this.NFRMiscellaneousCheckBox.TabIndex = 0;
            this.NFRMiscellaneousCheckBox.Text = "Miscellaneous";
            this.NFRMiscellaneousCheckBox.UseVisualStyleBackColor = true;
            this.NFRMiscellaneousCheckBox.CheckedChanged += new System.EventHandler(this.NFRMiscellaneousCheckBox_CheckedChanged);
            // 
            // UsabilityPanel
            // 
            this.UsabilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsabilityPanel.Controls.Add(this.UsabilityCheckBox);
            this.UsabilityPanel.Location = new System.Drawing.Point(463, 22);
            this.UsabilityPanel.Name = "UsabilityPanel";
            this.UsabilityPanel.Size = new System.Drawing.Size(134, 64);
            this.UsabilityPanel.TabIndex = 2;
            this.UsabilityPanel.Click += new System.EventHandler(this.UsabilityPanel_Click);
            // 
            // UsabilityCheckBox
            // 
            this.UsabilityCheckBox.AutoSize = true;
            this.UsabilityCheckBox.Location = new System.Drawing.Point(36, 24);
            this.UsabilityCheckBox.Name = "UsabilityCheckBox";
            this.UsabilityCheckBox.Size = new System.Drawing.Size(65, 17);
            this.UsabilityCheckBox.TabIndex = 0;
            this.UsabilityCheckBox.Text = "Usability";
            this.UsabilityCheckBox.UseVisualStyleBackColor = true;
            this.UsabilityCheckBox.CheckedChanged += new System.EventHandler(this.UsabilityCheckBox_CheckedChanged);
            // 
            // SupportabilityPanel
            // 
            this.SupportabilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupportabilityPanel.Controls.Add(this.SupportabilityCheckBox);
            this.SupportabilityPanel.Location = new System.Drawing.Point(314, 22);
            this.SupportabilityPanel.Name = "SupportabilityPanel";
            this.SupportabilityPanel.Size = new System.Drawing.Size(134, 64);
            this.SupportabilityPanel.TabIndex = 2;
            this.SupportabilityPanel.Click += new System.EventHandler(this.SupportabilityPanel_Click);
            // 
            // SupportabilityCheckBox
            // 
            this.SupportabilityCheckBox.AutoSize = true;
            this.SupportabilityCheckBox.Location = new System.Drawing.Point(24, 24);
            this.SupportabilityCheckBox.Name = "SupportabilityCheckBox";
            this.SupportabilityCheckBox.Size = new System.Drawing.Size(89, 17);
            this.SupportabilityCheckBox.TabIndex = 0;
            this.SupportabilityCheckBox.Text = "Supportability";
            this.SupportabilityCheckBox.UseVisualStyleBackColor = true;
            this.SupportabilityCheckBox.CheckedChanged += new System.EventHandler(this.SupportabilityCheckBox_CheckedChanged);
            // 
            // PerformancePanel
            // 
            this.PerformancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PerformancePanel.Controls.Add(this.PerformanceCheckBox);
            this.PerformancePanel.Location = new System.Drawing.Point(169, 22);
            this.PerformancePanel.Name = "PerformancePanel";
            this.PerformancePanel.Size = new System.Drawing.Size(134, 64);
            this.PerformancePanel.TabIndex = 2;
            this.PerformancePanel.Click += new System.EventHandler(this.PerformancePanel_Click);
            // 
            // PerformanceCheckBox
            // 
            this.PerformanceCheckBox.AutoSize = true;
            this.PerformanceCheckBox.Location = new System.Drawing.Point(24, 24);
            this.PerformanceCheckBox.Name = "PerformanceCheckBox";
            this.PerformanceCheckBox.Size = new System.Drawing.Size(86, 17);
            this.PerformanceCheckBox.TabIndex = 0;
            this.PerformanceCheckBox.Text = "Performance";
            this.PerformanceCheckBox.UseVisualStyleBackColor = true;
            this.PerformanceCheckBox.CheckedChanged += new System.EventHandler(this.PerformanceCheckBox_CheckedChanged);
            // 
            // DependabilityPanel
            // 
            this.DependabilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DependabilityPanel.Controls.Add(this.DependabilityCheckBox);
            this.DependabilityPanel.Location = new System.Drawing.Point(12, 22);
            this.DependabilityPanel.Name = "DependabilityPanel";
            this.DependabilityPanel.Size = new System.Drawing.Size(134, 64);
            this.DependabilityPanel.TabIndex = 2;
            this.DependabilityPanel.Click += new System.EventHandler(this.DependabilityPanel_Click);
            // 
            // DependabilityCheckBox
            // 
            this.DependabilityCheckBox.AutoSize = true;
            this.DependabilityCheckBox.Location = new System.Drawing.Point(24, 24);
            this.DependabilityCheckBox.Name = "DependabilityCheckBox";
            this.DependabilityCheckBox.Size = new System.Drawing.Size(90, 17);
            this.DependabilityCheckBox.TabIndex = 0;
            this.DependabilityCheckBox.Text = "Dependability";
            this.DependabilityCheckBox.UseVisualStyleBackColor = true;
            this.DependabilityCheckBox.CheckedChanged += new System.EventHandler(this.DependabilityCheckBox_CheckedChanged);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentTextBox.Location = new System.Drawing.Point(13, 494);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(1050, 93);
            this.CommentTextBox.TabIndex = 4;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NextButton.Location = new System.Drawing.Point(160, 22);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(115, 64);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PreviousButton.Location = new System.Drawing.Point(11, 22);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(122, 64);
            this.PreviousButton.TabIndex = 6;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.PreviousButton);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Location = new System.Drawing.Point(777, 712);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 112);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Review";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selected Review";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(405, 475);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(207, 13);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "Counter update on next and previous click";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReviewClassifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 836);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.NFRPanel);
            this.Controls.Add(this.FunctionalRequirementsPanel);
            this.Controls.Add(this.EmotionPanel);
            this.Controls.Add(this.reviewsDataGridView);
            this.Controls.Add(this.applicationsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReviewClassifier";
            this.Text = "Review Classifier";
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataGridView)).EndInit();
            this.EmotionPanel.ResumeLayout(false);
            this.ENeutralPanel.ResumeLayout(false);
            this.ENeutralPanel.PerformLayout();
            this.ENegativePanel.ResumeLayout(false);
            this.ENegativePanel.PerformLayout();
            this.EPositivePanel.ResumeLayout(false);
            this.EPositivePanel.PerformLayout();
            this.FunctionalRequirementsPanel.ResumeLayout(false);
            this.FRMiscellaneousPanel.ResumeLayout(false);
            this.FRMiscellaneousPanel.PerformLayout();
            this.UserRequirementPanel.ResumeLayout(false);
            this.UserRequirementPanel.PerformLayout();
            this.BugReportPanel.ResumeLayout(false);
            this.BugReportPanel.PerformLayout();
            this.NFRPanel.ResumeLayout(false);
            this.NFRMiscellaneousPanel.ResumeLayout(false);
            this.NFRMiscellaneousPanel.PerformLayout();
            this.UsabilityPanel.ResumeLayout(false);
            this.UsabilityPanel.PerformLayout();
            this.SupportabilityPanel.ResumeLayout(false);
            this.SupportabilityPanel.PerformLayout();
            this.PerformancePanel.ResumeLayout(false);
            this.PerformancePanel.PerformLayout();
            this.DependabilityPanel.ResumeLayout(false);
            this.DependabilityPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView applicationsDataGridView;
        private System.Windows.Forms.DataGridView reviewsDataGridView;
        private System.Windows.Forms.Panel EmotionPanel;
        private System.Windows.Forms.Panel FunctionalRequirementsPanel;
        private System.Windows.Forms.Panel NFRPanel;
        private System.Windows.Forms.Panel ENeutralPanel;
        private System.Windows.Forms.CheckBox ENeutralCheckBox;
        private System.Windows.Forms.Panel ENegativePanel;
        private System.Windows.Forms.CheckBox ENegativeCheckBox;
        private System.Windows.Forms.Panel EPositivePanel;
        private System.Windows.Forms.CheckBox EPositiveCheckBox;
        private System.Windows.Forms.Panel FRMiscellaneousPanel;
        private System.Windows.Forms.CheckBox FRMiscellaneousCheckBox;
        private System.Windows.Forms.Panel UserRequirementPanel;
        private System.Windows.Forms.CheckBox UserRequirementCheckBox;
        private System.Windows.Forms.Panel BugReportPanel;
        private System.Windows.Forms.CheckBox BugReportCheckBox;
        private System.Windows.Forms.Panel NFRMiscellaneousPanel;
        private System.Windows.Forms.CheckBox NFRMiscellaneousCheckBox;
        private System.Windows.Forms.Panel UsabilityPanel;
        private System.Windows.Forms.CheckBox UsabilityCheckBox;
        private System.Windows.Forms.Panel SupportabilityPanel;
        private System.Windows.Forms.CheckBox SupportabilityCheckBox;
        private System.Windows.Forms.Panel PerformancePanel;
        private System.Windows.Forms.CheckBox PerformanceCheckBox;
        private System.Windows.Forms.Panel DependabilityPanel;
        private System.Windows.Forms.CheckBox DependabilityCheckBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label infoLabel;
    }
}

