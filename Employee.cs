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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void entryTicketBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Controls.Clear();
            EntryForm menu1 = new EntryForm();
            menu1.TopLevel = false;
            sidePanel.Controls.Add(menu1);
            menu1.Show();
        }
    }
}
