using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.IznajmljivanjeSO
{
    public class UcitajStavkeIznajmljivanja : SystemOperationBase
    {
        public List<StavkaIznajmljivanja> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<StavkaIznajmljivanja>().ToList();
        }
    }
}
