namespace xdocument.Models;

public class Invoice
{
    public int TotalAmount { get; set; }
    public List<InvoiceLine> InvoiceLines { get; set; }

    public Invoice(int totalAmount, List<InvoiceLine> invoiceLines)
    {
        TotalAmount = totalAmount;
        InvoiceLines = invoiceLines;
    }
}