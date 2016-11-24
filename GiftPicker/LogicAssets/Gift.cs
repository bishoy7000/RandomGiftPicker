using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftPicker.LogicAssets
{
    public class Gift
    {
        private int ID;
        public int getID() { return this.ID; }
        public string name { get; set; }
        public int giftList { get; set; }
        public int weight { get; set; }
    }
}
