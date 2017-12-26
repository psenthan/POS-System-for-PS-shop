using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Super_Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string query, msg;
        MainClass db = new MainClass();
        DataTable tb;

        private void Form1_Load(object sender, EventArgs e)
        {
            //calling a method. which checks for existing users, if no any, system suggest to register a user with admin privilage.
            CheckExistingUsers();
        }

        private void CheckExistingUsers()
        {
            //query to get records where role is Admin. 
            query = "select * from Login where Role ='"+db.Encrypt("Administrator")+"'";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                //if any user exist. do nothing
            }
            else
            {
                //no user found. promote to register a user.
                User_Management ur = new User_Management();
                ur.ShowDialog();
                CheckExistingUsers();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                Authenticate();
            }
        }

        private void Authenticate()
        {
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                query = "select * from Shift where Date<>'" + txtdate.Text + "' and Status<>'" + "Closed" + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    Cashdraw_Close cr = new Cashdraw_Close();
                    cr.Date = tb.Rows[0][0].ToString();
                    cr.ShowDialog();
                    Authenticate();
                }
                else
                {
                    query = "select Active, Role from Login where Username='" + db.Encrypt(txtusername.Text) + "' and Password='" + db.Encrypt(txtpassword.Text) + "' and Active='" + db.Encrypt("1") + "'";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        Main_Menu mm = new Main_Menu();
                        string[] info = { txtdate.Text, txtusername.Text };
                        mm.Info = info;
                        mm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
