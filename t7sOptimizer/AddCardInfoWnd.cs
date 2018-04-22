using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t7sOptimizer
{
    public partial class AddCardInfoWnd : Form
    {
        private T7sDb t7SDb;
        public AddCardInfoWnd()
        {
            InitializeComponent();
        }

        internal T7sDb T7SDb { get => t7SDb; set => t7SDb = value; }

        private void AddCardInfoWnd_Load(object sender, EventArgs e)
        {
            var idolQ = from idol in t7SDb.Idol
                        orderby idol.UseCount descending,idol.IdolId
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var typeQ = from type in t7SDb.Type
                        from idol in t7SDb.Idol
                        orderby type.TypeId
                        where type.TypeId % 2 == 1 &&
                        type.TypeId != 11 &&
                        idol.IdolId == (int)IdolCB.SelectedValue &&
                        idol.BaseTypeId != type.TypeId
                        select type;


            TCCB.ValueMember = "TypeId";
            TCCB.DataSource = typeQ;
            TCCB.DisplayMember = "Name";

            RefreshLV();
        }

        private void RarityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TCCB.Enabled = ((int)RarityCB.SelectedValue) % 2 == 0 ? true : false;
            RefreshLV();
        }

        private void CardInfoLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshLV()
        {
            CardInfoLV.Items.Clear();
            try
            {
                var cardInfoQuery = from ci in t7SDb.CardInfo
                                    from idol in t7SDb.Idol
                                    from rare in t7SDb.Rarity
                                    where ci.IdolId == (int)IdolCB.SelectedValue &&
                                    ci.RarityId == (int)RarityCB.SelectedValue &&
                                    idol.IdolId == ci.IdolId &&
                                    ci.RarityId == rare.RarityId
                                    select new {IdolName = idol.Name,CardName = ci.Name,Rarity = rare.Name,ci.CardId };
                
                foreach (var i in cardInfoQuery)
                {
                    string[] addedItem = { i.IdolName, i.CardName, i.Rarity, i.CardId.ToString() };
                    CardInfoLV.Items.Add(new ListViewItem(addedItem));
                }
            }
            catch (InvalidCastException e)
            {

            }
            catch(NullReferenceException e)
            {

            }
        }

        private void AddCardInfoB_Click(object sender, EventArgs e)
        {
            CardInfo addedCardInfo = new CardInfo();
            try
            {
                addedCardInfo.CardId = (from ci in t7SDb.CardInfo
                                        select ci.CardId).Max() + 1;
            }
            catch(InvalidOperationException ioe)
            {
                addedCardInfo.CardId = 1;
            }
            
            addedCardInfo.IdolId = (int)IdolCB.SelectedValue;
            addedCardInfo.RarityId = (int)RarityCB.SelectedValue;
            addedCardInfo.Name = CardNameTB.Text;
            addedCardInfo.HP = (int)HPNUD.Value;
            addedCardInfo.ATK = (int)ATKNUD.Value;
            addedCardInfo.TCId = TCCB.Enabled ?(int)TCCB.SelectedValue:0;
            

            var addedIdol = from idol in t7SDb.Idol
                            where idol.IdolId == (int)IdolCB.SelectedValue
                            select idol;

            foreach(var upCountIdol in addedIdol)
            {
                upCountIdol.UseCount++;
            }

            var addedRarity = from rare in t7SDb.Rarity
                              where rare.RarityId == (int)RarityCB.SelectedValue
                              select rare;

            foreach (var upCountIdol in addedRarity)
            {
                upCountIdol.UseCount++;
            }

            t7SDb.CardInfo.InsertOnSubmit(addedCardInfo);
            t7SDb.SubmitChanges();

            RefreshLV();

            CardNameTB.Text = "";
            HPNUD.Value = 0;
            ATKNUD.Value = 0;
        }

        private void HPNUD_Enter(object sender, EventArgs e)
        {
           
        }

        private void DeleteCardInfoB_Click(object sender, EventArgs e)
        {

            for(int i=0;i< CardInfoLV.SelectedItems.Count; i++)
            {
                int cardId = int.Parse(CardInfoLV.SelectedItems[i].SubItems[3].Text);
                var deleteCards = from ci in t7SDb.CardInfo
                                  where ci.CardId == cardId
                                  select ci;

                foreach (var deleteCard in deleteCards)
                {
                    t7SDb.CardInfo.DeleteOnSubmit(deleteCard);
                }

                var addedIdol = from idol in t7SDb.Idol
                                from ci in t7SDb.CardInfo
                                where idol.IdolId == (int)IdolCB.SelectedValue &&
                                cardId == ci.CardId &&
                                ci.IdolId == idol.IdolId
                                select idol;

                foreach (var upCountIdol in addedIdol)
                {
                    upCountIdol.UseCount--;
                }

                var addedRarity = from rare in t7SDb.Rarity
                                  from ci in t7SDb.CardInfo
                                  where rare.RarityId == (int)RarityCB.SelectedValue &&
                                  cardId == ci.CardId &&
                                  ci.RarityId==rare.RarityId
                                  select rare;

                foreach (var upCountIdol in addedRarity)
                {
                    upCountIdol.UseCount--;
                }
            }
            t7SDb.SubmitChanges();

            RefreshLV();
        }
    }
}
