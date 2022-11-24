namespace InstallmentRecords
{
    public class InstallmentRecords
    {
        private static DateTime _DayOfPurchase;

        //calculate for daily installment plan
        public static void output(string purchaseDate, decimal installmentAmount,decimal totalAmount,string productName,string customerName)
        {
        
        
            Console.WriteLine($"Here Here Purchased on {purchaseDate}," +
                $" Installment  Amount ₦ {installmentAmount}," +
                $"Total Amount Recieved ₦ {totalAmount} " +
                $" For Product {totalAmount} by Customer {totalAmount}");
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

        //calculate for daily installment plan
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

        //calculate for daily installment plan
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
                Console.WriteLine("2% installmental Payment with Daily Plan, Type 1");
                Console.WriteLine("5% installmental Payment with Weekly Plan , Type 2");
                Console.WriteLine("7% installmental Payment with Bi-Weekly Plan , Type 3");
                Console.WriteLine("10% installmental Payment with Monthly Plan , Type 4");
                Console.WriteLine("15% installmental Payment with Six-Month Plan , Type 5");
                Console.WriteLine("50% installmental Payment with Yearly , Type 6");
                string? plan = Console.ReadLine();

                Customer customer = new Customer(CustomerName, ProductName, ProductAmount);

                if (plan == "1")
                {
                    InstallmentRecords.DailyInstallmentPlan(customer);
                }else if (plan == "2")
                {
                    InstallmentRecords.WeeklyInstallmentPlan(customer);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }



}
