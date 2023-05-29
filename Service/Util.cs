using Order.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Service
{
    internal class Util
    {
        public static void ShowFormById(Form form, int id) {
            Form? newForm = null;

            if (id == 1) newForm = new ProductView();
            if (id == 2) newForm = new Report();
            if (id == 3) newForm = new Storages();
            if (newForm != null && form.GetType() != newForm.GetType())
            {
                form.Hide();
                newForm.Show();
            }
                
        }

        public static DateTime SetKindUtc(DateTime dateTime)
        {
            if (dateTime.Kind == DateTimeKind.Utc) { return dateTime; }
            return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
        }
    }
}
