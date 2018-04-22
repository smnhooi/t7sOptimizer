using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using t7sOptimizer.Entity;

namespace t7sOptimizer
{
    public partial class IngWnd : Form
    {
        private T7sDb t7SDb;
        MyCardDb myCardDb;
        public IngWnd()
        {
            InitializeComponent();
        }

        internal T7sDb T7SDb { get => t7SDb; set => t7SDb = value; }
        internal MyCardDb MyCardDb { get => myCardDb; set => myCardDb = value; }

        private void IngWnd_Load(object sender, EventArgs e)
        {

            var idolQ = from idol in t7SDb.Idol
                        orderby idol.UseCount descending, idol.IdolId
                        select idol;

            IdolCB.ValueMember = "IdolId";
            IdolCB.DataSource = idolQ;
            IdolCB.DisplayMember = "Name";
        }

        private void IdolCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ingLv = from ing in myCardDb.Ing
                        where ing.IdolId == (int)IdolCB.SelectedValue
                        select ing;

            if (ingLv.Count() != 0)
            {
                foreach (var ing in ingLv)
                {
                    ATKNUD.Value = ing.ATKPercentage;
                    HPNUD.Value = ing.HPPercentage;
                }
            }
            else
            {
                ATKNUD.Value = 0;
                HPNUD.Value = 0;
            }
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            var ingLv = from ing in myCardDb.Ing
                        where ing.IdolId == (int)IdolCB.SelectedValue
                        select ing;

            if (ingLv.Count() == 0)
            {
                Ing addedIng = new Ing();
                addedIng.IdolId = (int)IdolCB.SelectedValue;
                addedIng.HPPercentage = (int)HPNUD.Value;
                addedIng.ATKPercentage = (int)ATKNUD.Value;
                myCardDb.Ing.InsertOnSubmit(addedIng);

            }
            else
            {
                foreach (var ing in ingLv)
                {
                    ing.HPPercentage = (int)HPNUD.Value;
                    ing.ATKPercentage = (int)ATKNUD.Value;
                }
            }

            myCardDb.SubmitChanges();

            Close();
        }
    }
}
