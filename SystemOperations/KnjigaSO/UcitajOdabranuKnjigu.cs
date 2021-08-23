﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.KnjigaSO
{
    public class UcitajOdabranuKnjigu : SystemOperationBase
    {
        public Knjiga Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Knjiga>().ToList()[0];
            Izdanje i = new Izdanje();
            i.Uslov = $"i.KnjigaId={Result.Id}";
            Result.Izdanje = repository.GetAllWithCondition(i).Cast<Izdanje>().ToList();
        }
    }
}
