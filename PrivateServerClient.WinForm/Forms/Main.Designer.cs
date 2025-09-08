namespace PrivateServerClient.WinForm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTabControls = new TabControl();
            globalLeaderboardListTab = new TabPage();
            globalLeaderboardList = new ListBox();
            bestPerformanceTab = new TabPage();
            bestPerformanceList = new ListBox();
            playHistoryTab = new TabPage();
            playingHistoryList = new ListBox();
            serverEndpoint = new TextBox();
            modeComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            getLeaderboardDataButton = new Button();
            getUserDataButton = new Button();
            userIdBox = new TextBox();
            label4 = new Label();
            mainTabControls.SuspendLayout();
            globalLeaderboardListTab.SuspendLayout();
            bestPerformanceTab.SuspendLayout();
            playHistoryTab.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControls
            // 
            mainTabControls.Controls.Add(globalLeaderboardListTab);
            mainTabControls.Controls.Add(bestPerformanceTab);
            mainTabControls.Controls.Add(playHistoryTab);
            mainTabControls.Font = new Font("Yu Gothic UI", 12F);
            mainTabControls.Location = new Point(12, 68);
            mainTabControls.Name = "mainTabControls";
            mainTabControls.SelectedIndex = 0;
            mainTabControls.Size = new Size(967, 514);
            mainTabControls.TabIndex = 0;
            // 
            // globalLeaderboardListTab
            // 
            globalLeaderboardListTab.Controls.Add(globalLeaderboardList);
            globalLeaderboardListTab.Location = new Point(4, 30);
            globalLeaderboardListTab.Name = "globalLeaderboardListTab";
            globalLeaderboardListTab.Padding = new Padding(3);
            globalLeaderboardListTab.Size = new Size(959, 480);
            globalLeaderboardListTab.TabIndex = 0;
            globalLeaderboardListTab.Text = "グローバルリーダーボード";
            globalLeaderboardListTab.UseVisualStyleBackColor = true;
            // 
            // globalLeaderboardList
            // 
            globalLeaderboardList.Font = new Font("Yu Gothic UI", 15F);
            globalLeaderboardList.FormattingEnabled = true;
            globalLeaderboardList.HorizontalScrollbar = true;
            globalLeaderboardList.ItemHeight = 28;
            globalLeaderboardList.Location = new Point(0, 0);
            globalLeaderboardList.Name = "globalLeaderboardList";
            globalLeaderboardList.Size = new Size(959, 480);
            globalLeaderboardList.TabIndex = 0;
            globalLeaderboardList.MouseDown += GlobalLeaderboardList_MouseDown;
            // 
            // bestPerformanceTab
            // 
            bestPerformanceTab.Controls.Add(bestPerformanceList);
            bestPerformanceTab.Location = new Point(4, 30);
            bestPerformanceTab.Name = "bestPerformanceTab";
            bestPerformanceTab.Padding = new Padding(3);
            bestPerformanceTab.Size = new Size(959, 480);
            bestPerformanceTab.TabIndex = 1;
            bestPerformanceTab.Text = "PPランキング";
            bestPerformanceTab.UseVisualStyleBackColor = true;
            // 
            // bestPerformanceList
            // 
            bestPerformanceList.Font = new Font("Yu Gothic UI", 15F);
            bestPerformanceList.FormattingEnabled = true;
            bestPerformanceList.HorizontalScrollbar = true;
            bestPerformanceList.ItemHeight = 28;
            bestPerformanceList.Location = new Point(0, 0);
            bestPerformanceList.Name = "bestPerformanceList";
            bestPerformanceList.Size = new Size(959, 480);
            bestPerformanceList.TabIndex = 0;
            bestPerformanceList.MouseDown += BestPerformanceList_MouseDown;
            // 
            // playHistoryTab
            // 
            playHistoryTab.Controls.Add(playingHistoryList);
            playHistoryTab.Location = new Point(4, 30);
            playHistoryTab.Name = "playHistoryTab";
            playHistoryTab.Size = new Size(959, 480);
            playHistoryTab.TabIndex = 2;
            playHistoryTab.Text = "プレイ履歴";
            playHistoryTab.UseVisualStyleBackColor = true;
            // 
            // playingHistoryList
            // 
            playingHistoryList.Font = new Font("Yu Gothic UI", 15F);
            playingHistoryList.FormattingEnabled = true;
            playingHistoryList.HorizontalScrollbar = true;
            playingHistoryList.ItemHeight = 28;
            playingHistoryList.Location = new Point(0, 0);
            playingHistoryList.Name = "playingHistoryList";
            playingHistoryList.Size = new Size(959, 480);
            playingHistoryList.TabIndex = 9;
            playingHistoryList.MouseDown += PlayingHistoryList_MouseDown;
            // 
            // serverEndpoint
            // 
            serverEndpoint.Font = new Font("Yu Gothic UI", 11F);
            serverEndpoint.Location = new Point(16, 33);
            serverEndpoint.Name = "serverEndpoint";
            serverEndpoint.PlaceholderText = "server.net";
            serverEndpoint.Size = new Size(297, 27);
            serverEndpoint.TabIndex = 1;
            // 
            // modeComboBox
            // 
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.Font = new Font("Yu Gothic UI", 11F);
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Items.AddRange(new object[] { "Standard", "Taiko", "Catch", "Mania", "Standard(RX)", "Taiko(RX)", "Catch(RX)" });
            modeComboBox.Location = new Point(357, 33);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(148, 28);
            modeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 3;
            label1.Text = "サーバーAPIエンドポイント";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F);
            label2.Location = new Point(357, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 4;
            label2.Text = "Mode";
            // 
            // getLeaderboardDataButton
            // 
            getLeaderboardDataButton.Font = new Font("Yu Gothic UI", 10F);
            getLeaderboardDataButton.Location = new Point(804, 9);
            getLeaderboardDataButton.Name = "getLeaderboardDataButton";
            getLeaderboardDataButton.Size = new Size(171, 33);
            getLeaderboardDataButton.TabIndex = 7;
            getLeaderboardDataButton.Text = "リーダーボードデータ更新";
            getLeaderboardDataButton.UseVisualStyleBackColor = true;
            getLeaderboardDataButton.Click += GetLeaderboardDataButton_Click;
            // 
            // getUserDataButton
            // 
            getUserDataButton.Font = new Font("Yu Gothic UI", 10F);
            getUserDataButton.Location = new Point(804, 48);
            getUserDataButton.Name = "getUserDataButton";
            getUserDataButton.Size = new Size(171, 35);
            getUserDataButton.TabIndex = 11;
            getUserDataButton.Text = "ユーザーデータ取得";
            getUserDataButton.UseVisualStyleBackColor = true;
            getUserDataButton.Click += GetUserDataButton_Click;
            // 
            // userIdBox
            // 
            userIdBox.Font = new Font("Yu Gothic UI", 11F);
            userIdBox.Location = new Point(526, 35);
            userIdBox.Name = "userIdBox";
            userIdBox.PlaceholderText = "123456";
            userIdBox.Size = new Size(141, 27);
            userIdBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(526, 8);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 9;
            label4.Text = "ユーザーID";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 594);
            Controls.Add(getUserDataButton);
            Controls.Add(getLeaderboardDataButton);
            Controls.Add(label2);
            Controls.Add(userIdBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(modeComboBox);
            Controls.Add(serverEndpoint);
            Controls.Add(mainTabControls);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Private Server API Client";
            mainTabControls.ResumeLayout(false);
            globalLeaderboardListTab.ResumeLayout(false);
            bestPerformanceTab.ResumeLayout(false);
            playHistoryTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl mainTabControls;
        private TabPage globalLeaderboardListTab;
        private TabPage bestPerformanceTab;
        private TextBox serverEndpoint;
        private ComboBox modeComboBox;
        private Label label1;
        private Label label2;
        private TextBox userIdBox;
        private Button getLeaderboardDataButton;
        private ListBox globalLeaderboardList;
        private ListBox bestPerformanceList;
        private Button getUserDataButton;
        private TabPage playHistoryTab;
        private ListBox playingHistoryList;
        private Label label4;
    }
}
