using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject_Module3_
{
    public interface IGenericTypeOfShop<T>
    {
        String GetGenericTypeOfShop(T obj);
    }
}
