using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject_Module3_
{
    public interface ISspecificTypeOfShop<T>
    {
        string GetSpecificTypeOfShop<T>(T data) where T : SuperShop;
    }
}
