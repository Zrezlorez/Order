using Order.Database;
using Order.Forms.StorageForms;
using Order.Service;
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

namespace Order.Forms
{
    public partial class Storages : Form
    {
        private List<int> userIds = new List<int>();
        private List<int> productIds = new List<int>();
        public Storages()
        {
            InitializeComponent();
        }

        private void Storages_Load(object sender, EventArgs e)
        {
            using var db = new Manager();
            comboBox1.Items.AddRange(db.Storages.Select(p => p.Adress).ToArray());
            if (Session.Instance.Role.Id == 2) {
                comboBox1.SelectedIndex = Session.Instance.Storage.Id - 1;
                comboBox1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateTables(); 
        private void UpdateTables()
        {
            using var db = new Manager();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            var storage = db.Storages.Find(comboBox1.SelectedIndex + 1);
            foreach (var item in storage.Products)
            {
                dataGridView1.Rows.Add(item.Name, item.ChangeLogs.Last().Result);
            }
            foreach (var item in storage.Users)
            {
                addToUsers(item.Id, item.Name, item.Login, item.Password);
            }
        }

        public void addToUsers(int id, params object[] param)
        {
            userIds.Add(id);
            dataGridView2.Rows.Add(param);
        }


        private void Storages_FormClosing(object sender, FormClosingEventArgs e)
            => Application.Exit();

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows == null) return;
            using var db = new Manager();
            var user = db.Users.Find(userIds[dataGridView2.SelectedRows[0].Index]);
            if (user == null) return;
            db.Users.Remove(user);
            db.SaveChanges();
            UpdateTables();
            MessageBox.Show($"{user.Name} был удалён");
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null) return;
            using var db = new Manager();
            var product = db.Products.Find(productIds[dataGridView1.SelectedRows[0].Index]);
            if (product == null) return;
            db.Products.Remove(product);
            db.ChangeLogs.RemoveRange(db.ChangeLogs.Where(c =>
                    c.ProductId == product.Id
                    && c.StorageId == comboBox1.SelectedIndex + 1));
            db.SaveChanges();
            UpdateTables();
            MessageBox.Show($"{product.Name} был удалён");
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser(this, comboBox1.SelectedIndex + 1);
            createUser.Show();
            this.Enabled = false;
        }
    }
}
