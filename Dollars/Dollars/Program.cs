using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking the user for input
            Console.Write("Enter dollars to convert: ");
            // tryparsing input to prevent bad inputs
            bool validDec = decimal.TryParse(Console.ReadLine(), out decimal dollars);
            // run until input is good
            while (!validDec)
            {
                Console.Write("Please enter a valid decimal: ");
                validDec = decimal.TryParse(Console.ReadLine(), out dollars);
            }
            // define remainder
            decimal remainder = dollars;
            // deserialize the XML document into an object C# can understand and interact with
            string path = "..//..//..//config.xml";
            StreamReader reader = new StreamReader(path);
            config _config = (config)new XmlSerializer(typeof(config)).Deserialize(reader);
            reader.Close();
            // begin listing denominations
            List<int> denominations = new List<int> { };
            // looping to add every denomination in configuration file if it is a valid number
            foreach (denomination denom in _config.denominations)
            {
                if (int.TryParse(denom.value, out int epic))
                {
                    denominations.Add(epic);
                }
                else Console.WriteLine(string.Format("{0} is not a valid int... skipping..", denom.value));
            }
            // beginning output string
            string output = string.Format("{0} is: ", dollars.ToString("C"));
            // looping through every denomination and keeping the remainder
            foreach (int denomination in denominations)
            {
                int billCount = decimal.ToInt32(remainder / denomination);
                if (billCount != 0) {
                    remainder %= denomination;
                }
                output += string.Format("{0} ${1}'s, ", billCount, denomination);
            }
            // finishing up output
            output += string.Format("and a remainder of {0}", remainder.ToString("C"));
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
    // Root XML of <config></config>
    [XmlRoot("config")]
    public class config
    {
        [XmlElement("denomination")]
        // creating array of denomination class
        public denomination[] denominations { get; set; }
    }
    public class denomination
    {
        // defined each denomination as <denomination value=""/>
        [XmlAttribute("value")]
        public string value { get; set; }
    }
}