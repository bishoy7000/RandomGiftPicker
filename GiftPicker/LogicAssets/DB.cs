using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftPicker.LogicAssets
{
    class DB
    {
        public DB() {
            using (SQLiteConnection db = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {
                //create friends table
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS [friends] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [name] text(2048)  NULL,
                          [anniversary] text(2048)  NULL,
                          [list] INTEGER NOT NULL,  
                          [last_gifted] datetime
                          )";
                this.createtable(db, createTableQuery);

                //create a default friendlist called Friends with ID = 1 if the table is empty
                using (SQLiteCommand command = new SQLiteCommand(db))
                {
                    db.Open();
                    command.CommandText = "SELECT name FROM sqlite_master WHERE name='frList'";
                    var name = command.ExecuteScalar();
                    db.Close();
                    if (name == null)
                    {
                        //create frList table
                        createTableQuery = @"CREATE TABLE IF NOT EXISTS [frList] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [name] text(2048)  NULL,
                          [gift_list] INTEGER NULL
                          )";
                        this.createtable(db, createTableQuery);

                        //create default row
                        command.CommandText = "INSERT INTO frlist (name, gift_list) VALUES ('Friends',1)";
                        db.Open();
                        command.ExecuteNonQuery();
                        db.Close();
                    }
                }

                //create gift table
                createTableQuery = @"CREATE TABLE IF NOT EXISTS [gift] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [name] text(2048)  NULL,
                          [gift_list] INTEGER NOT NULL,
                          [weight] INTEGER NOT NULL
                          )";
                this.createtable(db, createTableQuery);


                using (SQLiteCommand command = new SQLiteCommand(db))
                {
                    db.Open();
                    command.CommandText = "SELECT name FROM sqlite_master WHERE name='giftList'";
                    var name = command.ExecuteScalar();
                    db.Close();
                    if (name == null)
                    {
                        //create giftlist table
                        createTableQuery = @"CREATE TABLE IF NOT EXISTS [giftList] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [name] text(2048)  NULL                         
                          )";
                        this.createtable(db, createTableQuery);

                        //create default row
                        command.CommandText = "INSERT INTO giftList (name) VALUES ('Default Gifts')";
                        db.Open();
                        command.ExecuteNonQuery();
                        db.Close();
                    }
                }
            }
        }

        public void createtable(SQLiteConnection db, string createTableQuery) {
            SQLiteCommand query = new SQLiteCommand(db);
            query.CommandText = createTableQuery;
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }

        public bool addProcedure(SQLiteCommand insert) {
            using (SQLiteConnection db = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;")) {
                insert.Connection = db;
                try
                {
                    db.Open();
                    if (insert.ExecuteNonQuery() > 0)
                    {
                        db.Close(); //Close in case of success situation
                        return true;
                    }
                }
                catch (Exception){throw;}
                db.Close(); //Close in case of failure situation
            }
            return false;
        }

        public object selectScalar(SQLiteCommand select)
        {
            using (SQLiteConnection db = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {
                select.Connection = db;
                try
                {
                    db.Open();
                    object result = select.ExecuteScalar();
                    db.Close();
                    return result;
                }
                catch (Exception)
                {
                    db.Close();
                    throw;
                }
            }
        }

        public Boolean updateProcedure(SQLiteCommand update) {
            using (SQLiteConnection db = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {
                update.Connection = db;
                try
                {
                    db.Open();
                    update.ExecuteNonQuery();
                    db.Close();
                    return true;
                }
                catch (Exception)
                {
                    db.Close();
                    throw;
                }
            }
        }

        public static int select_appropriate_giftList(int frListID) {
            using (SQLiteConnection db = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {
                using (SQLiteCommand select = new SQLiteCommand(db))
                {
                    select.CommandText = "SELECT gift_list FROM frlist WHERE ID= @id";
                    select.Parameters.AddWithValue("id", frListID);
                    try
                    {
                        db.Open();
                        int giftListID = (int)select.ExecuteScalar();
                        db.Close();
                        return giftListID;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    
                }
            }
        }

        public static DataSet all_friends() {
            using (SQLiteConnection db = new SQLiteConnection("Data source=GiftRandom.sqlite; Version=3;"))
            {
                DataSet friends = new DataSet();
                try
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM friends"+
                        " WHERE strftime('%m-%d', anniversary) - strftime('%m-%d', date('now')) = 0"+
                        " AND strftime('%d', anniversary) - strftime('%d', date('now')) BETWEEN 1 AND 7"+
                        " AND (strftime('%Y', date('now')) - strftime('%Y', last_gifted) > 0"+
                        " OR last_gifted is null)", db);
                    adapter.Fill(friends);
                    return friends;
                }
                catch (Exception)
                {
                    throw;
                }                
            }
        }

   }
}
