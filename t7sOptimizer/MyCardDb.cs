using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using t7sOptimizer.Entity;

namespace t7sOptimizer
{
    class MyCardDb
    {

        Table<HoldCard> holdCard;
        Table<Ing> ing;

        const string T7sDbFileName = "myCard.db";


        DataContext context;

        internal Table<HoldCard> HoldCard { get => holdCard; set => holdCard = value; }
        internal Table<Ing> Ing { get => ing; set => ing = value; }

        public MyCardDb()
        {
            var connection = new SQLiteConnection("DataSource=" + T7sDbFileName);
            context = new System.Data.Linq.DataContext(connection);
            holdCard = context.GetTable<HoldCard>();
            ing = context.GetTable<Ing>();

        }

        public void SubmitChanges()
        {
            context.SubmitChanges();
        }
    }
}
