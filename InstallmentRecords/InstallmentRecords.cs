namespace InstallmentRecords
{
    public class InstallmentRecords
    {
        private static DateTime _DayOfPurchase;

      
        public static void output(string purchaseDate, decimal installmentAmount,decimal totalAmount,string productName,string customerName)
        {


            Console.WriteLine($"Here Purchased on {purchaseDate}," +
                $" Installment  Amount ₦ {installmentAmount}," +
                $"Total Amount Recieved ₦ {totalAmount} " +
                $" For Product {productName} by Customer {customerName}\n");
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
            }catch(Exception ex)
            {
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
            }
            catch (Exception ex)
            {
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
            }
            catch (Exception ex)
            {
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

                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddMonths(1);
                }
            }
            catch (Exception ex)
            {
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
            }
            catch (Exception ex)
            {
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

                for (decimal i = InstallmentAmount; i <= customer.GetProductAmount(); i += InstallmentAmount)
                {

                    output(_DayOfPurchase.ToLongDateString(), InstallmentAmount,
                         customer.GetProductAmount(), customer.GetProductName(),
                         customer.GetCustumerName()
                         );
                    _DayOfPurchase = _DayOfPurchase.AddYears(1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }


    public class Application
    {

        public void Run()
        {
            try
            {
                Console.WriteLine("Hello and welcome to our store");
                Console.WriteLine("What is your name: ");
                string? CustomerName = Console.ReadLine();
                Console.WriteLine("What product would you like to buy: ");
                string? ProductName = Console.ReadLine();
                Console.WriteLine("Amount you will be paying for the product: ");
                decimal ProductAmount = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Select an Installment Payment Plan ");
                Console.WriteLine("1. 2% installmental Payment with Daily Plan");
                Console.WriteLine("2. 5% installmental Payment with Weekly Plan");
                Console.WriteLine("3. 7% installmental Payment with Bi-Weekly Plan");
                Console.WriteLine("4. 10% installmental Payment with Monthly Plan");
                Console.WriteLine("5. 15% installmental Payment with Six-Month Plan");
                Console.WriteLine("6. 50% installmental Payment with Yearly");
                string? plan = Console.ReadLine();

                Customer customer = new Customer(CustomerName, ProductName, ProductAmount);
                    if (plan == "1")
                    {
                        InstallmentRecords.DailyInstallmentPlan(customer);
                    }
                    else if (plan == "2")
                    {
                        InstallmentRecords.WeeklyInstallmentPlan(customer);
                    }
                    else if (plan == "3")
                    {
                        InstallmentRecords.BiWeeklyInstallmentPlan(customer);

                    }
                    else if (plan == "4")
                    {
                        InstallmentRecords.MonthlyInstallmentPlan(customer);
                    }
                    else if (plan == "5")
                    {
                        InstallmentRecords.Six_MonthlyInstallmentPlan(customer);
                    }
                    else if (plan == "6")
                    {
                        InstallmentRecords.YearlyInstallmentPlan(customer);
                    }
                    else
                    {
                        Console.WriteLine("Choose a valid option");
                    Console.ReadLine();
                    }
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }



}
