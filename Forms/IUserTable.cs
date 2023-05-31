using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Forms
{
    public interface IUserTable
    {
        void addToUsers(int id, params object[] param);
        void setEnable(bool value);
    }
}
