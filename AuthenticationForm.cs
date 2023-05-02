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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            user.Name = nameTextBox.Text;

            StaticData.DataBufferUserName = user.Name;

            this.Hide();

            MainForm mainForm = new MainForm();

            mainForm.Show();
        }
    }
}
