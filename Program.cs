namespace inventurySystem
{
    internal class Program
    {
        const int invnum = 50;
        static string[,] invitory = new string[invnum, 3];
        static int prudectCount = 0;

        //
        /*
         id     name   pruduct 
        1
        2
        3
        ..0
         
         */
        static void Main(string[] args)
        {


            while (true)
            {
                // add proubect 

                // Update proudect 
                // view proudct (ID , name ,Quntity ,price )
                // Exit 
                Console.WriteLine("welcome to the inventory system ");
                Console.WriteLine("================================");
                Console.WriteLine(" 1 add product ");
                Console.WriteLine(" 2 Update proudect  ");
                Console.WriteLine(" 3 view  product ");
                Console.WriteLine(" 4  Exit  ");


                string userInput = Console.ReadLine();
                int choise = Convert.ToInt32(userInput);
                switch (choise)
                {
                    case 1:
                        //add product 
                        AddProduct();
                        break;
                    case 2:
                        //Update product 
                        UpdateProduct();
                        break;
                    case 3:
                        //view product 
                        ViowProduct();
                        break;

                    case 4:
                        //Exit   

                        break;





                }


            }

        }
        private static void AddProduct()
        {

            Console.WriteLine("enter product name");
            string name = Console.ReadLine();

            Console.WriteLine("enter product Quantity");
            string Quantity = Console.ReadLine();

            Console.WriteLine("enter product price");
            string price = Console.ReadLine();

            invitory[prudectCount, 0] = name;
            invitory[prudectCount, 1] = Quantity;
            invitory[prudectCount, 2] = price;
            prudectCount++;
            Console.WriteLine("Pruduct added Suciiii!!!");

        }
        private static void ViowProduct()
        {
            if (prudectCount > 0)
            {
                Console.WriteLine("Product list ");
                for (int i = 0; i < prudectCount; i++)
                {
                    Console.WriteLine($"product  ID {i}: product  name  : {invitory[i, 0]}product  Quantity : {invitory[i, 1]}product  price : {invitory[i, 2]}");

                }

            }
        }
        private static void UpdateProduct()
        {
            Console.WriteLine("enter name product to update ");
            int productID = -1;
            string searchproduct = Console.ReadLine();
            if (prudectCount > 0)
            {
                for (int i = 0; i < prudectCount; i++)
                {


                    if (invitory[i, 0] == searchproduct)
                    {
                        productID = i;
                        break;
                    }


                }
                    if (productID != -1)
                    {
                        Console.WriteLine("enter the new Qun");
                        string newQQQ=Console.ReadLine();
                        invitory[productID, 1] = newQQQ;
                        Console.WriteLine("Update sucissfull!!");

                    }
                    else
                    {
                        Console.WriteLine("not fount ");
                    }
                }
            
            }
        }
    }


