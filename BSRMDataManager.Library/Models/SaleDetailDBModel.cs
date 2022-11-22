namespace BSRMDataManager.Library.Models
{
    public class SaleDetailDBModel
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quanity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Tax { get; set; }

    }
}
