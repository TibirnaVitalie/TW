using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaleFashion.Domain.Entities.User;

namespace MaleFashion.BusinessLogic.DBModel
{
 
     public class UserContext : DbContext
     {
          public UserContext() : base("name=MaleFashion") // connectionstring name define in your web.config
          {
          }

          public virtual DbSet<UDbTable> Users { get; set; }
     }
}
