using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Database.Model
{
    public class ChangeLog
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int StorageId { get; set; }
        public virtual Storage? Storage { get; set; }
        public int Change { get; set; }
        public int Result { get; set; }
        public DateTime DateTime { get; set; }
    }
}
