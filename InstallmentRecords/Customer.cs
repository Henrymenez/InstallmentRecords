namespace InstallmentRecords
{
    public class Customer
    {
        private string CustomerName { get; set; }
        private string ProductName { get; set; }
        private decimal ProductAmount { get; set; }

        public Customer(string customername, string productname, decimal productamount)
        {
            CustomerName = customername;
            ProductName = productname;
            ProductAmount = productamount;
        }

        public string GetCustumerName()
        {
            return CustomerName;
        }
        public decimal GetProductAmount()
        {
            return ProductAmount;
        }
        public string GetProductName()
        {
            return ProductName;
        }

    }
}
