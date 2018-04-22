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
    public partial class OptimizationConfigWnd : Form
    {
        OptConfig optConfig;

        public OptimizationConfigWnd()
        {
            InitializeComponent();
        }

        internal OptConfig OptConfig { get => optConfig; set => optConfig = value; }

        private void OptimizationConfigWnd_Load(object sender, EventArgs e)
        {
            SparkleNUD.Value=optConfig.MinSparkle;
            StepNUD.Value = optConfig.Iteration;
            IndividualNUD.Value = optConfig.Individual;
            MaxMemNUD.Value = optConfig.MaxMember;
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            optConfig.MinSparkle = (int)SparkleNUD.Value;
            optConfig.Iteration = (int)StepNUD.Value;
            optConfig.MaxMember = (int)MaxMemNUD.Value;
            optConfig.Individual = (int)IndividualNUD.Value;
        }
    }
}
