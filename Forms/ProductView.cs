using Order.Database;
using Order.Service;
using Order.Database.Model;

namespace Order
{
    public partial class ProductView : Form
    {
        private List<int> rows = new();
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            using var db = new Manager();
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
        private void ProductView_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using Manager db = new Manager();
            Product? product = db.Products.Find(comboBox1.SelectedIndex + 1);
            description.Text = product.Description;
            pictureBox1.Image = System.Drawing.Image.FromFile(product.ImagePath);
            var changeLogs = db.ChangeLogs
                .Where(c => c.StorageId == Session.Instance.User.StorageId && c.ProductId == product.Id).ToList();
            foreach (var changeLog in changeLogs)
            {
                dataGridView1.Rows.Add(changeLog.Change, changeLog.Result, changeLog.DateTime);
                rows.Add(changeLog.Id);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            using Manager db = new Manager();
            int lastResult = 0;
            if (db.ChangeLogs.Count() > 0 && db.ChangeLogs.ToList().Last() != null)
                lastResult = db.ChangeLogs.ToList().Last().Result;
            int id = Session.Instance.User.Storage.Id;
            ChangeLog changeLog = new ChangeLog()
            {
                DateTime = Util.SetKindUtc(DateTime.Now),
                Change = 0,
                ProductId = comboBox1.SelectedIndex + 1,
                StorageId = id,
                Result = lastResult
            };
            db.ChangeLogs.Add(changeLog);
            db.SaveChanges();
            rows.Add(changeLog.Id);
            dataGridView1[1, e.Row.Index - 1].Value = changeLog.Result;
            dataGridView1[2, e.Row.Index - 1].Value = changeLog.DateTime;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using Manager db = new Manager();
            ChangeLog? changeLog = db.ChangeLogs.Find(rows[e.RowIndex]);

            int lastResult = 0;
            List<ChangeLog> changeLogs = db.ChangeLogs.ToList();
            int lastId = 0;
            if (changeLogs.Count > 1)
                lastId = changeLogs.Count - 2;
            ChangeLog lastChange = changeLogs[lastId];
            if (lastChange != null)
                lastResult = lastChange.Result;


            changeLog.Change = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            lastResult += changeLog.Change;
            changeLog.Result = lastResult;
            dataGridView1[1, e.RowIndex].Value = lastResult;
            db.SaveChanges();
        }
    }
}