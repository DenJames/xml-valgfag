namespace xdocument.Models;

public class InvoiceExport
{
    public string MadeBy { get; set; }
    public List<Club> Clubs { get; set; }

    public InvoiceExport(string madeBy, List<Club> clubs)
    {
        MadeBy = madeBy;
        Clubs = clubs;
    }
}