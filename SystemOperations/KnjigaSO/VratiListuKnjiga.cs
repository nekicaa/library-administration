using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.KnjigaSO
{
    public class VratiListuKnjiga : SystemOperationBase
    {
        public List<Knjiga> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Knjiga()).Cast<Knjiga>().ToList();
        }
    }
}
