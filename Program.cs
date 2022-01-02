using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            ReadCSVFile();
            Console.ReadLine();
        }
        public static void ReadCSVFile()
        {
            var lines = File.ReadAllLines("priceList.csv");
            var list = new List<PriceList>();
            foreach (var line in lines)
            {

                var values = line.Split(',');
                var PriceList = new PriceList() { Group = values[0], Hour = values[1], Price = values[1] };
                list.Add(PriceList);
            }
            list.ForEach(x => Console.WriteLine($"{x.Group}\t{x.Hour}\t{x.Price}"));
        }
        public class PriceList
        {
            public string Group { get; set; }
            public string Hour { get; set; }
            public string Price { get; set; }
        }
        public class CustomerInfo
        {
            public string customerIDTxt { get; set; }
            public string customerTypeCombo { get; set; }
            public string timeInTimer { get; set; }
            public string dateTime { get; set; }
            public string dayCombo { get; set; }
            public string timeOutTimer { get; set; }
            public string durationTxt { get; set; }
            public string totalAmountTxt { get; set; }
        }

    }
}
