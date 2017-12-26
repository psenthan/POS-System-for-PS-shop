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
    public partial class Choose_Items : Form
    {
        public Choose_Items()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;
        public string ItemCode
        {
            set
            {
                label1.Text = "Item Code: " + value;
                query = "select ItemInformation.Description, Inventory.Cost, Inventory.SellPrice, Inventory.ID from ItemInformation, Inventory where ItemInformation.ItemCode='" + value + "' and Inventory.Quantity>0 and Inventory.ItemCode='" + value + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        string[] row = { tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), tb.Rows[i][2].ToString(), tb.Rows[i][3].ToString() };
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }

        private void SelectItem()
        {
            Clipboard.SetText(dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString());
            this.Hide();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void Choose_Items_Load(object sender, EventArgs e)
        {

        }
    }
}
