﻿using System;
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
            repository.Save(entity);
        }
    }
}
