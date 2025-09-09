namespace PrivateServerClient.WinForm.SubForms
{
    partial class ScoreInfoForm
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
            starsLabel = new Label();
            songNameLabel = new Label();
            ppLabel = new Label();
            label3 = new Label();
            scoreStatsLabel = new Label();
            SuspendLayout();
            // 
            // starsLabel
            // 
            starsLabel.AutoSize = true;
            starsLabel.Font = new Font("Yu Gothic UI", 16F);
            starsLabel.ImageAlign = ContentAlignment.MiddleLeft;
            starsLabel.Location = new Point(12, 63);
            starsLabel.Name = "starsLabel";
            starsLabel.Size = new Size(328, 30);
            starsLabel.TabIndex = 3;
            starsLabel.Text = "★8.50  [Version]  作者 Hoshino1";
            starsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // songNameLabel
            // 
            songNameLabel.AutoSize = true;
            songNameLabel.Font = new Font("Yu Gothic UI", 25F, FontStyle.Bold);
            songNameLabel.Location = new Point(12, 9);
            songNameLabel.Name = "songNameLabel";
            songNameLabel.Size = new Size(200, 46);
            songNameLabel.TabIndex = 2;
            songNameLabel.Text = "Song Name";
            // 
            // ppLabel
            // 
            ppLabel.Font = new Font("Yu Gothic UI", 40F, FontStyle.Bold);
            ppLabel.Location = new Point(319, 111);
            ppLabel.Name = "ppLabel";
            ppLabel.Size = new Size(469, 179);
            ppLabel.TabIndex = 5;
            ppLabel.Text = "1250pp";
            ppLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14F);
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(93, 175);
            label3.TabIndex = 6;
            label3.Text = "精度\r\n最大コンボ\r\nGreat\r\nOk\r\nMeh\r\nMiss\r\nMods";
            // 
            // scoreStatsLabel
            // 
            scoreStatsLabel.AutoSize = true;
            scoreStatsLabel.Font = new Font("Yu Gothic UI", 14F);
            scoreStatsLabel.Location = new Point(154, 115);
            scoreStatsLabel.Name = "scoreStatsLabel";
            scoreStatsLabel.Size = new Size(93, 175);
            scoreStatsLabel.TabIndex = 7;
            scoreStatsLabel.Text = "精度\r\n最大コンボ\r\nGreat\r\nOk\r\nMeh\r\nMiss\r\nMods";
            // 
            // ScoreInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 299);
            Controls.Add(scoreStatsLabel);
            Controls.Add(label3);
            Controls.Add(ppLabel);
            Controls.Add(starsLabel);
            Controls.Add(songNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ScoreInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label starsLabel;
        private Label songNameLabel;
        private Label ppLabel;
        private Label label3;
        private Label scoreStatsLabel;
    }
}