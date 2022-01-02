using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenter
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void changeRateBtn_Click(object sender, EventArgs e)
        {
            PriceList page = new PriceList() { TopLevel = false, TopMost = true };
            page.FormBorderStyle = FormBorderStyle.None;
            this.adminMainPanel.Controls.Add(page);
            page.Show();
        }

        private void viewReportBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
