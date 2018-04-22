using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7sOptimizer.Entity
{

    [Table(Name = "HoldCard")]
    class HoldCard
    {
        [Column(Name = "CardId", IsPrimaryKey = true, CanBeNull = false)]
        public int CardId { get; set; }
        [Column(Name = "Sparkle", CanBeNull = false)]
        public int Sparkle { get; set; }
    }

    [Table(Name ="ing")]
    class Ing
    {
        [Column(Name = "IdolId", IsPrimaryKey = true, CanBeNull = false)]
        public int IdolId { get; set; }
        [Column(Name = "ATKPercentage", CanBeNull = false)]
        public int ATKPercentage { get; set; }
        [Column(Name = "HPPercentage", CanBeNull = false)]
        public int HPPercentage { get; set; }
    }
}
