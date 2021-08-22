using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.ClanSO
{
    public class SacuvajIzmeneClana : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Update(entity);
        }
    }
}
