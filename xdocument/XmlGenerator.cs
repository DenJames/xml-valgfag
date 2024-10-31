namespace xdocument;

using System.Collections;
using System.Xml;

public class XmlGenerator
{
    public object Data { get; set; }

    public XmlGenerator(object data)
    {
        Data = data;
    }

    public void execute(string fileName, string rootElement)
    {
        using (XmlWriter writer = XmlWriter.Create(fileName, new XmlWriterSettings { Indent = true }))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement(rootElement);

            ProcessObject(writer, Data);

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();

            Console.WriteLine($"File saved at: {Path.GetFullPath(fileName)}");
        }
    }

    private void ProcessObject(XmlWriter writer, object data)
    {
        var type = data.GetType();
        var properties = type.GetProperties();

        foreach (var property in properties)
        {
            var value = property.GetValue(data);

            if (value is IList list)
            {
                // Get the type of the items in the list
                var itemType = list.GetType().GetGenericArguments().SingleOrDefault();

                // If the list has a generic type argument, use its name as the element name
                var elementName = itemType != null ? itemType.Name : property.Name;

                foreach (var item in list)
                {
                    writer.WriteStartElement(elementName);
                    ProcessObject(writer, item);
                    writer.WriteEndElement();
                }
            }
            else
            {
                writer.WriteStartElement(property.Name);

                if (value != null)
                {
                    if (value.GetType().IsPrimitive || value is string)
                    {
                        writer.WriteString(value.ToString());
                    }
                    else
                    {
                        ProcessObject(writer, value);
                    }
                }

                writer.WriteEndElement();
            }
        }
    }
}