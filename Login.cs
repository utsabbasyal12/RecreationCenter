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
    public partial class Login : Form
    {
        XmlSerializer xmlSerializer;
        List<Users> users;

        public Login()
        {
            InitializeComponent();
            users = new List<Users>();
            xmlSerializer = new XmlSerializer(typeof(List<Users>));
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //importing XML file for employee login
            FileStream fileStream = new FileStream("D:/Islington/3rd Year/Application Development/Coursework/RecreationCenter/employeelogin.xml", FileMode.OpenOrCreate, FileAccess.Read);
            users = (List<Users>)xmlSerializer.Deserialize(fileStream);

            String loginUsername = usernameTxt.Text;
            String loginPassword = passwordTxt.Text;

            Boolean loggedin = false;
            foreach (Users user in users)
            {
                Console.WriteLine(user.usernameTxt);
                Console.WriteLine(user.passwordTxt);
                if (user.usernameTxt == loginUsername && user.passwordTxt == loginPassword)
                {
                    MessageBox.Show("Congratulations!! You have successfully logged into the system");
                    loggedin = true;
                    using (Dashbord page = new Dashbord())
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
            /*string user = usernameTxt.Text;
            string pass = passwordTxt.Text;
            if (user.Trim() == "" && pass.Trim() == "")
            {
                MessageBox.Show("Please Enter Username and Password");
            }
            else
            {
                *//*if (user == "admin" && pass == "admin")
                {

                    using (Dashbord page = new Dashbord())
                    {
                        this.Hide();
                        page.ShowDialog();
                    }
                }*//*
                else
                {
                    MessageBox.Show("Invalid Details");
                }
            }*/
        }

        private void adminLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (AdminLogin page = new AdminLogin())
            {
                this.Hide();
                page.ShowDialog();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
