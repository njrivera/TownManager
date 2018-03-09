namespace TownManager
{
    partial class Main
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
            this.newButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newGamePanel = new System.Windows.Forms.Panel();
            this.stoneNum = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.woodNum = new System.Windows.Forms.NumericUpDown();
            this.prisonBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barracksBox = new System.Windows.Forms.CheckBox();
            this.foodNum = new System.Windows.Forms.NumericUpDown();
            this.marketBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ironNum = new System.Windows.Forms.NumericUpDown();
            this.popNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goldNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.newGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ironNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldNum)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(243, 334);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(120, 50);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New Game";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(495, 334);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(120, 50);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(369, 334);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(120, 50);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Game";
            this.loadButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("French Script MT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(238, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 109);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dux Fortis";
            // 
            // newGamePanel
            // 
            this.newGamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGamePanel.BackColor = System.Drawing.Color.Transparent;
            this.newGamePanel.BackgroundImage = global::TownManager.Properties.Resources.BpGpDoP;
            this.newGamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newGamePanel.Controls.Add(this.stoneNum);
            this.newGamePanel.Controls.Add(this.cancelButton);
            this.newGamePanel.Controls.Add(this.label6);
            this.newGamePanel.Controls.Add(this.startButton);
            this.newGamePanel.Controls.Add(this.woodNum);
            this.newGamePanel.Controls.Add(this.prisonBox);
            this.newGamePanel.Controls.Add(this.label4);
            this.newGamePanel.Controls.Add(this.barracksBox);
            this.newGamePanel.Controls.Add(this.foodNum);
            this.newGamePanel.Controls.Add(this.marketBox);
            this.newGamePanel.Controls.Add(this.label5);
            this.newGamePanel.Controls.Add(this.ironNum);
            this.newGamePanel.Controls.Add(this.popNum);
            this.newGamePanel.Controls.Add(this.label3);
            this.newGamePanel.Controls.Add(this.label2);
            this.newGamePanel.Controls.Add(this.goldNum);
            this.newGamePanel.Controls.Add(this.label7);
            this.newGamePanel.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGamePanel.Location = new System.Drawing.Point(243, 81);
            this.newGamePanel.Name = "newGamePanel";
            this.newGamePanel.Size = new System.Drawing.Size(372, 361);
            this.newGamePanel.TabIndex = 17;
            this.newGamePanel.Visible = false;
            // 
            // stoneNum
            // 
            this.stoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stoneNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stoneNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stoneNum.Location = new System.Drawing.Point(128, 209);
            this.stoneNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.stoneNum.Name = "stoneNum";
            this.stoneNum.Size = new System.Drawing.Size(78, 26);
            this.stoneNum.TabIndex = 11;
            this.stoneNum.Value = new decimal(new int[] {
            80999,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.Location = new System.Drawing.Point(200, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(68, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stone";
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startButton.Location = new System.Drawing.Point(118, 273);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 25);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // woodNum
            // 
            this.woodNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.woodNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.woodNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.woodNum.Location = new System.Drawing.Point(128, 181);
            this.woodNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.woodNum.Name = "woodNum";
            this.woodNum.Size = new System.Drawing.Size(78, 26);
            this.woodNum.TabIndex = 9;
            this.woodNum.Value = new decimal(new int[] {
            10099,
            0,
            0,
            0});
            // 
            // prisonBox
            // 
            this.prisonBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prisonBox.AutoSize = true;
            this.prisonBox.BackColor = System.Drawing.Color.Transparent;
            this.prisonBox.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonBox.Location = new System.Drawing.Point(219, 191);
            this.prisonBox.Name = "prisonBox";
            this.prisonBox.Size = new System.Drawing.Size(79, 23);
            this.prisonBox.TabIndex = 13;
            this.prisonBox.Text = "Prison";
            this.prisonBox.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(68, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wood";
            // 
            // barracksBox
            // 
            this.barracksBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barracksBox.AutoSize = true;
            this.barracksBox.BackColor = System.Drawing.Color.Transparent;
            this.barracksBox.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barracksBox.Location = new System.Drawing.Point(219, 166);
            this.barracksBox.Name = "barracksBox";
            this.barracksBox.Size = new System.Drawing.Size(104, 23);
            this.barracksBox.TabIndex = 12;
            this.barracksBox.Text = "Barracks";
            this.barracksBox.UseVisualStyleBackColor = false;
            // 
            // foodNum
            // 
            this.foodNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.foodNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foodNum.Location = new System.Drawing.Point(128, 153);
            this.foodNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.foodNum.Name = "foodNum";
            this.foodNum.Size = new System.Drawing.Size(78, 26);
            this.foodNum.TabIndex = 7;
            this.foodNum.Value = new decimal(new int[] {
            50099,
            0,
            0,
            0});
            // 
            // marketBox
            // 
            this.marketBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.marketBox.AutoSize = true;
            this.marketBox.BackColor = System.Drawing.Color.Transparent;
            this.marketBox.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketBox.Location = new System.Drawing.Point(219, 142);
            this.marketBox.Name = "marketBox";
            this.marketBox.Size = new System.Drawing.Size(87, 23);
            this.marketBox.TabIndex = 11;
            this.marketBox.Text = "Market";
            this.marketBox.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(68, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Food";
            // 
            // ironNum
            // 
            this.ironNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ironNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ironNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ironNum.Location = new System.Drawing.Point(128, 237);
            this.ironNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ironNum.Name = "ironNum";
            this.ironNum.Size = new System.Drawing.Size(78, 26);
            this.ironNum.TabIndex = 5;
            this.ironNum.Value = new decimal(new int[] {
            60999,
            0,
            0,
            0});
            // 
            // popNum
            // 
            this.popNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.popNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.popNum.Location = new System.Drawing.Point(251, 82);
            this.popNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.popNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.popNum.Name = "popNum";
            this.popNum.Size = new System.Drawing.Size(63, 26);
            this.popNum.TabIndex = 1;
            this.popNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(68, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iron";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(68, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Starting Population";
            // 
            // goldNum
            // 
            this.goldNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goldNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goldNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goldNum.Location = new System.Drawing.Point(128, 125);
            this.goldNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.goldNum.Name = "goldNum";
            this.goldNum.Size = new System.Drawing.Size(78, 26);
            this.goldNum.TabIndex = 3;
            this.goldNum.Value = new decimal(new int[] {
            20099,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(68, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gold";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::TownManager.Properties.Resources.kvasir_fortress_by_raphael_lacoste_d9f97yk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.ControlBox = false;
            this.Controls.Add(this.newGamePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Lobby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.newGamePanel.ResumeLayout(false);
            this.newGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoneNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ironNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel newGamePanel;
        private System.Windows.Forms.NumericUpDown stoneNum;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown woodNum;
        private System.Windows.Forms.CheckBox prisonBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox barracksBox;
        private System.Windows.Forms.NumericUpDown foodNum;
        private System.Windows.Forms.CheckBox marketBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ironNum;
        private System.Windows.Forms.NumericUpDown popNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown goldNum;
        private System.Windows.Forms.Label label7;
    }
}