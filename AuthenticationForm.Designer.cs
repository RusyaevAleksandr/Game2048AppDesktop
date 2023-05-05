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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            mapSizeTextLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            mapSizeComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Dock = DockStyle.Fill;
            welcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.OrangeRed;
            welcomeLabel.Location = new Point(72, 3);
            welcomeLabel.Margin = new Padding(3, 3, 3, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(338, 37);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Добро пожаловть в игру 2048!";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Sienna;
            nameLabel.Location = new Point(8, 57);
            nameLabel.Margin = new Padding(8, 0, 3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(113, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Введите имя:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.Window;
            nameTextBox.Location = new Point(129, 60);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(243, 23);
            nameTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Khaki;
            startButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.Sienna;
            startButton.Location = new Point(164, 3);
            startButton.Name = "startButton";
            startButton.Size = new Size(154, 38);
            startButton.TabIndex = 3;
            startButton.Text = "Начать игру";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4109907F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.15257F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4364367F));
            tableLayoutPanel1.Controls.Add(welcomeLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(484, 40);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(startButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 211);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(484, 100);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.7768478F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.2231522F));
            tableLayoutPanel2.Controls.Add(nameTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(mapSizeTextLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(nameLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(484, 171);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // mapSizeTextLabel
            // 
            mapSizeTextLabel.AutoSize = true;
            mapSizeTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mapSizeTextLabel.ForeColor = Color.Sienna;
            mapSizeTextLabel.Location = new Point(8, 114);
            mapSizeTextLabel.Margin = new Padding(8, 0, 3, 0);
            mapSizeTextLabel.Name = "mapSizeTextLabel";
            mapSizeTextLabel.Size = new Size(115, 21);
            mapSizeTextLabel.TabIndex = 3;
            mapSizeTextLabel.Text = "Размер поля:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.99999F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.00001F));
            tableLayoutPanel4.Controls.Add(mapSizeComboBox, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(126, 114);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(249, 57);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // mapSizeComboBox
            // 
            mapSizeComboBox.BackColor = SystemColors.Info;
            mapSizeComboBox.Dock = DockStyle.Fill;
            mapSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mapSizeComboBox.ForeColor = Color.Sienna;
            mapSizeComboBox.Items.AddRange(new object[] { "4 х 4", "5 х 5", "6 х 6" });
            mapSizeComboBox.Location = new Point(71, 3);
            mapSizeComboBox.Name = "mapSizeComboBox";
            mapSizeComboBox.Size = new Size(105, 23);
            mapSizeComboBox.TabIndex = 4;
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(484, 311);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(500, 350);
            MinimumSize = new Size(500, 350);
            Name = "AuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра 2048";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label welcomeLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Button startButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label mapSizeTextLabel;
        private ComboBox mapSizeComboBox;
        private TableLayoutPanel tableLayoutPanel4;
    }
}