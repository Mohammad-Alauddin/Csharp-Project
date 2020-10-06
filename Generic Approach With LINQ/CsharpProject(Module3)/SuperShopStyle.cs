using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject_Module3_
{
    public class SuperShopStyle
    {
        public SuperShopStyle[] ShopCorner;
        public SuperShopStyle(ShopType shopType, string shopStyle)
        {
            this.Type       = shopType;
            this.shopStyle  = shopStyle;
        }

        public SuperShopStyle()
        {

        }

        public ShopType Type    { get; set; }
        public string shopStyle { get; set; }

    }
}
