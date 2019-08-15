using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AutoPartsStore
{
    public interface IPassangerCarAttributeRepository : IRepository<PassangerCarAttribute>
    {

    }

    public class PassangerCarAttributeRepository : Repository<PassangerCarAttribute>, IPassangerCarAttributeRepository
    {
        public PassangerCarAttributeRepository (AutoStoreDBContext dBEntities) : base (dBEntities)
        {

        }
    }
}