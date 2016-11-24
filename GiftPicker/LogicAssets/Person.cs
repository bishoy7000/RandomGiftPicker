using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftPicker.LogicAssets
{
    /*This is a very poor design as only one subclass will implement this abstract class
    but it's for the sake of Demonstration for Polymorphism */

    abstract class Person
    {
        public virtual Boolean add(LogicAssets.Friend friend) { return false; }
        public virtual Boolean add(LogicAssets.frList list)   { return false; }
        public virtual Boolean add(LogicAssets.Gift gift)     { return false; }
        public virtual Boolean add(LogicAssets.giftList list) { return false; }
        public virtual Boolean assign(int frListID, int giftListID) { return false; }
    }
}
