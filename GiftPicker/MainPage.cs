using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftPicker
{
    public partial class MainPage : Form
    {
        LogicAssets.User user = new LogicAssets.User();
        public MainPage()
        {
            InitializeComponent();
            ListInputs();
        }

        public void ListInputs() {
            this.friends.DataSource = LogicAssets.DB.all_friends().Tables[0];
            this.friends.DisplayMember = "name";
            this.friends.ValueMember = "ID";
            syncLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        Options options = new Options();
        private void button1_Click(object sender, EventArgs e)
        {
            options.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String selectedGiftName = user.giftFriend(Int32.Parse(this.friends.SelectedValue.ToString()));
            if ( selectedGiftName != null)
            {
                MessageBox.Show(selectedGiftName);
                ListInputs();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            ListInputs();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
