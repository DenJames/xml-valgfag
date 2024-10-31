namespace xdocument.Models;

public class Club
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Member> Members { get; set; }

    public Club(string name, string address, List<Member> members)
    {
        Name = name;
        Address = address;
        Members = members;
    }
}