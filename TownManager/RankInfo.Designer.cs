namespace TownManager
{
    partial class RankInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.rankBox = new System.Windows.Forms.ListBox();
            this.sortSelector = new System.Windows.Forms.ComboBox();
            this.rankSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sort By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Rank";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(61, 333);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 29);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rankBox
            // 
            this.rankBox.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankBox.FormattingEnabled = true;
            this.rankBox.ItemHeight = 16;
            this.rankBox.Location = new System.Drawing.Point(12, 114);
            this.rankBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rankBox.Name = "rankBox";
            this.rankBox.Size = new System.Drawing.Size(181, 212);
            this.rankBox.TabIndex = 8;
            // 
            // sortSelector
            // 
            this.sortSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortSelector.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortSelector.FormattingEnabled = true;
            this.sortSelector.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age"});
            this.sortSelector.Location = new System.Drawing.Point(31, 83);
            this.sortSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortSelector.Name = "sortSelector";
            this.sortSelector.Size = new System.Drawing.Size(141, 24);
            this.sortSelector.TabIndex = 7;
            this.sortSelector.SelectedIndexChanged += new System.EventHandler(this.sortSelector_SelectedIndexChanged);
            // 
            // rankSelector
            // 
            this.rankSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankSelector.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankSelector.FormattingEnabled = true;
            this.rankSelector.Items.AddRange(new object[] {
            "General",
            "Captain",
            "Sergeant",
            "Footman",
            "Recruit"});
            this.rankSelector.Location = new System.Drawing.Point(31, 32);
            this.rankSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rankSelector.Name = "rankSelector";
            this.rankSelector.Size = new System.Drawing.Size(141, 24);
            this.rankSelector.TabIndex = 6;
            this.rankSelector.SelectedIndexChanged += new System.EventHandler(this.rankSelector_SelectedIndexChanged);
            // 
            // RankInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.rankBox);
            this.Controls.Add(this.sortSelector);
            this.Controls.Add(this.rankSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankInfo";
            this.Text = "RankInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox rankBox;
        private System.Windows.Forms.ComboBox sortSelector;
        private System.Windows.Forms.ComboBox rankSelector;
    }
}