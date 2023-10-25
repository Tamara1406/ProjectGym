using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace SystemOperations
{
    public abstract class BaseSO
    {
        protected AbstractBaseRepository repository;
        public AbsEntity Result { get; set; }
        public List<AbsEntity> ResultList { get; set; }
        public void ExecuteOperation()
        {
            ExecuteConcreteOperation();
        }

        protected abstract void ExecuteConcreteOperation();
    }
}
