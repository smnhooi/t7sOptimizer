using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using t7sOptimizer.Entity;

namespace t7sOptimizer
{

    public partial class AddMyCardWnd : Form
    {
        private T7sDb t7SDb;
        MyCardDb myCardDb;
        public AddMyCardWnd()
        {
            InitializeComponent();
        }

        internal T7sDb T7SDb { get => t7SDb; set => t7SDb = value; }
        internal MyCardDb MYCardDb { get => myCardDb; set => myCardDb = value; }

        private void AddMyCardWnd_Load(object sender, EventArgs e)
        {
            var idolQ = from idol in t7SDb.Idol
                        orderby idol.UseCount descending, idol.IdolId
                        select idol;

            IdolCB.ValueMember = "IdolId";
            IdolCB.DataSource = idolQ;
            IdolCB.DisplayMember = "Name";

            var rarityQ = from rare in t7SDb.Rarity
                          orderby rare.UseCount descending, rare.RarityId
                          select rare;

            RarityCB.ValueMember = "RarityId";
            RarityCB.DataSource = rarityQ;
            RarityCB.DisplayMember = "Name";

            RefreshLV();

        }

        private void RefreshLV()
        {
            CardInfoLV.Items.Clear();
            try
            {
                var holdCard = (from hc in myCardDb.HoldCard select  hc).ToList();
                int[] holdCardLs = new int[holdCard.Count];
                Hashtable holdCardSparkleLs = new Hashtable();
                for (int i=0; i<holdCard.Count;i++)
                {
                    holdCardLs[i]=holdCard[i].CardId;
                    holdCardSparkleLs.Add(holdCard[i].CardId, holdCard[i].Sparkle);
                }

                int[] test = { 1, 2 };


                var cardInfoQuery = from ci in t7SDb.CardInfo
                                    from idol in t7SDb.Idol
                                    from rare in t7SDb.Rarity
                                    where !(ci.IdolId != (int)IdolCB.SelectedValue && IdolFChB.Checked == true) &&
                                    !(ci.RarityId != (int)RarityCB.SelectedValue && RarityFChB.Checked == true) &&
                                    !(!holdCardLs.Contains(ci.CardId) && NotHoldChB.Checked == true)&&
                                    (idol.IdolId == ci.IdolId &&
                                    ci.RarityId == rare.RarityId)
                                    select new { IdolName = idol.Name, CardName = ci.Name, Rarity = rare.Name, ci.CardId,Hold = holdCardLs.Contains(ci.CardId)};

               foreach (var i in cardInfoQuery)
                {
                    string[] addedItem = { i.IdolName, i.CardName, i.Rarity,i.Hold==true?"○":"" ,holdCardSparkleLs[i.CardId]!=null? holdCardSparkleLs[i.CardId].ToString() :0.ToString(), i.CardId.ToString()};
                    CardInfoLV.Items.Add(new ListViewItem(addedItem));
                }
            }
            catch (InvalidCastException e)
            {

            }
            catch (NullReferenceException e)
            {

            }
        }

        private void NotHoldChB_CheckedChanged(object sender, EventArgs e)
        {

            RefreshLV();
        }

        private void CardInfoLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rarity = CardInfoLV.SelectedItems[0].SubItems[2].Text;

            switch (rarity)
            {
                case "B":
                    SparkleNUD.Maximum = 5;
                    break;
                case "BS":
                    SparkleNUD.Maximum = 10;
                    break;
                case "S":
                    SparkleNUD.Maximum = 10;
                    break;
                case "SS":
                    SparkleNUD.Maximum = 20;
                    break;
                case "G":
                    SparkleNUD.Maximum = 15;
                    break;
                case "GS":
                    SparkleNUD.Maximum = 30;
                    break;
                case "G+":
                    SparkleNUD.Maximum = 20;
                    break;
                case "GS+":
                    SparkleNUD.Maximum = 30;
                    break;
                case "P":
                    SparkleNUD.Maximum = 20;
                    break;
                case "PS":
                    SparkleNUD.Maximum = 40;
                    break;
                default:
                    SparkleNUD.Value = 0;
                    break;
            }

            SparkleNUD.Value = int.Parse(CardInfoLV.SelectedItems[0].SubItems[4].Text);
        }

        private void AddCardInfoB_Click(object sender, EventArgs e)
        {
            int cardId = int.Parse(CardInfoLV.SelectedItems[0].SubItems[CardInfoLV.SelectedItems[0].SubItems.Count-1].Text);

                var holdCard = from hc in myCardDb.HoldCard
                               where hc.CardId == cardId
                               select hc;

            if (holdCard.Count() == 0)
            {

                HoldCard addedHoldCard = new HoldCard();

                addedHoldCard.CardId = int.Parse(CardInfoLV.SelectedItems[0].SubItems[CardInfoLV.SelectedItems[0].SubItems.Count - 1].Text);
                addedHoldCard.Sparkle = (int)SparkleNUD.Value;

                myCardDb.HoldCard.InsertOnSubmit(addedHoldCard);

            }
            else
            {
                foreach (var hc in holdCard)
                {
                    hc.Sparkle = (int)SparkleNUD.Value;
                }
            }


            MYCardDb.SubmitChanges();
        }

        private void DeleteCardInfoB_Click(object sender, EventArgs e)
        {
            int cardId = int.Parse(CardInfoLV.SelectedItems[0].SubItems[CardInfoLV.SelectedItems[0].SubItems.Count-1].Text);

            try
            {
                var holdCard = from hc in myCardDb.HoldCard
                               where hc.CardId == cardId
                               select hc;
                foreach (var hc in holdCard)
                {
                    myCardDb.HoldCard.DeleteOnSubmit(hc);
                }

                myCardDb.SubmitChanges();
            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void IdolFChB_CheckedChanged(object sender, EventArgs e)
        {
            RefreshLV();
        }

        private void RarityFChB_CheckedChanged(object sender, EventArgs e)
        {

            RefreshLV();
        }

        private void IdolCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshLV();
        }

        private void RarityCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshLV();
        }
    }
}
