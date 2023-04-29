namespace Game2048WindowsFormApp
{
    partial class ResultGameForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            resultGameDataGridView = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            scoreGame = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultGameDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultGameDataGridView
            // 
            resultGameDataGridView.BackgroundColor = SystemColors.Info;
            resultGameDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGameDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, scoreGame });
            resultGameDataGridView.Dock = DockStyle.Fill;
            resultGameDataGridView.Location = new Point(0, 0);
            resultGameDataGridView.Name = "resultGameDataGridView";
            resultGameDataGridView.RowTemplate.Height = 25;
            resultGameDataGridView.Size = new Size(684, 461);
            resultGameDataGridView.TabIndex = 0;
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            userName.DefaultCellStyle = dataGridViewCellStyle1;
            userName.HeaderText = "Имя игрока";
            userName.Name = "userName";
            // 
            // scoreGame
            // 
            scoreGame.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreGame.DefaultCellStyle = dataGridViewCellStyle2;
            scoreGame.HeaderText = "Лучший результат";
            scoreGame.Name = "scoreGame";
            // 
            // ResultGameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(resultGameDataGridView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ResultGameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Список результатов игры";
            Load += ResultGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultGameDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultGameDataGridView;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn scoreGame;
    }
}