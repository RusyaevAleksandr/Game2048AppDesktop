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
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.AutoSize = true;
            scoreTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreTextLabel.Location = new Point(12, 67);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Size = new Size(47, 21);
            scoreTextLabel.TabIndex = 0;
            scoreTextLabel.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.Location = new Point(65, 67);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(19, 21);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(319, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameToolStripMenuItem, saveResultToolStripMenuItem, resultListToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(53, 20);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // restartGameToolStripMenuItem
            // 
            restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            restartGameToolStripMenuItem.Size = new Size(189, 22);
            restartGameToolStripMenuItem.Text = "Начать сначала";
            restartGameToolStripMenuItem.Click += restartGameToolStripMenuItem_Click;
            // 
            // saveResultToolStripMenuItem
            // 
            saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            saveResultToolStripMenuItem.Size = new Size(189, 22);
            saveResultToolStripMenuItem.Text = "Сохранить результат";
            saveResultToolStripMenuItem.Click += saveResultToolStripMenuItem_Click;
            // 
            // resultListToolStripMenuItem
            // 
            resultListToolStripMenuItem.Name = "resultListToolStripMenuItem";
            resultListToolStripMenuItem.Size = new Size(189, 22);
            resultListToolStripMenuItem.Text = "Список результатов";
            resultListToolStripMenuItem.Click += resultListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(189, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesGameToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(68, 20);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // rulesGameToolStripMenuItem
            // 
            rulesGameToolStripMenuItem.Name = "rulesGameToolStripMenuItem";
            rulesGameToolStripMenuItem.Size = new Size(153, 22);
            rulesGameToolStripMenuItem.Text = "Правила игры";
            rulesGameToolStripMenuItem.Click += rulesGameToolStripMenuItem_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.Location = new Point(12, 37);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(57, 21);
            userLabel.TabIndex = 3;
            userLabel.Text = "Игрок:";
            // 
            // bestScoreTextLabel
            // 
            bestScoreTextLabel.AutoSize = true;
            bestScoreTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bestScoreTextLabel.Location = new Point(185, 37);
            bestScoreTextLabel.Name = "bestScoreTextLabel";
            bestScoreTextLabel.Size = new Size(107, 21);
            bestScoreTextLabel.TabIndex = 4;
            bestScoreTextLabel.Text = "Лучший счет:";
            // 
            // scoreTextLabel2
            // 
            scoreTextLabel2.AutoSize = true;
            scoreTextLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreTextLabel2.Location = new Point(185, 67);
            scoreTextLabel2.Name = "scoreTextLabel2";
            scoreTextLabel2.Size = new Size(47, 21);
            scoreTextLabel2.TabIndex = 5;
            scoreTextLabel2.Text = "Счет:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bestScoreLabel.Location = new Point(238, 67);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(19, 21);
            bestScoreLabel.TabIndex = 6;
            bestScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 414);
            Controls.Add(bestScoreLabel);
            Controls.Add(scoreTextLabel2);
            Controls.Add(bestScoreTextLabel);
            Controls.Add(userLabel);
            Controls.Add(scoreLabel);
            Controls.Add(scoreTextLabel);
            Controls.Add(menuStrip);
            Name = "MainForm";
            Text = "Игра 2048";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
    }
}