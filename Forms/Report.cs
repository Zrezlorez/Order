using IronXL;
using Microsoft.EntityFrameworkCore;
using Order.Database;
using Order.Database.Model;
using Order.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.Forms
{
    public partial class Report : Form
    {
        private List<ChangeLog> changeLogs = new List<ChangeLog>();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            if (Session.Instance.User.RoleId > 1)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using Manager db = new Manager();
            dataGridView1.Rows.Clear();
            changeLogs = db.ChangeLogs.Where(c =>
                            c.DateTime.CompareTo(Util.SetKindUtc(dateTimePicker1.Value)) > 0
                            && c.DateTime.CompareTo(Util.SetKindUtc(dateTimePicker2.Value)) < 0).ToList();
            foreach (var item in changeLogs)
            {
                dataGridView1.Rows.Add(item.Change, item.Result, item.DateTime, item.Product.Name, item.Storage.Adress);
            }
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();

        private void button1_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 1);

        private void button2_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 2);

        private void button3_Click(object sender, EventArgs e)
            => Util.ShowFormById(this, 3);

        private void button5_Click(object sender, EventArgs e)
        {
            Util.GenerateExcel(changeLogs);
        }
    }
}
