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
            scoreTextLabel = new Label();
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
            scoreTextLabel2 = new Label();
            bestScoreLabel = new Label();
            tableLayoutPanelTop = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            infoTextLabel = new Label();
            menuStrip.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.AutoSize = true;
            scoreTextLabel.Dock = DockStyle.Left;
            scoreTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreTextLabel.Location = new Point(3, 0);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Padding = new Padding(4, 0, 0, 0);
            scoreTextLabel.Size = new Size(54, 24);
            scoreTextLabel.TabIndex = 0;
            scoreTextLabel.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Dock = DockStyle.Left;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(89, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(19, 24);
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
            menuStrip.Size = new Size(358, 29);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameToolStripMenuItem, saveResultToolStripMenuItem, resultListToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(66, 25);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // restartGameToolStripMenuItem
            // 
            restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            restartGameToolStripMenuItem.Size = new Size(230, 26);
            restartGameToolStripMenuItem.Text = "Начать сначала";
            restartGameToolStripMenuItem.Click += restartGameToolStripMenuItem_Click;
            // 
            // saveResultToolStripMenuItem
            // 
            saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            saveResultToolStripMenuItem.Size = new Size(230, 26);
            saveResultToolStripMenuItem.Text = "Сохранить результат";
            saveResultToolStripMenuItem.Click += saveResultToolStripMenuItem_Click;
            // 
            // resultListToolStripMenuItem
            // 
            resultListToolStripMenuItem.Name = "resultListToolStripMenuItem";
            resultListToolStripMenuItem.Size = new Size(230, 26);
            resultListToolStripMenuItem.Text = "Список результатов";
            resultListToolStripMenuItem.Click += resultListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(230, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesGameToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(83, 25);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // rulesGameToolStripMenuItem
            // 
            rulesGameToolStripMenuItem.Name = "rulesGameToolStripMenuItem";
            rulesGameToolStripMenuItem.Size = new Size(180, 26);
            rulesGameToolStripMenuItem.Text = "Правила игры";
            rulesGameToolStripMenuItem.Click += rulesGameToolStripMenuItem_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Dock = DockStyle.Left;
            userLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            bestScoreTextLabel.Location = new Point(238, 0);
            bestScoreTextLabel.Name = "bestScoreTextLabel";
            bestScoreTextLabel.Padding = new Padding(0, 2, 4, 0);
            bestScoreTextLabel.Size = new Size(117, 30);
            bestScoreTextLabel.TabIndex = 4;
            bestScoreTextLabel.Text = "Лучший счет";
            // 
            // scoreTextLabel2
            // 
            scoreTextLabel2.AutoSize = true;
            scoreTextLabel2.Dock = DockStyle.Right;
            scoreTextLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreTextLabel2.Location = new Point(33, 0);
            scoreTextLabel2.Name = "scoreTextLabel2";
            scoreTextLabel2.Size = new Size(50, 24);
            scoreTextLabel2.TabIndex = 5;
            scoreTextLabel2.Text = "Счет:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Dock = DockStyle.Right;
            bestScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreLabel.Location = new Point(147, 0);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Padding = new Padding(0, 0, 4, 0);
            bestScoreLabel.Size = new Size(23, 24);
            bestScoreLabel.TabIndex = 6;
            bestScoreLabel.Text = "0";
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 2;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.Controls.Add(userLabel, 0, 0);
            tableLayoutPanelTop.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanelTop.Controls.Add(bestScoreTextLabel, 1, 0);
            tableLayoutPanelTop.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanelTop.Dock = DockStyle.Top;
            tableLayoutPanelTop.Location = new Point(0, 29);
            tableLayoutPanelTop.MinimumSize = new Size(241, 50);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 2;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.Size = new Size(358, 60);
            tableLayoutPanelTop.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(scoreTextLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(scoreLabel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(173, 24);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(scoreTextLabel2, 0, 0);
            tableLayoutPanel3.Controls.Add(bestScoreLabel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(182, 33);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(173, 24);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.46593332F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.06813F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.465934F));
            tableLayoutPanel1.Controls.Add(infoTextLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(358, 31);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // infoTextLabel
            // 
            infoTextLabel.AutoSize = true;
            infoTextLabel.Dock = DockStyle.Fill;
            infoTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoTextLabel.Location = new Point(15, 0);
            infoTextLabel.Name = "infoTextLabel";
            infoTextLabel.Size = new Size(327, 31);
            infoTextLabel.TabIndex = 0;
            infoTextLabel.Text = "Соберите число 2048 на одной плтитке!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(358, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelTop);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreTextLabel;
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
        private Label scoreTextLabel2;
        private Label bestScoreLabel;
        private TableLayoutPanel tableLayoutPanelTop;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label infoTextLabel;
    }
}