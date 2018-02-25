using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerService.Classes
{

    public abstract class ContextBase
    {
        public abstract int SaveChanges();

        protected int SaveChanges(System.Data.Entity.Core.Objects.ObjectContext context)
        {
           
                int i = context.SaveChanges();

                if (i == 0)
                    return 0;

                return 1;
         
        }
    }
}
