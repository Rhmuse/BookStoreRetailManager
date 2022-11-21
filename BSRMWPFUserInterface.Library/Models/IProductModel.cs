namespace BSRMWPFUserInterface.Library.Models
{
    public interface IProductModel
    {
        string Description { get; set; }
        int Id { get; set; }
        string ProductName { get; set; }
        int QuantityInStock { get; set; }
        decimal RetailPrice { get; set; }
        bool IsTaxable { get; set; }
    }
}