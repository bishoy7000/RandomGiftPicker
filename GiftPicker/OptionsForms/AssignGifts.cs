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
    public partial class AssignGifts : Form
    {
        LogicAssets.User user = new LogicAssets.User();
        public AssignGifts()
        {
            DataTable frLists = user.friendLists();
            DataTable giftLists = user.giftLists();
            InitializeComponent();
            frList.DataSource = frLists;
            frList.DisplayMember = "name";
            frList.ValueMember = "ID";
            frList.Enabled = true;

            giftList.DataSource = giftLists;
            giftList.DisplayMember = "name";
            giftList.ValueMember = "ID";
            giftList.Enabled = true;
        }

        private void assign_Click(object sender, EventArgs e)
        {
            if (user.assign(Int32.Parse(this.frList.SelectedValue.ToString()), Int32.Parse(this.giftList.SelectedValue.ToString())))
            {
                MessageBox.Show("Successfully Assigned");
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void frList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        //private void frList_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    giftList.SelectedValue = LogicAssets.DB.select_appropriate_giftList(Int32.Parse(this.frList.SelectedValue.ToString()));
        //}

        //private void frList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string x = this.frList.SelectedValue.ToString();
        //    giftList.SelectedValue = LogicAssets.DB.select_appropriate_giftList(Int32.Parse(this.frList.SelectedValue.ToString()));
        //}
    }
}
