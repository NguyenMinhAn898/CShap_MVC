using Mvc.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Service
{
    public abstract class BaseService
    {
        protected DBConnect cnn = new DBConnect();
    }
}
