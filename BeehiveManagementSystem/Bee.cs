using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Bee : IWorker
    {
        public string Job { get; }
        public virtual float CostPerShift { get; }


        public Bee(string Name)
        {
            Job = Name;
        }
        public void WorkTheNextShift()
        {
            if(HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }
        protected virtual void DoJob() { }

    }
}
