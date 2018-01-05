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
    public partial class Find_Products : Form
    {
        public Find_Products()
        {
            InitializeComponent();
        }
       
        string query;
        DataTable tb;
        MainClass db = new MainClass();
        private void txtkey_TextChanged(object sender, EventArgs e)
        {
            if (txtkey.Text!="")
            {
                query = "select * from ItemInformation where Description like '" + "%" + txtkey.Text + "%" + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                    dataGridView1.DataSource = tb;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            else
            { dataGridView1.DataSource = null; }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        { 
        }

        private void Find_Products_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            this.Hide();
        }
    }
}
