using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject_Module3_
{
   public class SpecificTypeOfSuperShop<T> : ISspecificTypeOfShop<T>
    {
        public string GetSpecificTypeOfShop<T>(T data) where T : SuperShop
        {

            SuperShopStyleFiling db = new SuperShopStyleFiling();

            string TypeOfShop = string.Empty;
            switch(data.Type)
            {
                case ShopType.ComputerShop:
                    TypeOfShop = db.bufferInfo.Where(w => w.Type == ShopType.ComputerShop).FirstOrDefault().shopStyle;
                    break;
                case ShopType.ClothShop:
                    TypeOfShop = db.bufferInfo.Where(w => w.Type == ShopType.ClothShop).FirstOrDefault().shopStyle;
                    break;
                case ShopType.FreshFoodShop:
                    TypeOfShop = db.bufferInfo.Where(w => w.Type == ShopType.FreshFoodShop).FirstOrDefault().shopStyle;
                    break;
                default:
                    TypeOfShop = "Nothing is found";
                    break;
            }
            return TypeOfShop;
        }

    }
}
