using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7sOptimizer
{
    class T7sDb
    {
        System.Data.Linq.Table<Idol> idol;
        System.Data.Linq.Table<Rarity> rarity;

        System.Data.Linq.Table<Type> type;

        Table<CardInfo> cardInfo;


        const string T7sDbFileName="t7s.db";
        const string MyCardDbFileName = "myCard.db";

        internal Table<Idol> Idol { get => idol; set => idol = value; }
        internal Table<Rarity> Rarity { get => rarity; set => rarity = value; }
        internal Table<Type> Type { get => type; set => type = value; }
        internal Table<CardInfo> CardInfo { get => cardInfo; set => cardInfo = value; }

        DataContext context;

        public T7sDb()
        {
            var connection = new SQLiteConnection("DataSource=" + T7sDbFileName);
            
            context = new System.Data.Linq.DataContext(connection);
            
            
            Idol = context.GetTable<Idol>();
            Rarity = context.GetTable<Rarity>();
            Type = context.GetTable<Type>();
            CardInfo = context.GetTable<CardInfo>();
        }

        public void SubmitChanges()
        {
            context.SubmitChanges();
        }


    }
}
