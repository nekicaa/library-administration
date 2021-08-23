using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.IznajmljivanjeSO
{
    public class ZapamtiIznajmljivanje : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Iznajmljivanje izn = (Iznajmljivanje)entity;
            repository.Save(entity);
            int id = repository.GetNewId(new Iznajmljivanje())-1;
            foreach(StavkaIznajmljivanja si in izn.Stavke)
            {
                si.Iznajmljivanje.Id = id;
                repository.Save(si);
            }
        }
    }
}
