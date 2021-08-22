using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.ClanSO
{
    public class VratiListuClanova : SystemOperationBase
    {
        public List<Clan> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Clan()).Cast<Clan>().ToList();
        }
    }
}
