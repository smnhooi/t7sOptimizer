using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace t7sOptimizer
{
    
[Table (Name="idol")]
    class Idol
    {
        [Column(Name = "IdolId", IsPrimaryKey = true,CanBeNull =false)]
        public int IdolId { get; set; }
        [Column(Name = "Name", CanBeNull = false)]
        public String Name { get; set; }
        [Column(Name = "UseCount", CanBeNull = false)]
        public int UseCount { get; set; }
        [Column(Name = "BaseTypeId", CanBeNull = false)]
        public int BaseTypeId { get; set; }
    }

    [Table (Name ="Rarity")]
    class Rarity
    {
        [Column(Name = "RarityId", IsPrimaryKey = true,CanBeNull =false)]
        public int RarityId { get; set; }
        [Column(Name = "Name", CanBeNull = false)]
        public string Name { get; set; }
        [Column(Name = "UseCount", CanBeNull = false)]
        public int UseCount { get; set; }


    }

    [Table(Name = "Type")]
    class Type
    {
        [Column(Name = "TypeId", IsPrimaryKey = true, CanBeNull = false)]
        public int TypeId { get; set; }
        [Column(Name = "Name", CanBeNull = false)]
        public string Name { get; set; }
    }


    [Table(Name = "CardInfo")]
    class CardInfo
    {
        [Column(Name = "CardId", IsPrimaryKey = true, CanBeNull = false)]
        public int CardId { get; set; }
        [Column(Name = "Name", CanBeNull = false)]
        public string Name { get; set; }
        [Column(Name = "IdolId", CanBeNull = false)]
        public int IdolId { get; set; }
        [Column(Name = "RarityId", CanBeNull = false)]
        public int RarityId { get; set; }
        [Column(Name = "HP", CanBeNull = false)]
        public int HP { get; set; }
        [Column(Name = "ATK", CanBeNull = false)]
        public int ATK { get; set; }
        [Column(Name = "TCId", CanBeNull = false)]
        public int TCId { get; set; }
    }


}
