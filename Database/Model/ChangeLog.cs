using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Database.Model
{
    internal class ChangeLog
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int StorageId { get; set; }
        public Storage? Storage { get; set; }
        public int Change { get; set; }
        public DateTime DateTime { get; set; }
    }
}
