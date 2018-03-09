namespace TownManager
{
    partial class Notifications
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
            this.messageBox = new System.Windows.Forms.ListBox();
            this.filterListBox = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.deathBox = new System.Windows.Forms.CheckBox();
            this.birthBox = new System.Windows.Forms.CheckBox();
            this.marriageBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.filterListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.FormattingEnabled = true;
            this.messageBox.ItemHeight = 19;
            this.messageBox.Location = new System.Drawing.Point(20, 170);
            this.messageBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(637, 270);
            this.messageBox.TabIndex = 0;
            // 
            // filterListBox
            // 
            this.filterListBox.Controls.Add(this.checkBox3);
            this.filterListBox.Controls.Add(this.checkBox2);
            this.filterListBox.Controls.Add(this.checkBox1);
            this.filterListBox.Controls.Add(this.deathBox);
            this.filterListBox.Controls.Add(this.birthBox);
            this.filterListBox.Controls.Add(this.marriageBox);
            this.filterListBox.Location = new System.Drawing.Point(20, 18);
            this.filterListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.filterListBox.Size = new System.Drawing.Size(274, 129);
            this.filterListBox.TabIndex = 1;
            this.filterListBox.TabStop = false;
            this.filterListBox.Text = "Filter";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(140, 95);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 23);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(140, 61);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 23);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 23);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // deathBox
            // 
            this.deathBox.AutoSize = true;
            this.deathBox.Location = new System.Drawing.Point(10, 95);
            this.deathBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deathBox.Name = "deathBox";
            this.deathBox.Size = new System.Drawing.Size(85, 23);
            this.deathBox.TabIndex = 2;
            this.deathBox.Text = "Deaths";
            this.deathBox.UseVisualStyleBackColor = true;
            // 
            // birthBox
            // 
            this.birthBox.AutoSize = true;
            this.birthBox.Location = new System.Drawing.Point(10, 61);
            this.birthBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(98, 23);
            this.birthBox.TabIndex = 1;
            this.birthBox.Text = "Newborn";
            this.birthBox.UseVisualStyleBackColor = true;
            // 
            // marriageBox
            // 
            this.marriageBox.AutoSize = true;
            this.marriageBox.Location = new System.Drawing.Point(10, 28);
            this.marriageBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.marriageBox.Name = "marriageBox";
            this.marriageBox.Size = new System.Drawing.Size(109, 23);
            this.marriageBox.TabIndex = 0;
            this.marriageBox.Text = "Marriages";
            this.marriageBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(270, 469);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 34);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 520);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.messageBox);
            this.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Notifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifications";
            this.filterListBox.ResumeLayout(false);
            this.filterListBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox messageBox;
        private System.Windows.Forms.GroupBox filterListBox;
        private System.Windows.Forms.CheckBox birthBox;
        private System.Windows.Forms.CheckBox marriageBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox deathBox;
        private System.Windows.Forms.Button closeButton;
    }
}