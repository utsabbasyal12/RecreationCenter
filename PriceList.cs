using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenter
{
    public partial class PriceList : Form
    {
        DataTable table = new DataTable("Price List");
        int index;
        public PriceList()
        {
            InitializeComponent();
        }

        private void importPriceBtn_Click(object sender, EventArgs e)
        {
            dgvPriceList.DataSource = LoadCSV1("C: /Users/User/OneDrive/Desktop/WeekendPriceList.csv");
        }
        public List<WeekendPriceList> LoadCSV1(String csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new WeekendPriceList
                        {
                            Category = data[0],
                            Hour = data[1],
                            WeekendPrice = double.Parse(data[2]),
                            WeekdayPrice = double.Parse(data[3])

                        };
            return query.ToList();
        }

        public class WeekendPriceList
        {
            public string Category { get; set; }
            public string Hour { get; set; }
            public double WeekendPrice { get; set; }
            public double WeekdayPrice { get; set; }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dgvPriceList.Rows[index];
            newdata.Cells[0].Value = categoryTxt.Text;
            newdata.Cells[1].Value = hourTxt.Text;
            newdata.Cells[2].Value = weekendPriceTxt.Text;
            newdata.Cells[3].Value = weekdayPriceTxt.Text;
        }

        private void dgvPriceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvPriceList.Rows[index];
            categoryTxt.Text = row.Cells[0].Value.ToString();
            hourTxt.Text = row.Cells[1].Value.ToString();
            weekendPriceTxt.Text = row.Cells[2].Value.ToString();
            weekdayPriceTxt.Text = row.Cells[3].Value.ToString();
        }
        public void writeCSV(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile);



                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }
        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            writeCSV(dgvPriceList, "C: /Users/User/OneDrive/Desktop/WeekendPriceList.csv");
            MessageBox.Show("The Data is Saved Sucessfully");
        }
    }
}
