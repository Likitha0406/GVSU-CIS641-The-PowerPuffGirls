using System;
using System.Linq.Expressions;
using SQLite;
using System.Linq;

namespace nitesh_passman.ViewModel
{
	public class DatabaseService
	{
        SQLiteConnection Database;
        public const string dbFName = "niteshpassman3.db3";

        public DatabaseService()
        {
        }


        public const SQLite.SQLiteOpenFlags DbFlags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string dbPath =>
            Path.Combine(Microsoft.Maui.Storage.FileSystem.AppDataDirectory, dbFName);

        void refreshDB()
        {
            try
            {
                if (Database is not null)
                    return;

                Database = new SQLiteConnection(dbPath, DbFlags);
                Database.CreateTable<PasswordModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public List<PasswordModel> GetAllExpression()
        {
            refreshDB();
            return Database.Table<PasswordModel>().ToList();
          
        }

        public void SaveItemAsync(PasswordModel pass)
        {
            refreshDB();
            Database.Insert(pass);
        }

        public void RemoveItem(int id)
        {
            try
            {
            refreshDB();
            Database.Delete(Database.Table<PasswordModel>().ToList().Find((e)=> e.id == id));
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteAllAsync()
        {
            refreshDB();
            Database.DeleteAll<PasswordModel>();
        }
    }
}

