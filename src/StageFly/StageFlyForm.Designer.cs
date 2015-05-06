﻿namespace StageFly
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
            this.CityLabel = new System.Windows.Forms.Label();
            this.CitiesComboBox = new System.Windows.Forms.ComboBox();
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
            this.PlayerIdTextBox.Size = new System.Drawing.Size(75, 20);
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
            this.ScoreTextBox.Size = new System.Drawing.Size(75, 20);
            this.ScoreTextBox.TabIndex = 3;
            // 
            // SubmitButtom
            // 
            this.SubmitButtom.Location = new System.Drawing.Point(15, 91);
            this.SubmitButtom.Name = "SubmitButtom";
            this.SubmitButtom.Size = new System.Drawing.Size(132, 23);
            this.SubmitButtom.TabIndex = 4;
            this.SubmitButtom.Text = "Upload your score";
            this.SubmitButtom.UseVisualStyleBackColor = true;
            this.SubmitButtom.Click += new System.EventHandler(this.SubmitButtom_Click);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(12, 68);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City:";
            // 
            // CitiesComboBox
            // 
            this.CitiesComboBox.FormattingEnabled = true;
            this.CitiesComboBox.Items.AddRange(new object[] {
            "Breda",
            "Maastricht",
            "Lelystad",
            "Den Bosch",
            "Try out"});
            this.CitiesComboBox.Location = new System.Drawing.Point(72, 65);
            this.CitiesComboBox.Name = "CitiesComboBox";
            this.CitiesComboBox.Size = new System.Drawing.Size(75, 21);
            this.CitiesComboBox.TabIndex = 6;
            // 
            // StageFlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 126);
            this.Controls.Add(this.CitiesComboBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.SubmitButtom);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PlayerIdTextBox);
            this.Controls.Add(this.PlayerIdLabel);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.ComboBox CitiesComboBox;
    }
}

