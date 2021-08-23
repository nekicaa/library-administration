using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.KnjigaSO
{
    public class ObrisiOdabranuKnjigu : SystemOperationBase
    {
        public List<Izdanje> izdanja;

        protected override void ExecuteOperation(IEntity entity)
        {
            Knjiga k = (Knjiga)entity;
            izdanja = repository.GetAll(new Izdanje()).Cast<Izdanje>().ToList();
            repository.Delete(entity);
            foreach (Izdanje i in izdanja)
            {
                if (i.Knjiga.Id == k.Id)
                {
                    repository.Delete(i);
                }
            }
        }
    }
}
