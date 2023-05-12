namespace Game2048App
{
    partial class MainForm
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
            scoreLabel = new Label();
            menuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            restartGameToolStripMenuItem = new ToolStripMenuItem();
            saveResultToolStripMenuItem = new ToolStripMenuItem();
            resultListToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            rulesGameToolStripMenuItem = new ToolStripMenuItem();
            userLabel = new Label();
            bestScoreTextLabel = new Label();
            bestScoreLabel = new Label();
            tableLayoutPanelTop = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            infoTextLabel = new Label();
            licenseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Dock = DockStyle.Left;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.Sienna;
            scoreLabel.Location = new Point(6, 30);
            scoreLabel.Margin = new Padding(6, 0, 3, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(19, 30);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.PaleGoldenrod;
            menuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(364, 29);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameToolStripMenuItem, saveResultToolStripMenuItem, resultListToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuToolStripMenuItem.ForeColor = Color.Sienna;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(70, 25);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // restartGameToolStripMenuItem
            // 
            restartGameToolStripMenuItem.ForeColor = Color.Sienna;
            restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            restartGameToolStripMenuItem.Size = new Size(244, 26);
            restartGameToolStripMenuItem.Text = "Начать сначала";
            restartGameToolStripMenuItem.Click += restartGameToolStripMenuItem_Click;
            // 
            // saveResultToolStripMenuItem
            // 
            saveResultToolStripMenuItem.ForeColor = Color.Sienna;
            saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            saveResultToolStripMenuItem.Size = new Size(244, 26);
            saveResultToolStripMenuItem.Text = "Сохранить результат";
            saveResultToolStripMenuItem.Click += saveResultToolStripMenuItem_Click;
            // 
            // resultListToolStripMenuItem
            // 
            resultListToolStripMenuItem.ForeColor = Color.Sienna;
            resultListToolStripMenuItem.Name = "resultListToolStripMenuItem";
            resultListToolStripMenuItem.Size = new Size(244, 26);
            resultListToolStripMenuItem.Text = "Список результатов";
            resultListToolStripMenuItem.Click += resultListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.Sienna;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(244, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesGameToolStripMenuItem, licenseToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            helpToolStripMenuItem.ForeColor = Color.Sienna;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(89, 25);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // rulesGameToolStripMenuItem
            // 
            rulesGameToolStripMenuItem.ForeColor = Color.Sienna;
            rulesGameToolStripMenuItem.Name = "rulesGameToolStripMenuItem";
            rulesGameToolStripMenuItem.Size = new Size(193, 26);
            rulesGameToolStripMenuItem.Text = "Правила игры";
            rulesGameToolStripMenuItem.Click += rulesGameToolStripMenuItem_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Dock = DockStyle.Left;
            userLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userLabel.ForeColor = Color.Sienna;
            userLabel.Location = new Point(3, 0);
            userLabel.Name = "userLabel";
            userLabel.Padding = new Padding(4, 2, 0, 0);
            userLabel.Size = new Size(68, 30);
            userLabel.TabIndex = 3;
            userLabel.Text = "Игрок:";
            // 
            // bestScoreTextLabel
            // 
            bestScoreTextLabel.AutoSize = true;
            bestScoreTextLabel.Dock = DockStyle.Right;
            bestScoreTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreTextLabel.ForeColor = Color.Sienna;
            bestScoreTextLabel.Location = new Point(289, 0);
            bestScoreTextLabel.Name = "bestScoreTextLabel";
            bestScoreTextLabel.Padding = new Padding(0, 2, 4, 0);
            bestScoreTextLabel.Size = new Size(72, 30);
            bestScoreTextLabel.TabIndex = 4;
            bestScoreTextLabel.Text = "Рекорд";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Dock = DockStyle.Right;
            bestScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreLabel.ForeColor = Color.Sienna;
            bestScoreLabel.Location = new Point(338, 30);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Padding = new Padding(0, 0, 4, 0);
            bestScoreLabel.Size = new Size(23, 30);
            bestScoreLabel.TabIndex = 6;
            bestScoreLabel.Text = "0";
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 2;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.Controls.Add(bestScoreLabel, 1, 1);
            tableLayoutPanelTop.Controls.Add(userLabel, 0, 0);
            tableLayoutPanelTop.Controls.Add(bestScoreTextLabel, 1, 0);
            tableLayoutPanelTop.Controls.Add(scoreLabel, 0, 1);
            tableLayoutPanelTop.Dock = DockStyle.Top;
            tableLayoutPanelTop.Location = new Point(0, 29);
            tableLayoutPanelTop.MinimumSize = new Size(241, 50);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 2;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.Size = new Size(364, 60);
            tableLayoutPanelTop.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.Controls.Add(infoTextLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(364, 31);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // infoTextLabel
            // 
            infoTextLabel.AutoSize = true;
            infoTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoTextLabel.ForeColor = Color.OrangeRed;
            infoTextLabel.Location = new Point(21, 6);
            infoTextLabel.Margin = new Padding(3, 6, 3, 0);
            infoTextLabel.Name = "infoTextLabel";
            infoTextLabel.Size = new Size(320, 21);
            infoTextLabel.TabIndex = 0;
            infoTextLabel.Text = "Соединяй числа и получи плитку 2048!";
            // 
            // licenseToolStripMenuItem
            // 
            licenseToolStripMenuItem.ForeColor = Color.Sienna;
            licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            licenseToolStripMenuItem.Size = new Size(193, 26);
            licenseToolStripMenuItem.Text = "Лицензия";
            licenseToolStripMenuItem.Click += licenseToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(364, 481);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelTop);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра 2048";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelTop.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label scoreLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem restartGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem rulesGameToolStripMenuItem;
        private ToolStripMenuItem saveResultToolStripMenuItem;
        private Label userLabel;
        private ToolStripMenuItem resultListToolStripMenuItem;
        private Label bestScoreTextLabel;
        private Label bestScoreLabel;
        private TableLayoutPanel tableLayoutPanelTop;
        private TableLayoutPanel tableLayoutPanel1;
        private Label infoTextLabel;
        private ToolStripMenuItem licenseToolStripMenuItem;
    }
}