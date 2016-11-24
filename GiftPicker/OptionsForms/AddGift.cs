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
    public partial class AddGift : Form
    {
        enum Weight
        {
            Low = 1,
            Medium = 2,
            Hight = 3
        }

        LogicAssets.User user = new LogicAssets.User();
        public AddGift()
        {
            DataTable giftList = user.giftLists();
            InitializeComponent();
            giftLists.DataSource = giftList;
            giftLists.DisplayMember = "name";
            giftLists.ValueMember = "ID";
            giftLists.Enabled = true;
            frequency.DataSource = Enum.GetValues(typeof(Weight));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LogicAssets.Gift gift = new LogicAssets.Gift();
            gift.name = this.giftName.Text;
            gift.giftList = Int32.Parse(this.giftLists.SelectedValue.ToString());
            gift.weight = (int) Enum.Parse(typeof(Weight), frequency.SelectedValue.ToString());
            if (user.add(gift))
            {
                MessageBox.Show("Gift Was Added");
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
