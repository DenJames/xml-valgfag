namespace xdocument.Models;

public class Member
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Invoice Invoice { get; set; }

    public Member(string name, string address, Invoice invoice)
    {
        Name = name;
        Address = address;
        Invoice = invoice;
    }
}