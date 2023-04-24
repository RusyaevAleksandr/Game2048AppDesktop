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
            SuspendLayout();
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.AutoSize = true;
            scoreTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreTextLabel.Location = new Point(200, 9);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Size = new Size(47, 21);
            scoreTextLabel.TabIndex = 0;
            scoreTextLabel.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.Location = new Point(253, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(19, 21);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 406);
            Controls.Add(scoreLabel);
            Controls.Add(scoreTextLabel);
            Name = "MainForm";
            Text = "Игра 2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreTextLabel;
        private Label scoreLabel;
    }
}