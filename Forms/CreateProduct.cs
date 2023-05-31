using Order.Database;
using Order.Database.Model;
using Order.Service;
using System.Data;

namespace Order.Forms
{
    public partial class CreateProduct : Form
    {
        private Storages form;
        public CreateProduct(Storages form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            using var db = new Context();
            comboBox1.Items.AddRange(db.Storages.Select(s => s.Adress).ToArray());
            if (Session.Instance.Role.Id == 2)
            {
                comboBox1.SelectedIndex = Session.Instance.Storage.Id - 1;
                comboBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var db = new Context();
            Product item = new Product()
            {
                Name = textBox1.Text,
                Description = textBox2.Text,
                ImagePath = textBox3.Text,
            };
            db.Products.Add(item);
            db.Storages.Find(comboBox1.SelectedIndex + 1).Products.Add(item);
            db.SaveChanges();
            int lastResult = 0;
            if (item.ChangeLogs.Count > 1)
                lastResult = item.ChangeLogs.Last().Result;
            form.addToProducts(item.Id, item.Name, lastResult);
            MessageBox.Show("Товар добавлен");
            Close();
        }

        private void CreateProduct_FormClosing(object sender, FormClosingEventArgs e)
             => form.setEnable(true);

        private void button2_Click(object sender, EventArgs e)
            => Close();
    }
}
