using System;
using System.Collections.Generic;
using System.Linq;
using AutoPartsStore;
using Microsoft.EntityFrameworkCore;

namespace AutoPartsStore
{
    public interface IUserRepository : IRepository<User>
    {

    }

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository (AutoStoreDBContext dBEntities) : base (dBEntities)
        {

        }
    }
}