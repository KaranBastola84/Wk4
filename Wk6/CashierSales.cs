namespace Wk4.Wk6
{
    // CashierSales class for aggregation example
    public class CashierSales
    {
        public string CashierName { get; set; }
        public int CashierId { get; set; }
        public double DailySales { get; set; }

        public CashierSales(string cashierName, int cashierId, double dailySales)
        {
            CashierName = cashierName;
            CashierId = cashierId;
            DailySales = dailySales;
        }

        public override string ToString()
        {
            return $"Cashier #{CashierId}: {CashierName} - Rs. {DailySales:F2}";
        }
    }
}
