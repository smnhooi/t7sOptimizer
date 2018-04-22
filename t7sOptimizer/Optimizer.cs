using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace t7sOptimizer
{
    class Optimizer
    {
        OptConfig optConfig;
        T7sDb t7SDb;
        MyCardDb myCardDb;
        Hashtable cardCache = new Hashtable();
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken;


        public Optimizer(OptConfig optConfig,T7sDb t7SDb,MyCardDb myCardDb)
        {
            this.myCardDb =myCardDb;
            this.t7SDb = t7SDb;
            this.optConfig = optConfig;

            var myCardL = (from hc in myCardDb.HoldCard
                          select hc).ToList();

            cancellationToken = cancellationTokenSource.Token;


        }

        public void run()
        {
            Task gATask = Task.Run(() =>
             {

                 List<Unit> units = new List<Unit>(optConfig.Individual);

                 for (int i = 0; i < units.Count; i++)
                 {
                     units[i] = new Unit(optConfig.MaxMember);
                 }

                 List<Task> evalTask = new List<Task>(Environment.ProcessorCount);

                 for(int i = 0; i < optConfig.Iteration; i++)
                 {
                 }
                 
             }
            , cancellationToken);

        }

        public void cancel()
        {
            if (cancellationToken != null)
            {
                cancellationTokenSource.Cancel();
            }
        }



        class EvalTask
        {

        }
    }
}
