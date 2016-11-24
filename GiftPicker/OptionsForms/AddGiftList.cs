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
    public partial class AddGiftList : Form
    {
        LogicAssets.User user = new LogicAssets.User();

        public AddGiftList()
        {
            InitializeComponent();
        }

        private void giftListAdd_Click(object sender, EventArgs e)
        {
            LogicAssets.giftList giftList = new LogicAssets.giftList();
            giftList.name = this.giftListName.Text;
            if (user.add(giftList))
            {
                MessageBox.Show("Gift List Was Added");
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
