using Game2048App;
using Game2048App.Common;

namespace Game2048WindowsForApp
{
    public partial class AuthenticationForm : Form
    {
        User user = new User("User");

        public AuthenticationForm()
        {
            InitializeComponent();

            nameTextBox.Select();

            mapSizeComboBox.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            user.Name = nameTextBox.Text;

            StaticData.DataBufferUserName = user.Name;

            var index = this.mapSizeComboBox.SelectedIndex;

            if (index == 0)
            {
                StaticData.DataMapSize = 4;
            }
            else if (index == 1)
            {
                StaticData.DataMapSize = 5;
            }
            else if (index == 2)
            {
                StaticData.DataMapSize = 6;
            }
            else if (index == 3)
            {
                StaticData.DataMapSize = 7;
            }
            else if (index == 4)
            {
                StaticData.DataMapSize = 8;
            }

            this.Hide();

            MainForm mainForm = new MainForm();

            mainForm.Show();
        }
    }
}
