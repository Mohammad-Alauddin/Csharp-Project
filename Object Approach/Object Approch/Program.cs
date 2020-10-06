using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Approch
{
    abstract class SuperShop
    {
        public string ShopName { get; set; }

        public string ShopNumber { get; set; }
    }


    interface ISuperShop
    {
        string ListOfSuperShop(string ItemName);
        
    }




    class CommonShop : SuperShop, ISuperShop
    {
       
        string ISuperShop.ListOfSuperShop(string ItemName)
        {
            
            return ItemName;
        }
    }





    sealed class SDetail : CommonShop
    {
        public SDetail (string SName, string SNumber)
        {
            this.ShopName = SName;
            this.ShopNumber = SNumber;
        }

        public string ShopLocation { set; get; }

        public string Shop_Starting_Date { get; set; }

        public override string ToString()
        {
            return $"Super Shop Name : {this.ShopName}, Super Shop Number:{this.ShopNumber}, Shop Location :{ShopLocation}, Shop Opening Date:{Shop_Starting_Date}";
        }
    }




    class Program
    {
        private static IEnumerable<object> subjectList;

        public static string ItemName { get; private set; }

        enum ProductsCategory
        {
            Mobile,
            Computer,
            ConsumerFood,
            Fruits,
            SoftDrink,
            BabyFood,
            Vagetable,
            FishItem,
            Colth
        }


        static void Main(string[] args)
        {
            Console.WriteLine("********* Super Shop ***********");
            Console.WriteLine("Enter Your Shop Name Please..");
            string ShopName = Console.ReadLine();


            Console.WriteLine("Enter Your Shop Number Please..");
            string ShopNumber = Console.ReadLine();

            SDetail newShop = new SDetail(ShopName, ShopNumber);




            Console.WriteLine("Enter Your ShopLocation Please..");
            newShop.ShopLocation = Console.ReadLine();

            Console.WriteLine("Enter your Shop Starting Date Please..");
            newShop.Shop_Starting_Date = Console.ReadLine();


            Console.WriteLine("Available Products In This Shop");
            var enumList = Enum.GetNames(typeof(ProductsCategory));
            foreach (var v in enumList)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Which Product Do You Want To Buy ? ");
            string NameOfProduct = Console.ReadLine();

            ISuperShop iShop = (ISuperShop)newShop;

            List<string> ProductsCategory = new List<string>();
            ProductsCategory.Add(iShop.ListOfSuperShop(ItemName));



            bool yesProceed = true;
            while (yesProceed)
            {
                Console.WriteLine("Do You Want To Buy ? Yes Or No");
                string YesNoInput = Console.ReadLine();
                if (YesNoInput.ToUpper() == "Yes".ToUpper())
                {
                    Console.WriteLine("Item Name:");
                    string ItemName = Console.ReadLine();
                    ProductsCategory.Add(iShop.ListOfSuperShop(ItemName));
                }
                else
                {
                    yesProceed = false;
                }
            }

            Console.WriteLine("Item Details is given below");
            Console.WriteLine(newShop.ToString());



            Console.WriteLine("You Have Selected The Following Products:");
            foreach (var s in ProductsCategory)
            {
                Console.WriteLine(s);
                
            }

            Console.WriteLine("Thank You For Your Purchase");
            Console.ReadLine();


        }
    }
}
