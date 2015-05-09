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
            this.CityLabel = new System.Windows.Forms.Label();
            this.CitiesComboBox = new System.Windows.Forms.ComboBox();
            this.TopPlayersBox = new System.Windows.Forms.ListBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.CitiesComboBox.Location = new System.Drawing.Point(72, 65);
            this.CitiesComboBox.Name = "CitiesComboBox";
            this.CitiesComboBox.Size = new System.Drawing.Size(75, 21);
            this.CitiesComboBox.TabIndex = 6;
            this.CitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.CitiesComboBox_SelectedIndexChanged);
            // 
            // TopPlayersBox
            // 
            this.TopPlayersBox.FormattingEnabled = true;
            this.TopPlayersBox.Location = new System.Drawing.Point(203, 10);
            this.TopPlayersBox.Name = "TopPlayersBox";
            this.TopPlayersBox.Size = new System.Drawing.Size(167, 329);
            this.TopPlayersBox.TabIndex = 7;
            this.TopPlayersBox.SelectedIndexChanged += new System.EventHandler(this.TopPlayersBox_SelectedIndexChanged);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(153, 13);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(44, 13);
            this.TopLabel.TabIndex = 8;
            this.TopLabel.Text = "Top 25:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "To get player Id,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Paste the following in your URL bar\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "javascript:alert(document.cookie)";
            // 
            // StageFlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 355);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.TopPlayersBox);
            this.Controls.Add(this.CitiesComboBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.SubmitButtom);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PlayerIdTextBox);
            this.Controls.Add(this.PlayerIdLabel);
            this.MaximizeBox = false;
            this.Name = "StageFlyForm";
            this.Text = "StageFly";
            this.Load += new System.EventHandler(this.StageFlyForm_Load);
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
        private System.Windows.Forms.ListBox TopPlayersBox;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}