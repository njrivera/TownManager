namespace TownManager
{
    partial class DoodInfo
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
            this.sortSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doodBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imprisonedBox = new System.Windows.Forms.CheckBox();
            this.deceasedBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.adultButton = new System.Windows.Forms.RadioButton();
            this.childButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.employedButton = new System.Windows.Forms.RadioButton();
            this.unemployedButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.sortSelector.Location = new System.Drawing.Point(20, 172);
            this.sortSelector.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sortSelector.Name = "sortSelector";
            this.sortSelector.Size = new System.Drawing.Size(196, 24);
            this.sortSelector.TabIndex = 0;
            this.sortSelector.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort By";
            // 
            // doodBox
            // 
            this.doodBox.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doodBox.FormattingEnabled = true;
            this.doodBox.ItemHeight = 18;
            this.doodBox.Location = new System.Drawing.Point(14, 209);
            this.doodBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.doodBox.Name = "doodBox";
            this.doodBox.Size = new System.Drawing.Size(352, 292);
            this.doodBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(126, 508);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 42);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter";
            // 
            // imprisonedBox
            // 
            this.imprisonedBox.AutoSize = true;
            this.imprisonedBox.BackColor = System.Drawing.Color.Transparent;
            this.imprisonedBox.Location = new System.Drawing.Point(231, 178);
            this.imprisonedBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.imprisonedBox.Name = "imprisonedBox";
            this.imprisonedBox.Size = new System.Drawing.Size(113, 23);
            this.imprisonedBox.TabIndex = 10;
            this.imprisonedBox.Text = "Imprisoned";
            this.imprisonedBox.UseVisualStyleBackColor = false;
            this.imprisonedBox.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // deceasedBox
            // 
            this.deceasedBox.AutoSize = true;
            this.deceasedBox.BackColor = System.Drawing.Color.Transparent;
            this.deceasedBox.Location = new System.Drawing.Point(231, 147);
            this.deceasedBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deceasedBox.Name = "deceasedBox";
            this.deceasedBox.Size = new System.Drawing.Size(100, 23);
            this.deceasedBox.TabIndex = 8;
            this.deceasedBox.Text = "Deceased";
            this.deceasedBox.UseVisualStyleBackColor = false;
            this.deceasedBox.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(5, 4);
            this.maleButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(66, 23);
            this.maleButton.TabIndex = 14;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(5, 35);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(81, 23);
            this.femaleButton.TabIndex = 15;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.maleButton);
            this.panel1.Controls.Add(this.femaleButton);
            this.panel1.Location = new System.Drawing.Point(14, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 100);
            this.panel1.TabIndex = 16;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 66);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 23);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Any";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.adultButton);
            this.panel2.Controls.Add(this.childButton);
            this.panel2.Location = new System.Drawing.Point(120, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 100);
            this.panel2.TabIndex = 17;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 66);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 23);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Any";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // adultButton
            // 
            this.adultButton.AutoSize = true;
            this.adultButton.Location = new System.Drawing.Point(5, 4);
            this.adultButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.adultButton.Name = "adultButton";
            this.adultButton.Size = new System.Drawing.Size(76, 23);
            this.adultButton.TabIndex = 14;
            this.adultButton.TabStop = true;
            this.adultButton.Text = "Adult";
            this.adultButton.UseVisualStyleBackColor = true;
            this.adultButton.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // childButton
            // 
            this.childButton.AutoSize = true;
            this.childButton.Location = new System.Drawing.Point(5, 35);
            this.childButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.childButton.Name = "childButton";
            this.childButton.Size = new System.Drawing.Size(70, 23);
            this.childButton.TabIndex = 15;
            this.childButton.TabStop = true;
            this.childButton.Text = "Child";
            this.childButton.UseVisualStyleBackColor = true;
            this.childButton.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.employedButton);
            this.panel3.Controls.Add(this.unemployedButton);
            this.panel3.Location = new System.Drawing.Point(226, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 100);
            this.panel3.TabIndex = 18;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 66);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 23);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Any";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // employedButton
            // 
            this.employedButton.AutoSize = true;
            this.employedButton.Location = new System.Drawing.Point(5, 4);
            this.employedButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.employedButton.Name = "employedButton";
            this.employedButton.Size = new System.Drawing.Size(102, 23);
            this.employedButton.TabIndex = 14;
            this.employedButton.TabStop = true;
            this.employedButton.Text = "Employed";
            this.employedButton.UseVisualStyleBackColor = true;
            this.employedButton.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // unemployedButton
            // 
            this.unemployedButton.AutoSize = true;
            this.unemployedButton.Location = new System.Drawing.Point(5, 35);
            this.unemployedButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.unemployedButton.Name = "unemployedButton";
            this.unemployedButton.Size = new System.Drawing.Size(121, 23);
            this.unemployedButton.TabIndex = 15;
            this.unemployedButton.TabStop = true;
            this.unemployedButton.Text = "Unemployed";
            this.unemployedButton.UseVisualStyleBackColor = true;
            this.unemployedButton.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // DoodInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TownManager.Properties.Resources.parchment_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 559);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imprisonedBox);
            this.Controls.Add(this.deceasedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.doodBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortSelector);
            this.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DoodInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doodInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sortSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox doodBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox imprisonedBox;
        private System.Windows.Forms.CheckBox deceasedBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton adultButton;
        private System.Windows.Forms.RadioButton childButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton employedButton;
        private System.Windows.Forms.RadioButton unemployedButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}