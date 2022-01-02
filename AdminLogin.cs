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
using System.Xml.Serialization;

namespace RecreationCenter
{
    public partial class AdminLogin : Form
    {
        XmlSerializer xmlSerializer;
        List<Users> users;
        public AdminLogin()
        {
            InitializeComponent();
            users = new List<Users>();
            xmlSerializer = new XmlSerializer(typeof(List<Users>));
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("D:/Islington/3rd Year/Application Development/Coursework/RecreationCenter/adminLogin.xml", FileMode.OpenOrCreate, FileAccess.Read);
            users = (List<Users>)xmlSerializer.Deserialize(fileStream);

            String loginPassword = passwordTxt.Text;

            Boolean loggedin = false;
            foreach (Users user in users)
            {
                Console.WriteLine(user.passwordTxt);
                if (user.passwordTxt == loginPassword)
                {
                    MessageBox.Show("Congratulations!! You have successfully logged into the system");
                    loggedin = true;
                    using (Admin page = new Admin())
                    {
                        this.Hide();
                        page.ShowDialog();
                    }
                }
            }
            if (loggedin == false)
            {
                MessageBox.Show("NOT AUTHORIZED. Please enter right details!");
            }

            fileStream.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            using(Login page = new Login())
            {
                this.Hide();
                page.ShowDialog();
            }
        }
    }
}
