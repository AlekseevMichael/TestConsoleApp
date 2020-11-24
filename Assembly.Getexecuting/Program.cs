using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace assemblygetexecuting
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument d = new XDocument(
                new XComment("This is a comment."),
                new XProcessingInstruction("xml-stylesheet",
                    "href='mystyle.css' title='Compact' type='text/css'"),
            new XElement("Pubs",
                new XElement("Book",
                    new XElement("Title", "Artifacts of Roman Civilization"),
                    new XElement("Author", "Moreno, Jordao")
            ),
                new XElement("Book",
                    new XElement("Title", "Midieval Tools and Implements"),
                    new XElement("Author", "Gazit, Inbar")
            )
        ),
        new XComment("This is another comment.")
        );
        d.Declaration = new XDeclaration("1.0", "utf-8", "true");
        Console.WriteLine(d);
        }
    }
}
