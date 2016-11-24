using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace GiftPicker.LogicAssets
{
    class User : LogicAssets.Person
    {
        LogicAssets.DB db = new LogicAssets.DB();
        static Random random = new Random();

        public override Boolean add(LogicAssets.Friend friend) {
                using (SQLiteCommand insert = new SQLiteCommand()) {
                    insert.CommandText = "INSERT INTO friends (name,anniversary,list) Values (@frName,@frAnniversary,@frlist)";
                    insert.Parameters.AddWithValue("frName",friend.name);
                    insert.Parameters.AddWithValue("frAnniversary", friend.anniversary.Date);
                    insert.Parameters.AddWithValue("frlist", friend.frList);
                return this.db.addProcedure(insert);
                }
        }

        public override Boolean add(LogicAssets.frList list) {
            using (SQLiteCommand insert = new SQLiteCommand())
            {
                insert.CommandText = "INSERT INTO frList (name,gift_list) Values (@name,@gift_list)";
                insert.Parameters.AddWithValue("name", list.name);
                insert.Parameters.AddWithValue("gift_list", list.giftList);
                return this.db.addProcedure(insert);
            }
        }

        public override Boolean add(LogicAssets.Gift gift) {
            using (SQLiteCommand insert = new SQLiteCommand())
            {
                insert.CommandText = "INSERT INTO gift (name,gift_list,weight) Values (@name,@gift_list,@weight)";
                insert.Parameters.AddWithValue("name", gift.name);
                insert.Parameters.AddWithValue("gift_list", gift.giftList);
                insert.Parameters.AddWithValue("weight", gift.weight);
                return this.db.addProcedure(insert);
            }
        }

        public override Boolean add(LogicAssets.giftList list) {
            using (SQLiteCommand insert = new SQLiteCommand())
            {
                insert.CommandText = "INSERT INTO giftList (name) Values (@name)";
                insert.Parameters.AddWithValue("name", list.name);
                return this.db.addProcedure(insert);
            }
        }

        public override Boolean assign(int frListID, int giftListID)
        {
            using (SQLiteCommand update = new SQLiteCommand()) {
                update.CommandText = "UPDATE frlist SET gift_list = @giftList WHERE ID=@id";
                update.Parameters.AddWithValue("giftList", giftListID);
                update.Parameters.AddWithValue("id", frListID);
                return db.updateProcedure(update);
            }
        }

        public String giftFriend(int frID) {
            using (SQLiteCommand select = new SQLiteCommand())
            {
                //first get the Friend List
                select.CommandText = "SELECT list from friends WHERE ID=@id ";
                select.Parameters.AddWithValue("id",frID );
                int frList = Int32.Parse(db.selectScalar(select).ToString());

                select.CommandText = "SELECT gift_list from frlist WHERE ID=@id";
                select.Parameters.AddWithValue("id", frList);
                int giftList = Int32.Parse(db.selectScalar(select).ToString());

                List<Gift> gifts = new List<Gift>();  //Add the retrived gifts from the same giftlist to later pick from them
                select.CommandText = "SELECT name, weight from gift WHERE gift_list = @id";
                select.Parameters.AddWithValue("id", giftList);
                using (SQLiteConnection dbConnection = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
                {
                    select.Connection = dbConnection;
                    try
                    {
                        dbConnection.Open();
                        select.Connection = dbConnection;
                        using (SQLiteDataReader reader = select.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Gift gift = new Gift();
                                gift.weight = Int32.Parse(reader["weight"].ToString());
                                gift.name = reader["name"].ToString();
                                gifts.Add(gift);
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                
                select.CommandText = "SELECT SUM (weight) from gift WHERE gift_list=@id";
                select.Parameters.AddWithValue("id", giftList);
                int totalWeight = 0;
                try
                {
                    totalWeight = Int32.Parse(db.selectScalar(select).ToString());
                }
                catch (Exception)
                {
                    //there is no gifts in the assigned gift list
                    return "Please Add Gift First";
                }

                Gift selectedGift = RandomGiftSelector(gifts, totalWeight);

                //update that this friend was recently gifted
                if (selectedGift != null)
                {
                    using (SQLiteCommand update = new SQLiteCommand())
                    {
                        update.CommandText = "UPDATE friends SET last_gifted = @last_gifted WHERE ID=@id";
                        update.Parameters.AddWithValue("last_gifted", DateTime.Now.Date);
                        update.Parameters.AddWithValue("id", frID);
                        db.updateProcedure(update);
                        return selectedGift.name;
                    }
                }
            }
            return null;
        }

        public DataTable friendLists() {
            DataTable frLists = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {      
                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT ID, name FROM frList", con);
                    adapter.Fill(frLists);
                    return frLists;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable giftLists()
        {
            DataTable giftLists = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {
                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT ID, name FROM giftList", con);
                    adapter.Fill(giftLists);
                    return giftLists;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private static Random _rnd = new Random();

        public static Gift RandomGiftSelector(List<Gift> gifts, int totalWeight)
        {
            // totalWeight is the sum of all gifts' weight

            int randomNumber = _rnd.Next(0, totalWeight);

            Gift selectedGift = null;
            foreach (Gift gift in gifts)
            {
                if (randomNumber < gift.weight)
                {
                    selectedGift = gift;
                    break;
                }

                randomNumber = randomNumber - gift.weight;
            }

            return selectedGift;
        }
    }
}
