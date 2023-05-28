using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Database.Model
{
    internal class Storage
    {
        public int Id { get; set; }
        public string? Adress { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<ChangeLog> ChangeLogs { get; set; } = new List<ChangeLog>();

    }
}
