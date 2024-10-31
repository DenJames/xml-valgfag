namespace xdocument.Models;

public class InvoiceLine
{
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int Amount { get; set; }

    public InvoiceLine(string productName, string productDescription, int amount)
    {
        ProductName = productName;
        ProductDescription = productDescription;
        Amount = amount;
    }
}