using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            Apple obj = new Apple();
            Ubuntu obj1 = new Ubuntu();
            Customer obk=new Customer("","","");
           
            Console.WriteLine("Welcome to Computer Shop");
            while (true) {
                Console.WriteLine();
                Console.WriteLine("Press 1 Admin");
                Console.WriteLine("Press 2 Customer");
                Console.WriteLine("Press 3 Exit");
                Console.WriteLine();
                Console.WriteLine("Select the Option");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                              Console.WriteLine("Select the Device");
                            Console.WriteLine("1.Apple");
                            Console.WriteLine("2.ubuntu");
                            Console.WriteLine("3.Display the customers");
                            int op = Int32.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                   
                                    obj.inputProduct();
                                    break;
                               case 2:
                                   
                                    obj1.inputProduct();
                                    break;

                                case 3:
                                    obk.display();
                                    break;

                                default:
                                    return;
                                     
                            }
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("Press 1 for Buying a Computer");
                        Console.WriteLine("Press 2 Feedback");
                        Console.WriteLine("Press 3 Exit");
                        Console.WriteLine();
                        Console.WriteLine("Select the Option");
                        int options = Int32.Parse(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter Your name");
                                    String name = Console.ReadLine();
                                    Console.WriteLine("Enter Your Email");
                                    String email= Console.ReadLine();
                                    Console.WriteLine("Enter Your Phone");
                                    String phone = Console.ReadLine();
                                    Console.WriteLine();
                                    Customer obr = new Customer(name, email, phone);
                                    obk = obr;
                                    Console.WriteLine("Press 1 for Apple");
                                    Console.WriteLine("Press 2 Dell");
                                    Console.WriteLine();
                                    Console.WriteLine("Select the Option");
                                    int opt = Int32.Parse(Console.ReadLine());
                                    switch (opt)
                                    {  case 1:
                                            
                                            obj.outputProduct();
                                            break;

                                        case 2:
                                           
                                            obj1.outputProduct();
                                            break;

                                        default :
                                            return;
                                    }
                                    break;
                                }
                                
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }

            }

        }
    }
    abstract class Product
    {
        public virtual void inputProduct()
        {

        }

        public virtual void outputProduct()
        {

        }

    }
    class Ubuntu : Product
    {
        public int ProductId;
        public string Name;
        public float Price;
        public int RAM;
        public float DisplaySize;
        string DiskSize;
        string OS;

        public override void inputProduct()
        {
            Console.WriteLine("Enter Product Id:");
            ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter RAM:");
            RAM = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Display Size:");
            DisplaySize = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Disk Size:");
            DiskSize = Console.ReadLine();
            Console.WriteLine("Enter OS:");
            OS = Console.ReadLine();
        }

        public override void outputProduct()
        {
            //base.outputProduct();
            Console.WriteLine("Product Id:" + this.ProductId);
            Console.WriteLine("Name:" + this.Name);
            Console.WriteLine("Price:" + this.Price);
            Console.WriteLine("RAM:" + this.RAM);
            Console.WriteLine("Display Size:" + this.DisplaySize);
            Console.WriteLine("Hard Disk Size:" + this.DiskSize);
            Console.WriteLine("OS:" + this.OS);
        }
    }
    class Apple : Product
    {

        public int ProductId;
        public string Name;
        public float Price;
        public int RAM;
        public float DisplaySize;
        public string DiskSize;
        public string OS;

        public override void inputProduct()
        {
            Console.WriteLine("Enter Product Id:");
            ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter RAM:");
            RAM = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Display Size:");
            DisplaySize = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Disk Size:");
            DiskSize = Console.ReadLine();
            Console.WriteLine("Enter OS:");
            OS = Console.ReadLine();
        }

        public override void outputProduct()
        {
            //base.outputProduct();
            Console.WriteLine("Product Id:" + ProductId);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("RAM:" + RAM);
            Console.WriteLine("Display Size:" + DisplaySize);
            Console.WriteLine("Hard Disk Size:" + DiskSize);
            Console.WriteLine("OS:" + OS);
        }

    }
    class Customer
    {
        public string TransactionId;
        public string CustomerName;
       // public int ProductId;
        public string PhoneNumber;
        public string EmailId;
        public string DateofPurchase;
        public Customer(string CustName, string PhoneNo, string Email)//takes customer details
        {
            var time = DateTime.Now;
            this.CustomerName = CustName;
            //this.ProductId = ProdId;
            this.PhoneNumber = PhoneNo;
            this.EmailId = Email;
            this.TransactionId = time.ToString("hhmmss");
            this.DateofPurchase = time.ToString("yyyy-MM-dd  hh:mm:ss");

        }

        public void display()//displays customer information
        {
            
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.Write(CustomerName + "\t\t");
            Console.Write(TransactionId + "\t\t");
//Console.Write(ProductId + "\t\t");
            Console.Write(PhoneNumber + "\t\t");
            Console.Write(DateofPurchase + "\t");
            Console.Write(EmailId);
        }
    }


}
    