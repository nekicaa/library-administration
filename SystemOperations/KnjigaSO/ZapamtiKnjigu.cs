using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.KnjigaSO
{
    public class ZapamtiKnjigu : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Knjiga k = (Knjiga)entity;
            repository.Save(entity);
            int id = repository.GetNewId(new Knjiga()) - 1;
            foreach(Izdanje i in k.Izdanje)
            {
                i.Knjiga.Id = id;
                repository.Save(i);
            }
        }
    }
}
