﻿using Data.Infrastructure;
using Domain.Entites;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class ResourceService : Service<resource>, IResourceService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork utOfWork = new UnitOfWork(dbf);
        public ResourceService():base(utOfWork)
        {

        }
    }
}
