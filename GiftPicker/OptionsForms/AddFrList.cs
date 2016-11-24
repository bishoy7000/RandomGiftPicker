using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftPicker.OptionsForms
{
    public partial class AddFrList : Form
    {
        LogicAssets.User user = new LogicAssets.User();
        public AddFrList()
        {
            DataTable giftList = user.giftLists();
            InitializeComponent();
            giftLists.DataSource = giftList;
            giftLists.DisplayMember = "name";
            giftLists.ValueMember = "ID";
            giftLists.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicAssets.frList frList = new LogicAssets.frList();
            frList.name = frListName.Text;
            frList.giftList = Int32.Parse(this.giftLists.SelectedValue.ToString());
            if (user.add(frList))
            {
                MessageBox.Show("Friend List Was Added");
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
