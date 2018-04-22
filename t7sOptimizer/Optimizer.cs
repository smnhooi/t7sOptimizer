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
        T7sDb t7SDb;
        MyCardDb myCardDb;
        Hashtable cardCache = new Hashtable();
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken;


        public Optimizer(T7sDb t7SDb,MyCardDb myCardDb)
        {
            this.myCardDb =myCardDb;
            this.t7SDb = t7SDb;

            var myCardL = (from hc in myCardDb.HoldCard
                          select hc).ToList();

            cancellationToken = cancellationTokenSource.Token;


        }

        public void run()
        {
            Task gATask = Task.Run(() =>
             {
                 
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
    }
}
