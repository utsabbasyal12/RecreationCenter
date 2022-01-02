using System;
using System.Data;
using System.Windows.Forms;

namespace RecreationCenter
{
    public partial class Dashbord : Form
    {
        DataTable table = new DataTable("table");
        int index;

        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Customer ID", Type.GetType("System.Int32"));
            table.Columns.Add("Customer Type", Type.GetType("System.String"));
            table.Columns.Add("Time In", Type.GetType("System.String"));
            table.Columns.Add("Date", Type.GetType("System.DateTime"));
            table.Columns.Add("Day", Type.GetType("System.String"));
            

            timeInTimer.Text = DateTime.Now.ToLongTimeString();
            timeOutTimer.Text = DateTime.Now.ToLongTimeString();
            dataGridView1.DataSource = table;
        }

        private void CustomerInBtn_Click(object sender, EventArgs e)
        {
            
                table.Rows.Add(customerIDTxt.Text, customerTypeCombo.Text, /*timeInPicker.Value*/ timeInTimer.Text, dateTime.Value
                    , dayCombo.Text);
                customerIDTxt.Text = String.Empty;
            
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            exitCustomerIDTxt.Text = row.Cells[0].Value.ToString();
            exitTimeInTxt.Text = row.Cells[2].Value.ToString();
            /*label2.Text = row.Cells[2].Value.ToString();*/
            /*exitTimeInPicker.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
*/
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeInTimer.Text = DateTime.Now.ToLongTimeString();
            timeOutTimer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void customerOutBtn_Click(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime(exitTimeInTxt.Text);
            DateTime endTime = Convert.ToDateTime(timeOutTimer.Text);
            TimeSpan duration = new TimeSpan(endTime.Ticks - startTime.Ticks);
            this.durationTxt.Text = duration.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Customer Information";
            dt.Columns.Add("Customer ID");
            dt.Columns.Add("Customer Type");
            dt.Columns.Add("Time In");
            dt.Columns.Add("Date");
            dt.Columns.Add("Day");

            ds.Tables.Add(dt);

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["Customer Information"].NewRow();
                row["Customer ID"] = r.Cells[0].Value;
                row["Customer Type"] = r.Cells[1].Value;
                row["Time In"] = r.Cells[2].Value;
                row["Date"] = r.Cells[3].Value;
                row["Day"] = r.Cells[4].Value;
                
                ds.Tables["Customer Information"].Rows.Add(row);

            }
            ds.WriteXml("D:/Islington/3rd Year/Application Development/Coursework/RecreationCenter.CustomerInfo.xml");
            MessageBox.Show("The File Save Sucessfully");
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:/Islington/3rd Year/Application Development/Coursework/RecreationCenter.CustomerInfo.xml");
            dataGridView1.Rows.Clear();
            foreach(DataRow item in ds.Tables["Customer Information"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0];
                dataGridView1.Rows[n].Cells[1].Value = item[1];
                dataGridView1.Rows[n].Cells[2].Value = item[2];
                dataGridView1.Rows[n].Cells[3].Value = item[3];
                dataGridView1.Rows[n].Cells[4].Value = item[4];
               
            }
        }
    }
    
} 