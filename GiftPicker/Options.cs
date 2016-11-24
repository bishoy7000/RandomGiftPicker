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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void frAdd_Click(object sender, EventArgs e)
        {
            OptionsForms.AddFr AddFr = new OptionsForms.AddFr();
            AddFr.ShowDialog();
        }

        private void frListAdd_Click(object sender, EventArgs e)
        {
            OptionsForms.AddFrList AddFrList = new OptionsForms.AddFrList();
            AddFrList.ShowDialog();
        }

        private void giftAdd_Click(object sender, EventArgs e)
        {
            OptionsForms.AddGift AddGift = new OptionsForms.AddGift();
            AddGift.ShowDialog();
        }

        private void giftListADD_Click(object sender, EventArgs e)
        {
            OptionsForms.AddGiftList AddGiftList = new OptionsForms.AddGiftList();
            AddGiftList.ShowDialog();
        }

        private void giftAssign_Click(object sender, EventArgs e)
        {
            OptionsForms.AssignGifts AssignGifts = new OptionsForms.AssignGifts();
            AssignGifts.ShowDialog();
        }
    }
}
