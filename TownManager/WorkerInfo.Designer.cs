namespace TownManager
{
    partial class WorkerInfo
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
            this.jobSelector = new System.Windows.Forms.ComboBox();
            this.sortSelector = new System.Windows.Forms.ComboBox();
            this.jobBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jobSelector
            // 
            this.jobSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobSelector.FormattingEnabled = true;
            this.jobSelector.Items.AddRange(new object[] {
            "Hunter",
            "Lumberjack",
            "Mason",
            "Miner",
            "Builder",
            "Farmer"});
            this.jobSelector.Location = new System.Drawing.Point(33, 32);
            this.jobSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jobSelector.Name = "jobSelector";
            this.jobSelector.Size = new System.Drawing.Size(141, 24);
            this.jobSelector.TabIndex = 0;
            this.jobSelector.SelectedIndexChanged += new System.EventHandler(this.jobSelector_SelectedIndexChanged);
            // 
            // sortSelector
            // 
            this.sortSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortSelector.FormattingEnabled = true;
            this.sortSelector.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age"});
            this.sortSelector.Location = new System.Drawing.Point(33, 83);
            this.sortSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortSelector.Name = "sortSelector";
            this.sortSelector.Size = new System.Drawing.Size(141, 24);
            this.sortSelector.TabIndex = 1;
            this.sortSelector.SelectedIndexChanged += new System.EventHandler(this.sortSelector_SelectedIndexChanged);
            // 
            // jobBox
            // 
            this.jobBox.FormattingEnabled = true;
            this.jobBox.ItemHeight = 16;
            this.jobBox.Location = new System.Drawing.Point(12, 114);
            this.jobBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(181, 212);
            this.jobBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(61, 333);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 29);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort By";
            // 
            // WorkerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TownManager.Properties.Resources.parchment_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(205, 373);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.jobBox);
            this.Controls.Add(this.sortSelector);
            this.Controls.Add(this.jobSelector);
            this.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkerInfo";
            this.Text = "DetailedInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox jobSelector;
        private System.Windows.Forms.ComboBox sortSelector;
        private System.Windows.Forms.ListBox jobBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}