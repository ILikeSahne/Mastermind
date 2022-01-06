
namespace Mastermind
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modeHardButton = new System.Windows.Forms.RadioButton();
            this.modeMiddleButton = new System.Windows.Forms.RadioButton();
            this.modeEasyButton = new System.Windows.Forms.RadioButton();
            this.modeCustomButton = new System.Windows.Forms.RadioButton();
            this.amountTriesLabel = new System.Windows.Forms.Label();
            this.amountTries = new System.Windows.Forms.NumericUpDown();
            this.amountRows = new System.Windows.Forms.NumericUpDown();
            this.amountRowsLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.modeHardHighscoreLabel = new System.Windows.Forms.Label();
            this.modeMiddleHighscoreLabel = new System.Windows.Forms.Label();
            this.modeEasyHighscoreLabel = new System.Windows.Forms.Label();
            this.modeHardWinStreakLabel = new System.Windows.Forms.Label();
            this.modeMiddleWinStreakLabel = new System.Windows.Forms.Label();
            this.modeEasyWinStreakLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountTries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountRows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How to Play";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(337, 190);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Einstellungen";
            // 
            // modeHardButton
            // 
            this.modeHardButton.AutoSize = true;
            this.modeHardButton.Location = new System.Drawing.Point(15, 269);
            this.modeHardButton.Name = "modeHardButton";
            this.modeHardButton.Size = new System.Drawing.Size(48, 17);
            this.modeHardButton.TabIndex = 3;
            this.modeHardButton.TabStop = true;
            this.modeHardButton.Text = "Hard";
            this.modeHardButton.UseVisualStyleBackColor = true;
            this.modeHardButton.CheckedChanged += new System.EventHandler(this.modeButton_CheckedChanged);
            // 
            // modeMiddleButton
            // 
            this.modeMiddleButton.AutoSize = true;
            this.modeMiddleButton.Location = new System.Drawing.Point(15, 292);
            this.modeMiddleButton.Name = "modeMiddleButton";
            this.modeMiddleButton.Size = new System.Drawing.Size(56, 17);
            this.modeMiddleButton.TabIndex = 4;
            this.modeMiddleButton.TabStop = true;
            this.modeMiddleButton.Text = "Middle";
            this.modeMiddleButton.UseVisualStyleBackColor = true;
            this.modeMiddleButton.CheckedChanged += new System.EventHandler(this.modeButton_CheckedChanged);
            // 
            // modeEasyButton
            // 
            this.modeEasyButton.AutoSize = true;
            this.modeEasyButton.Location = new System.Drawing.Point(15, 315);
            this.modeEasyButton.Name = "modeEasyButton";
            this.modeEasyButton.Size = new System.Drawing.Size(48, 17);
            this.modeEasyButton.TabIndex = 5;
            this.modeEasyButton.TabStop = true;
            this.modeEasyButton.Text = "Easy";
            this.modeEasyButton.UseVisualStyleBackColor = true;
            this.modeEasyButton.CheckedChanged += new System.EventHandler(this.modeButton_CheckedChanged);
            // 
            // modeCustomButton
            // 
            this.modeCustomButton.AutoSize = true;
            this.modeCustomButton.Location = new System.Drawing.Point(15, 338);
            this.modeCustomButton.Name = "modeCustomButton";
            this.modeCustomButton.Size = new System.Drawing.Size(60, 17);
            this.modeCustomButton.TabIndex = 6;
            this.modeCustomButton.TabStop = true;
            this.modeCustomButton.Text = "Custom";
            this.modeCustomButton.UseVisualStyleBackColor = true;
            this.modeCustomButton.CheckedChanged += new System.EventHandler(this.modeButton_CheckedChanged);
            // 
            // amountTriesLabel
            // 
            this.amountTriesLabel.AutoSize = true;
            this.amountTriesLabel.Enabled = false;
            this.amountTriesLabel.Location = new System.Drawing.Point(12, 378);
            this.amountTriesLabel.Name = "amountTriesLabel";
            this.amountTriesLabel.Size = new System.Drawing.Size(52, 13);
            this.amountTriesLabel.TabIndex = 7;
            this.amountTriesLabel.Text = "Versuche";
            // 
            // amountTries
            // 
            this.amountTries.Enabled = false;
            this.amountTries.Location = new System.Drawing.Point(12, 394);
            this.amountTries.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountTries.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.amountTries.Name = "amountTries";
            this.amountTries.Size = new System.Drawing.Size(120, 20);
            this.amountTries.TabIndex = 8;
            this.amountTries.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // amountRows
            // 
            this.amountRows.Enabled = false;
            this.amountRows.Location = new System.Drawing.Point(12, 433);
            this.amountRows.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.amountRows.Name = "amountRows";
            this.amountRows.Size = new System.Drawing.Size(120, 20);
            this.amountRows.TabIndex = 10;
            this.amountRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // amountRowsLabel
            // 
            this.amountRowsLabel.AutoSize = true;
            this.amountRowsLabel.Enabled = false;
            this.amountRowsLabel.Location = new System.Drawing.Point(12, 417);
            this.amountRowsLabel.Name = "amountRowsLabel";
            this.amountRowsLabel.Size = new System.Drawing.Size(152, 13);
            this.amountRowsLabel.TabIndex = 9;
            this.amountRowsLabel.Text = "Anzahl zu platzierender Farben";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(12, 483);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(117, 23);
            this.startGameButton.TabIndex = 11;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // modeHardHighscoreLabel
            // 
            this.modeHardHighscoreLabel.AutoSize = true;
            this.modeHardHighscoreLabel.ForeColor = System.Drawing.Color.Silver;
            this.modeHardHighscoreLabel.Location = new System.Drawing.Point(115, 271);
            this.modeHardHighscoreLabel.Name = "modeHardHighscoreLabel";
            this.modeHardHighscoreLabel.Size = new System.Drawing.Size(67, 13);
            this.modeHardHighscoreLabel.TabIndex = 12;
            this.modeHardHighscoreLabel.Text = "Highscore: 0";
            // 
            // modeMiddleHighscoreLabel
            // 
            this.modeMiddleHighscoreLabel.AutoSize = true;
            this.modeMiddleHighscoreLabel.ForeColor = System.Drawing.Color.Silver;
            this.modeMiddleHighscoreLabel.Location = new System.Drawing.Point(115, 294);
            this.modeMiddleHighscoreLabel.Name = "modeMiddleHighscoreLabel";
            this.modeMiddleHighscoreLabel.Size = new System.Drawing.Size(67, 13);
            this.modeMiddleHighscoreLabel.TabIndex = 13;
            this.modeMiddleHighscoreLabel.Text = "Highscore: 0";
            // 
            // modeEasyHighscoreLabel
            // 
            this.modeEasyHighscoreLabel.AutoSize = true;
            this.modeEasyHighscoreLabel.ForeColor = System.Drawing.Color.Silver;
            this.modeEasyHighscoreLabel.Location = new System.Drawing.Point(115, 317);
            this.modeEasyHighscoreLabel.Name = "modeEasyHighscoreLabel";
            this.modeEasyHighscoreLabel.Size = new System.Drawing.Size(67, 13);
            this.modeEasyHighscoreLabel.TabIndex = 14;
            this.modeEasyHighscoreLabel.Text = "Highscore: 0";
            // 
            // modeHardWinStreakLabel
            // 
            this.modeHardWinStreakLabel.AutoSize = true;
            this.modeHardWinStreakLabel.ForeColor = System.Drawing.Color.Silver;
            this.modeHardWinStreakLabel.Location = new System.Drawing.Point(215, 271);
            this.modeHardWinStreakLabel.Name = "modeHardWinStreakLabel";
            this.modeHardWinStreakLabel.Size = new System.Drawing.Size(72, 13);
            this.modeHardWinStreakLabel.TabIndex = 15;
            this.modeHardWinStreakLabel.Text = "Win Streak: 0";
            // 
            // modeMiddleWinStreakLabel
            // 
            this.modeMiddleWinStreakLabel.AutoSize = true;
            this.modeMiddleWinStreakLabel.ForeColor = System.Drawing.Color.Silver;
            this.modeMiddleWinStreakLabel.Location = new System.Drawing.Point(215, 294);
            this.modeMiddleWinStreakLabel.Name = "modeMiddleWinStreakLabel";
            this.modeMiddleWinStreakLabel.Size = new System.Drawing.Size(72, 13);
            this.modeMiddleWinStreakLabel.TabIndex = 16;
            this.modeMiddleWinStreakLabel.Text = "Win Streak: 0";
            // 
            // modeEasyWinStreakLabel
            // 
            this.modeEasyWinStreakLabel.AutoSize = true;
            this.modeEasyWinStreakLabel.ForeColor = System.Drawing.Color.Silver;
            this.modeEasyWinStreakLabel.Location = new System.Drawing.Point(215, 317);
            this.modeEasyWinStreakLabel.Name = "modeEasyWinStreakLabel";
            this.modeEasyWinStreakLabel.Size = new System.Drawing.Size(72, 13);
            this.modeEasyWinStreakLabel.TabIndex = 17;
            this.modeEasyWinStreakLabel.Text = "Win Streak: 0";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 521);
            this.Controls.Add(this.modeEasyWinStreakLabel);
            this.Controls.Add(this.modeMiddleWinStreakLabel);
            this.Controls.Add(this.modeHardWinStreakLabel);
            this.Controls.Add(this.modeEasyHighscoreLabel);
            this.Controls.Add(this.modeMiddleHighscoreLabel);
            this.Controls.Add(this.modeHardHighscoreLabel);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.amountRows);
            this.Controls.Add(this.amountRowsLabel);
            this.Controls.Add(this.amountTries);
            this.Controls.Add(this.amountTriesLabel);
            this.Controls.Add(this.modeCustomButton);
            this.Controls.Add(this.modeEasyButton);
            this.Controls.Add(this.modeMiddleButton);
            this.Controls.Add(this.modeHardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.amountTries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton modeHardButton;
        private System.Windows.Forms.RadioButton modeMiddleButton;
        private System.Windows.Forms.RadioButton modeEasyButton;
        private System.Windows.Forms.RadioButton modeCustomButton;
        private System.Windows.Forms.Label amountTriesLabel;
        private System.Windows.Forms.NumericUpDown amountTries;
        private System.Windows.Forms.NumericUpDown amountRows;
        private System.Windows.Forms.Label amountRowsLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label modeHardHighscoreLabel;
        private System.Windows.Forms.Label modeMiddleHighscoreLabel;
        private System.Windows.Forms.Label modeEasyHighscoreLabel;
        private System.Windows.Forms.Label modeHardWinStreakLabel;
        private System.Windows.Forms.Label modeMiddleWinStreakLabel;
        private System.Windows.Forms.Label modeEasyWinStreakLabel;
    }
}