using Order.Database;
using Order.Forms.StorageForms;
using Order.Service;
using System.Data;

namespace Order.Forms
{
    public partial class AdminForm : Form, IUserTable
    {
        private List<int> userIds = new List<int>();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using var db = new Context();
            Column4.Items.AddRange(db.Roles.Select(r => r.Name).ToArray());
            Column5.Items.AddRange(db.Storages.Select(r => r.Adress).ToArray());
            var users = db.Users.ToList();
            foreach (var user in users)
            {
                dataGridView1.Rows.Add(user.Name, user.Login, user.Password, user.Role.Name, user.Storage.Adress);
                userIds.Add(user.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 1);

        private void button2_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 2);

        private void button3_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 3);

        private void button4_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 4);

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using var db = new Context();
            var user = db.Users.Find(userIds[e.RowIndex]);
            user.Name = dataGridView1[0, e.RowIndex].Value.ToString();
            user.Login = dataGridView1[1, e.RowIndex].Value.ToString();
            user.Password = dataGridView1[2, e.RowIndex].Value.ToString();
            string roleName = dataGridView1[3, e.RowIndex].Value.ToString();
            user.RoleId = db.Roles.FirstOrDefault(r => r.Name.Equals(roleName)).Id;
            string storageAdress = dataGridView1[4, e.RowIndex].Value.ToString();
            user.StorageId = db.Storages.FirstOrDefault(r => r.Adress.Equals(storageAdress)).Id;
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null) return;
            using var db = new Context();
            var user = db.Users.Find(userIds[dataGridView1.SelectedRows[0].Index]);
            if (user == null) return;
            db.Users.Remove(user);
            db.SaveChanges();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show($"{user.Name} был удалён");
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser(this);
            createUser.Show();
            this.Enabled = false;
        }

        public void addToUsers(int id, params object[] param)
        {
            userIds.Add(id);
            dataGridView1.Rows.Add(param);
        }

        public void setEnable(bool value)
            => this.Enabled = value;
    }
}
