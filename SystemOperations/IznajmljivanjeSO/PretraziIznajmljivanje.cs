using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.IznajmljivanjeSO
{
    public class PretraziIznajmljivanje : SystemOperationBase
    {
        public List<Iznajmljivanje> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Iznajmljivanje>().ToList();
        }
    }
}
