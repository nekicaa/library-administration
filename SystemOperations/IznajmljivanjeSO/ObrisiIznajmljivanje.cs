using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.IznajmljivanjeSO
{
    public class ObrisiIznajmljivanje : SystemOperationBase
    {
        public List<StavkaIznajmljivanja> stavke;

        protected override void ExecuteOperation(IEntity entity)
        {
            Iznajmljivanje iz = (Iznajmljivanje)entity;
            stavke = repository.GetAll(new StavkaIznajmljivanja()).Cast<StavkaIznajmljivanja>().ToList();
            foreach (StavkaIznajmljivanja si in stavke)
            {
                if(si.Iznajmljivanje.Id == iz.Id)
                {
                    repository.Delete(si);
                }
            }
            repository.Delete(iz);
        }
    }
}
