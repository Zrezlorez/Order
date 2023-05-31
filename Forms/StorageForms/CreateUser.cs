using Order.Database;
using Order.Database.Model;
using Order.Service;
using SixLabors.ImageSharp.ColorSpaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.Forms.StorageForms
{
    public partial class CreateUser : Form
    {
        private Storages form;
        private int storageId;
        public CreateUser(Storages form, int storageId)
        {
            this.form = form;
            this.storageId = storageId;
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            using var db = new Manager();
            comboBox1.Items.AddRange(db.Storages.Select(s => s.Adress).ToArray());
            comboBox1.SelectedIndex = Session.Instance.Storage.Id - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var db = new Manager();
            User user = new User()
            {
                Name = textBox1.Text,
                Login = textBox2.Text,
                Password = textBox3.Text,
                StorageId = comboBox1.SelectedIndex + 1,
                RoleId = 1
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Работник добавлен");
            form.addToUsers(user.Id, user.Name, user.Login, user.Password);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
            => Close();


        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
