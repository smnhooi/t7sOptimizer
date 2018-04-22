using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Data.SQLite;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;

namespace t7sOptimizer
{
    public partial class MainWnd : Form
    {
        T7sDb t7SDb;
        MyCardDb myCardDb;
        OptConfig optConfig;
        Optimizer optimizer;


        public MainWnd()
        {
            InitializeComponent();

            optConfig = new OptConfig();
        }

        private void AddCardInfoB_Click(object sender, EventArgs e)
        {
            AddCardInfoWnd addCardInfoWnd = new AddCardInfoWnd();
            addCardInfoWnd.T7SDb = t7SDb;
            addCardInfoWnd.ShowDialog(this);
        }

        private void MainWnd_Load(object sender, EventArgs e)
        {
            t7SDb = new T7sDb();
            myCardDb = new MyCardDb();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMyCardWnd addMyCardWnd = new AddMyCardWnd();
            addMyCardWnd.MYCardDb = myCardDb;
            addMyCardWnd.T7SDb = t7SDb;
            addMyCardWnd.ShowDialog(this);

        }

        private void IngB_Click(object sender, EventArgs e)
        {
            IngWnd ingWnd = new IngWnd();
            ingWnd.T7SDb = t7SDb;
            ingWnd.MyCardDb = myCardDb;
            
            ingWnd.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OptimizationConfigWnd optimizationConfigWnd = new OptimizationConfigWnd();
            optimizationConfigWnd.OptConfig = optConfig;
            optimizationConfigWnd.ShowDialog(this);
        }

        private void OptB_Click(object sender, EventArgs e)
        {
            if (OptB.Text == "Optimize")
            {
                optimizer = new Optimizer(t7SDb,myCardDb);
                OptB.Text = "Cancel";
                optimizer.run();

            }
            else if (OptB.Text=="Cancel")
            {
                optimizer.cancel();
                optimizer = null;
            }
        }
    }

    class OptConfig
    {
        int minSparkle;
        int iteration=100;
        int individual=100;

        public int MinSparkle { get => minSparkle; set => minSparkle = value; }
        public int Iteration { get => iteration; set => iteration = value; }
        public int Individual { get => individual; set => individual = value; }
    }
}
