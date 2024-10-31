using System;
using System.Xml.Linq;

namespace xdocument
{
    public class Nested
    {
        public void print()
        {
            var invoiceExport1 = new XDocument(
                new XElement("InvoiceExport",
                    new XElement("MadeBy", "John Doe"),

                    new XElement("Clubs",
                        new XElement("Club",
                            new XElement("Name", "Super Sports Club"),
                            new XElement("Address", "Livøvej 25b"),

                            new XElement("Members",
                                new XElement("Member",
                                    new XElement("Name", "Jane Doe"),
                                    new XElement("Address", "Someone street 1")
                                ),

                                new XElement("Member",
                                    new XElement("Name", "John Doe"),
                                    new XElement("Address", "Someone street 2")
                                )
                            )
                        ),

                        new XElement("Club",
                            new XElement("Name", "Another Club"),
                            new XElement("Address", "H.C Andersens vej 1"),

                            new XElement("Members",
                                new XElement("Member",
                                    new XElement("Name", "Jane Smith"),
                                    new XElement("Address", "Somewhere street 1"),

                                    new XElement("Invoice",
                                        new XElement("TotalAmount", 300),

                                        new XElement("InvoiceLine",
                                            new XElement("ProductName", "Product 1"),
                                            new XElement("ProductDescription", "Description 1"),
                                            new XElement("Amount", 100)
                                        ),

                                        new XElement("InvoiceLine",
                                            new XElement("ProductName", "Product 2"),
                                            new XElement("ProductDescription", "Description 2"),
                                            new XElement("Amount", 200)
                                        )
                                    )
                                ),

                                new XElement("Member",
                                    new XElement("Name", "John Smith"),
                                    new XElement("Address", "Somewhere street 2"),

                                    new XElement("Invoice",
                                        new XElement("TotalAmount", 400),

                                        new XElement("InvoiceLine",
                                            new XElement("ProductName", "Product 3"),
                                            new XElement("ProductDescription", "Description 3"),
                                            new XElement("Amount", 300)
                                        ),

                                        new XElement("InvoiceLine",
                                            new XElement("ProductName", "Product 4"),
                                            new XElement("ProductDescription", "Description 4"),
                                            new XElement("Amount", 100)
                                        )
                                    )
                                )
                            )
                        )
                    )
                )
            );

            Console.WriteLine(invoiceExport1);
        }
    }
}