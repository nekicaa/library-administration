using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.IznajmljivanjeSO
{
    public class VratiListuIznajmljivanja : SystemOperationBase
    {
        public List<Iznajmljivanje> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Iznajmljivanje()).Cast<Iznajmljivanje>().ToList();
        }
    }
}
