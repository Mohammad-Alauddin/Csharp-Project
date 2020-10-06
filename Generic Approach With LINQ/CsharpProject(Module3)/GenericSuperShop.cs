using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject_Module3_
{
    public class GenericSuperShop<T> : IGenericTypeOfShop<T>
    {


        string IGenericTypeOfShop<T>.GetGenericTypeOfShop(T obj)
        {
            SuperShopStyleFiling db = new SuperShopStyleFiling();

            string TypeOfShop = string.Empty;

            if (obj is SuperShop)
            {
                SuperShop a = obj as SuperShop;
                switch (a.Type)
                {
                    case ShopType.ComputerShop:
                        
                        TypeOfShop = db.bufferInfo.Where(w => w.Type == ShopType.ComputerShop).FirstOrDefault().shopStyle; 
                        break;
                    case ShopType.ClothShop:
                        TypeOfShop = db.bufferInfo.Where(w => w.Type == ShopType.ClothShop).FirstOrDefault().shopStyle;
                        break;
                    case ShopType.FreshFoodShop:
                        TypeOfShop = TypeOfShop = db.bufferInfo.Where(w => w.Type == ShopType.FreshFoodShop).FirstOrDefault().shopStyle;
                        break;
                    default:
                        TypeOfShop = "Nothing is Found";
                        break;

                }

            }
            else
            {
                TypeOfShop = "This Is Not a SuperShop";
            }
            return TypeOfShop;
        }

    }
}
