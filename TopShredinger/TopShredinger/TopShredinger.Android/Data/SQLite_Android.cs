using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using TopShredinger.Data;
using System.IO;
using Xamarin.Forms;
using TopShredinger.Droid.Data;

[assembly: Dependency(typeof(SQLite_Android))]
namespace TopShredinger.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "top.db";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}