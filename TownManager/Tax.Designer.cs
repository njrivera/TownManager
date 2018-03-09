namespace TownManager
{
    partial class Tax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tax));
            this.label1 = new System.Windows.Forms.Label();
            this.crimeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.taxNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected Crime Rate:";
            // 
            // crimeLabel
            // 
            this.crimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.crimeLabel.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeLabel.Location = new System.Drawing.Point(124, 27);
            this.crimeLabel.Name = "crimeLabel";
            this.crimeLabel.Size = new System.Drawing.Size(49, 19);
            this.crimeLabel.TabIndex = 1;
            this.crimeLabel.Text = "0";
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(96, 106);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // taxNum
            // 
            this.taxNum.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.taxNum.Location = new System.Drawing.Point(52, 59);
            this.taxNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.taxNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.taxNum.Name = "taxNum";
            this.taxNum.ReadOnly = true;
            this.taxNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taxNum.Size = new System.Drawing.Size(44, 32);
            this.taxNum.TabIndex = 7;
            this.taxNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.taxNum.ValueChanged += new System.EventHandler(this.taxNum_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // resetButton
            // 
            this.resetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetButton.BackgroundImage")));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(12, 106);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TownManager.Properties.Resources.patterns_lines_bright_color_surface_texture_50511_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(187, 141);
            this.ControlBox = false;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taxNum);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.crimeLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax";
            ((System.ComponentModel.ISupportInitialize)(this.taxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label crimeLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.NumericUpDown taxNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetButton;
    }
}