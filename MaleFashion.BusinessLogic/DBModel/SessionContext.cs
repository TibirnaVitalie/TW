using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaleFashion.Domain.Entities.User;

namespace MaleFashion.BusinessLogic.DBModel
{
     public class SessionContext : DbContext
     {
          public SessionContext() : base("name=CCToolShop")
          {
          }

          public virtual DbSet<Session> Sessions { get; set; }
     }
}
