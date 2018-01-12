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
    public partial class Cashdraw_Open : Form
    {
        public Cashdraw_Open()
        {
            InitializeComponent();
        }
        public string Date
        {
            set
            {
                txtdate.Text = value;
            }
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            query = "select * from Shift where Date='" + txtdate.Text + "'";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("--Cashdraw Already Started--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            else
            {
                query = "insert into Shift (Date, Start, Status) values ('" + txtdate.Text + "', '" + txtbalance.Text + "', '" + "Pending" + "')";
                msg = db.Insert(query);
                if (msg == "1")
                {
                    MessageBox.Show("--Cashdraw Started--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

         

        private void Cashdraw_Open_Load(object sender, EventArgs e)
        {
            query = "select [End] from Shift where Date in (select max(Date) from Shift)";
            tb = db.Search(query);
            if (tb.Rows.Count>0)
            {
                txtbalance.Text = tb.Rows[0][0].ToString();
                txtbalance.Enabled = false;
            }
            else
            {
                txtbalance.Text = "0";
                txtbalance.Enabled = true;
            }
        }
    }
}
