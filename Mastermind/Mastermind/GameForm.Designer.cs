
namespace Mastermind
{
    partial class GameForm
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
            this.game = new System.Windows.Forms.Panel();
            this.colorSlector = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // game
            // 
            this.game.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.game.Location = new System.Drawing.Point(12, 12);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(369, 666);
            this.game.TabIndex = 0;
            this.game.Paint += new System.Windows.Forms.PaintEventHandler(this.game_Paint);
            this.game.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            // 
            // colorSlector
            // 
            this.colorSlector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSlector.Location = new System.Drawing.Point(12, 684);
            this.colorSlector.Name = "colorSlector";
            this.colorSlector.Size = new System.Drawing.Size(369, 65);
            this.colorSlector.TabIndex = 1;
            this.colorSlector.Paint += new System.Windows.Forms.PaintEventHandler(this.colorSlector_Paint);
            this.colorSlector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorSlector_MouseUp);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 761);
            this.Controls.Add(this.colorSlector);
            this.Controls.Add(this.game);
            this.Name = "GameForm";
            this.Text = "Mastermind";
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel game;
        private System.Windows.Forms.Panel colorSlector;
    }
}

