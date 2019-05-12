using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TopShredinger.Data;
using TopShredinger.UWP.Data;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace TopShredinger.UWP.Data
{
    public class SQLite_UWP : ISQLite
    {
        public SQLite_UWP() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "top.db";
            var documentPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}
