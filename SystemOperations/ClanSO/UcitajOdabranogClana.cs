using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.ClanSO
{
    public class UcitajOdabranogClana : SystemOperationBase
    {
        public Clan Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Clan>().ToList()[0];
        }
    }
}
