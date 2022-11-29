namespace InstallmentRecords
{
    public class InstallmentRecords
    {
        private static DateTime _DayOfPurchase;


        public static void output(string purchaseDate, decimal installmentAmount, decimal totalAmount, string productName, string customerName)
        {


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            Console.WriteLine($"Instalment Payment Schedules for: {productName.ToUpper()}, Date: {purchaseDate}, Installment  Amount: N{installmentAmount},Buyer: {customerName}\n");

        }

        public static void ContinueApp()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n ");
                string continueApp = Console.ReadLine();
                if (continueApp.ToLower() == "y")
                {
                    Application app = new Application();
                    app.Run();
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("Thank you for shopping in our store, looking forward to seeing you again");

        }

        public static void DailyInstallmentPlan(Customer customer)
        {
            try
            {
                decimal InstallmentPercentage = (decimal)(2d / 100);
                _DayOfPurchase = DateTime.Now;
                decimal InstallmentAmount = customer.GetProductAmount() * InstallmentPercentage;

                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                        customer.GetProductAmount(), customer.GetProductName(),
                        customer.GetCustumerName()
                        );
                    _DayOfPurchase = _DayOfPurchase.AddDays(1);
                }
                Console.ForegroundColor = ConsoleColor.White;
                ContinueApp();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }


        }


        public static void WeeklyInstallmentPlan(Customer customer)
        {
            try
            {
                decimal InstallmentPercentage = (decimal)(5d / 100);
                _DayOfPurchase = DateTime.Now;
                decimal InstallmentAmount = customer.GetProductAmount() * InstallmentPercentage;

                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddDays(7);
                }
                Console.ForegroundColor = ConsoleColor.White;
                ContinueApp();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ex.Message);
            }


        }


        public static void BiWeeklyInstallmentPlan(Customer customer)
        {
            try
            {
                decimal InstallmentPercentage = (decimal)(7d / 100);
                _DayOfPurchase = DateTime.Now;
                decimal InstallmentAmount = customer.GetProductAmount() * InstallmentPercentage;

                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddDays(14);
                }
                Console.ForegroundColor = ConsoleColor.White;
                ContinueApp();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }


        }

        public static void MonthlyInstallmentPlan(Customer customer)
        {
            try
            {
                decimal InstallmentPercentage = (decimal)(10d / 100);
                _DayOfPurchase = DateTime.Now;
                decimal InstallmentAmount = customer.GetProductAmount() * InstallmentPercentage;

                Console.Write("loading");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);

                }
                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddMonths(1);
                }
                Console.ForegroundColor = ConsoleColor.White;
                ContinueApp();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }


        }

        public static void Six_MonthlyInstallmentPlan(Customer customer)
        {
            try
            {
                decimal InstallmentPercentage = (decimal)(15d / 100);
                _DayOfPurchase = DateTime.Now;
                decimal InstallmentAmount = customer.GetProductAmount() * InstallmentPercentage;

                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddMonths(6);
                }
                Console.ForegroundColor = ConsoleColor.White;
                ContinueApp();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }


        }

        public static void YearlyInstallmentPlan(Customer customer)
        {
            try
            {
                decimal InstallmentPercentage = (decimal)(50d / 100);
                _DayOfPurchase = DateTime.Now;
                decimal InstallmentAmount = customer.GetProductAmount() * InstallmentPercentage;
                Console.Clear();
                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddYears(1);
                }
                Console.ForegroundColor = ConsoleColor.White;
                ContinueApp();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }


        }
    }


    public class Application
    {
        private string _plan;
        public void ChooseOption()
        {

            Console.WriteLine("Select an Installment Payment Plan ");
            Console.WriteLine("1. 2% installmental Payment For The Daily Plan");
            Console.WriteLine("2. 5% installmental Payment For The Weekly Plan");
            Console.WriteLine("3. 7% installmental Payment For The Bi-Weekly Plan");
            Console.WriteLine("4. 10% installmental Payment For The Monthly Plan");
            Console.WriteLine("5. 15% installmental Payment For The Six-Month Plan");
            Console.WriteLine("6. 50% installmental Payment For The Yearly");
            Console.WriteLine("To Exit Press N ");
             _plan = Console.ReadLine();
        }
        public void Run()
        {
            try
            {
                Console.Title = "Installmental Payment";
                Console.WriteLine("******Hello and welcome to our store******");
                Console.WriteLine("What is your name: ");
                string CustomerName = Console.ReadLine();
                while (CustomerName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insert a valid name");
                    Console.ForegroundColor = ConsoleColor.White;
                    CustomerName = Console.ReadLine();

                }
                Console.WriteLine($"Welcome {CustomerName.ToLower()}, What product would you like to buy: ");
                Console.WriteLine("Example \n Product: Price \n  Beer: 5000 \n Rice: 100 \n");
                Console.Write("Product Name: ");
                string ProductName = Console.ReadLine();
                while (ProductName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insert a valid product name");
                    Console.ForegroundColor = ConsoleColor.White;
                    ProductName = Console.ReadLine();

                }

                Console.Write("Enter Price: ");

                decimal ProductAmount = Math.Abs(Convert.ToDecimal(Console.ReadLine()));

                while (true)
                {
                    ChooseOption();

                    Customer customer = new Customer(CustomerName, ProductName, ProductAmount);
                    if (_plan == "1")
                    {
                        InstallmentRecords.DailyInstallmentPlan(customer);
                    }
                    else if (_plan == "2")
                    {
                        InstallmentRecords.WeeklyInstallmentPlan(customer);
                    }
                    else if (_plan == "3")
                    {
                        InstallmentRecords.BiWeeklyInstallmentPlan(customer);

                    }
                    else if (_plan == "4")
                    {
                        InstallmentRecords.MonthlyInstallmentPlan(customer);
                    }
                    else if (_plan == "5")
                    {
                        InstallmentRecords.Six_MonthlyInstallmentPlan(customer);
                    }
                    else if (_plan == "6")
                    {
                        InstallmentRecords.YearlyInstallmentPlan(customer);
                    }else if(_plan.ToLower() == "n")
                    {
                      Console.WriteLine("Thank you for shopping in our store, looking forward to seeing you again");
                        break;
                      
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Choose a valid option");
                        Console.ForegroundColor = ConsoleColor.White;
                        ChooseOption();
                    }

                }
               

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Run();
            }

        }
    }



}
