using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject_Module3_
{

    class SuperShopStyleFiling
    {
        public SuperShopStyle[] bufferInfo;

        public SuperShopStyleFiling()
        {
            bufferInfo = new SuperShopStyle[]
            {
                new SuperShopStyle()
                {
                     shopStyle  = "All Cloth & Cloth Element Available in This Part of Shop",
                     Type       = ShopType.ClothShop
                },

                new SuperShopStyle()
                {
                     shopStyle  = "All Fresh Food & Soft Drink Availabe in This Part of Shop",
                     Type       = ShopType.FreshFoodShop
                },
                 
                new SuperShopStyle()
                {
                     shopStyle  = "All Computer & Internet Accessories Availabe in This Part of Shop",
                     Type       = ShopType.ComputerShop
                }


            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperShop Agura = new SuperShop { Name = "Agura", ShopNumber = 2203, Size = SizeOfShop.Medium , Type= ShopType.FreshFoodShop };
            GenericSuperShop<SuperShop> superShop = new GenericSuperShop<SuperShop>();
            IGenericTypeOfShop<SuperShop> genericTypeOfShop = superShop;           
            Console.WriteLine(genericTypeOfShop.GetGenericTypeOfShop(Agura));



            SuperShop Shwapno = new SuperShop { Name = "Shwapno", ShopNumber = 2205, Size = SizeOfShop.Large , Type = ShopType.ComputerShop };
            SpecificTypeOfSuperShop<SuperShop> SShop = new SpecificTypeOfSuperShop<SuperShop>();
            Console.WriteLine(SShop.GetSpecificTypeOfShop(Shwapno));

            Console.ReadLine();


        }
    }
}
