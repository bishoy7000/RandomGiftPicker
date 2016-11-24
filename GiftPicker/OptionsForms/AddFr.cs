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
    public partial class AddFr : Form
    {
        LogicAssets.User user = new LogicAssets.User();
        public AddFr()
        {
            DataTable frLists = user.friendLists();
            InitializeComponent();
            frList.DataSource = frLists;
            frList.DisplayMember = "name";
            frList.ValueMember   = "ID";
            frList.Enabled = true;
        }

        private void addFrbutton_Click(object sender, EventArgs e)
        {
            LogicAssets.Friend friend = new LogicAssets.Friend();
            friend.name        = this.frName.Text;
            friend.anniversary = this.aniverDate.Value.Date;
            friend.frList      = Int32.Parse(this.frList.SelectedValue.ToString());
            if (user.add(friend))
            {
                MessageBox.Show("Friend Was Added");
            }else {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
