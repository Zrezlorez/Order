using Order.Database;
using Order.Database.Model;
using Order.Service;

namespace Order.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.Auth(login.Text, password.Text) == 1) {
                Hide();
                new ProductView().Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
        }
    }
}
