using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppObnova.DataLayer;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public abstract class Operation
    {
        private readonly ChinookEntities context;

        public Operation() {
            context = new ChinookEntities();
        }

        protected ChinookEntities Context => context;

        public abstract OperationResult Execute();
    }
}
