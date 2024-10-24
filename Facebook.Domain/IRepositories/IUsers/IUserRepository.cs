﻿using Facebook.Domain.Entities;
using Facebook.Domain.IRepositories.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Domain.IRepositories.Users
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
    }
}
