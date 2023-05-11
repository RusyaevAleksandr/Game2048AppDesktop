namespace Game2048WindowsForApp
{
    partial class RulesGameForm
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
            rulesGameListBox = new ListBox();
            SuspendLayout();
            // 
            // rulesGameListBox
            // 
            rulesGameListBox.BackColor = SystemColors.Info;
            rulesGameListBox.Dock = DockStyle.Fill;
            rulesGameListBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rulesGameListBox.FormattingEnabled = true;
            rulesGameListBox.HorizontalScrollbar = true;
            rulesGameListBox.ItemHeight = 21;
            rulesGameListBox.Location = new Point(0, 0);
            rulesGameListBox.Name = "rulesGameListBox";
            rulesGameListBox.ScrollAlwaysVisible = true;
            rulesGameListBox.Size = new Size(684, 461);
            rulesGameListBox.TabIndex = 1;
            // 
            // RulesGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(684, 461);
            Controls.Add(rulesGameListBox);
            MinimumSize = new Size(700, 500);
            Name = "RulesGameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Правила игры";
            Load += RulesGameForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox rulesGameListBox;
    }
}