﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.DataAccessLayer.DataContext;

namespace AngularDemo.DataAccessLayer.IDataAccess
{
  public  interface IUserDataAccess
    {
        IEnumerable<User> GetUsers();
    }
}
