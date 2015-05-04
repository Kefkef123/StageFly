namespace StageFly
{
    partial class StageFlyForm
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
            this.PlayerIdLabel = new System.Windows.Forms.Label();
            this.PlayerIdTextBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerIdLabel
            // 
            this.PlayerIdLabel.AutoSize = true;
            this.PlayerIdLabel.Location = new System.Drawing.Point(12, 13);
            this.PlayerIdLabel.Name = "PlayerIdLabel";
            this.PlayerIdLabel.Size = new System.Drawing.Size(53, 13);
            this.PlayerIdLabel.TabIndex = 0;
            this.PlayerIdLabel.Text = "Player ID:";
            // 
            // PlayerIdTextBox
            // 
            this.PlayerIdTextBox.Location = new System.Drawing.Point(72, 10);
            this.PlayerIdTextBox.Name = "PlayerIdTextBox";
            this.PlayerIdTextBox.Size = new System.Drawing.Size(59, 20);
            this.PlayerIdTextBox.TabIndex = 1;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 38);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(72, 38);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(59, 20);
            this.ScoreTextBox.TabIndex = 3;
            // 
            // SubmitButtom
            // 
            this.SubmitButtom.Location = new System.Drawing.Point(15, 64);
            this.SubmitButtom.Name = "SubmitButtom";
            this.SubmitButtom.Size = new System.Drawing.Size(116, 23);
            this.SubmitButtom.TabIndex = 4;
            this.SubmitButtom.Text = "Upload your score";
            this.SubmitButtom.UseVisualStyleBackColor = true;
            this.SubmitButtom.Click += new System.EventHandler(this.SubmitButtom_Click);
            // 
            // StageFlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 105);
            this.Controls.Add(this.SubmitButtom);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PlayerIdTextBox);
            this.Controls.Add(this.PlayerIdLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(159, 144);
            this.MinimumSize = new System.Drawing.Size(159, 144);
            this.Name = "StageFlyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerIdLabel;
        private System.Windows.Forms.TextBox PlayerIdTextBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Button SubmitButtom;
    }
}

