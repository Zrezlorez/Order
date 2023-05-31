using Order.Database;
using Order.Service;
using Order.Database.Model;
using Order.Database.Service;

namespace Order
{
    public partial class ProductView : Form
    {
        private List<int> changeLogIds = new();
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            using var db = new Context();
            if (Session.Instance.User.RoleId > 1)
            {
                button3.Visible = true;
                button4.Visible = true;
            }
            comboBox1.Items.AddRange(db.Products.Select(p => p.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 1);

        private void button2_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 2);

        private void button3_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 3);

        private void button4_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 4);

        private void ProductView_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using Context db = new Context();
            Product? product = db.Products.Find(comboBox1.SelectedIndex + 1);
            description.Text = product.Description;
            pictureBox1.Image = System.Drawing.Image.FromFile(product.ImagePath);
            var changeLogs = db.ChangeLogs
                .Where(c => c.StorageId == Session.Instance.User.StorageId && c.ProductId == product.Id)
                .ToList();
            foreach (var changeLog in changeLogs)
            {
                dataGridView1.Rows.Add(changeLog.Change, changeLog.Result, changeLog.DateTime);
                changeLogIds.Add(changeLog.Id);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var changeLog =
                ChangeLogService.Add(comboBox1.SelectedIndex + 1, Session.Instance.User.Storage.Id);

            changeLogIds.Add(changeLog.Id);
            dataGridView1[1, e.Row.Index - 1].Value = changeLog.Result;
            dataGridView1[2, e.Row.Index - 1].Value = changeLog.DateTime;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1[1, e.RowIndex].Value = ChangeLogService
                .Update(changeLogIds[e.RowIndex], Convert.ToInt32(dataGridView1[0, e.RowIndex].Value))
                .Change;
        }
    }
}