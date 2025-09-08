namespace PrivateServerClient.WinForm.SubForms
{
    partial class LeaderboardUserInfoForm
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
            usernameLabel = new Label();
            countryLabel = new Label();
            label3 = new Label();
            playerStatsLabel = new Label();
            additionalStatsLabel = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Yu Gothic UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 128);
            usernameLabel.Location = new Point(12, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(204, 54);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Yu Gothic UI", 16F);
            countryLabel.Location = new Point(12, 63);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(153, 30);
            countryLabel.TabIndex = 1;
            countryLabel.Text = "Country / Clan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11F);
            label3.Location = new Point(392, 113);
            label3.Name = "label3";
            label3.Size = new Size(121, 100);
            label3.TabIndex = 2;
            label3.Text = "合計Rankedスコア\r\n精度\r\nプレイ回数\r\n合計スコア\r\n最大コンボ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // playerStatsLabel
            // 
            playerStatsLabel.Font = new Font("Yu Gothic UI", 11F);
            playerStatsLabel.Location = new Point(558, 113);
            playerStatsLabel.Name = "playerStatsLabel";
            playerStatsLabel.Size = new Size(121, 100);
            playerStatsLabel.TabIndex = 3;
            playerStatsLabel.Text = "123456\r\n99.23%\r\n12345\r\n1234567\r\n2000";
            playerStatsLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // additionalStatsLabel
            // 
            additionalStatsLabel.AutoSize = true;
            additionalStatsLabel.Font = new Font("Yu Gothic UI", 20F);
            additionalStatsLabel.Location = new Point(12, 176);
            additionalStatsLabel.Name = "additionalStatsLabel";
            additionalStatsLabel.Size = new Size(210, 37);
            additionalStatsLabel.TabIndex = 4;
            additionalStatsLabel.Text = "合計PP: 100,000";
            // 
            // LeaderboardUserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 226);
            Controls.Add(additionalStatsLabel);
            Controls.Add(playerStatsLabel);
            Controls.Add(label3);
            Controls.Add(countryLabel);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LeaderboardUserInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeaderboardUserInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label countryLabel;
        private Label label3;
        private Label playerStatsLabel;
        private Label additionalStatsLabel;
    }
}