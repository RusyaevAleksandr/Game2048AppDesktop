namespace Game2048WindowsForApp
{
    partial class AuthenticationForm
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
            welcomeLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            startButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(106, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(258, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Добро пожаловть в игру!";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(103, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Введите имя:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 133);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(460, 23);
            nameTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(155, 261);
            startButton.Name = "startButton";
            startButton.Size = new Size(154, 38);
            startButton.TabIndex = 3;
            startButton.Text = "Начать игру";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(startButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(welcomeLabel);
            Name = "AuthenticationForm";
            Text = "Игра 2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Button startButton;
    }
}