// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using xdocument;
using xdocument.Models;

// Create an instance of the XmlSerializer.
XmlSerializer serializer =
    new XmlSerializer(typeof(InvoiceExport));

// Declare an object variable of the type to be deserialized.
InvoiceExport i;

string filePath = "C:\\Users\\denni\\RiderProjects\\xdocument\\xdocument\\valid.xml";

using (Stream reader = new FileStream(filePath, FileMode.Open))
{
    // Call the Deserialize method to restore the object's state.
    i = (InvoiceExport)serializer.Deserialize(reader);
}

i.MadeBy = "Dennis Doe";

string newFilePath = "C:\\Users\\denni\\RiderProjects\\xdocument\\xdocument\\new_valid.xml";

using (Stream writer = new FileStream(newFilePath, FileMode.Create))
{
    serializer.Serialize(writer, i);
}

Console.WriteLine(i);


//
// var invoiceLines = new List<InvoiceLine>
// {
//     new InvoiceLine("Product 1", "Description 1", 100),
//     new InvoiceLine("Product 2", "Description 2", 200)
// };
//
// var invoice = new Invoice(300, invoiceLines);
//
// var members = new List<Member>
// {
//     new Member("Jane Doe", "Someone street 1", invoice),
//     new Member("John Doe", "Someone street 2", invoice)
// };
//
// var club = new Club("Super Sports Club", "Livøvej 25b", members);
//
// var clubs = new List<Club>
// {
//     club,
//     new Club("Another Club", "H.C Andersens vej 1", members)
// };
//
// var invoiceExport = new InvoiceExport("John Smith", clubs);
//
// var generator = new XmlGenerator(invoiceExport);
//
// generator.execute("InvoiceExport.xml", "InvoiceExport");

