
namespace CarGameUI
{
    partial class GameOverForm
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
            this.components = new System.ComponentModel.Container();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.CollectedCoinsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HiscoreButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(85, 9);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(148, 32);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over!";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.Location = new System.Drawing.Point(12, 93);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(105, 38);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Try Again";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // CollectedCoinsLabel
            // 
            this.CollectedCoinsLabel.AutoSize = true;
            this.CollectedCoinsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CollectedCoinsLabel.Location = new System.Drawing.Point(79, 59);
            this.CollectedCoinsLabel.Name = "CollectedCoinsLabel";
            this.CollectedCoinsLabel.Size = new System.Drawing.Size(161, 25);
            this.CollectedCoinsLabel.TabIndex = 2;
            this.CollectedCoinsLabel.Text = "You Got : 10 coins";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(202, 93);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(105, 38);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HiscoreButton
            // 
            this.HiscoreButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HiscoreButton.Location = new System.Drawing.Point(104, 137);
            this.HiscoreButton.Name = "HiscoreButton";
            this.HiscoreButton.Size = new System.Drawing.Size(105, 38);
            this.HiscoreButton.TabIndex = 4;
            this.HiscoreButton.Text = "Hiscores";
            this.HiscoreButton.UseVisualStyleBackColor = true;
            this.HiscoreButton.Click += new System.EventHandler(this.HiscoreButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(319, 178);
            this.Controls.Add(this.HiscoreButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CollectedCoinsLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.GameOverLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameOverForm";
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.GameOverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label CollectedCoinsLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HiscoreButton;
        internal System.Windows.Forms.Timer timer1;
    }
}