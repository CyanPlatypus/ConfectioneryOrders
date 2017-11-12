using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfectioneryOrders.Model
{
    public interface IAddDelete
    {
        Object Add();
        void Delete(Object o);
    }

    public interface IHaveObject
    {
        Object GetObject();
    }
}
