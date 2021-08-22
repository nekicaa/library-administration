using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.AutorSO
{
    public class VratiListuAutora : SystemOperationBase
    {
        public List<Autor> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Autor()).Cast<Autor>().ToList();
        }
    }
}
