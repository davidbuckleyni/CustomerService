using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerService.Classes
{
    public class StandardLookup
    {
        
            public StandardLookup(int code, string description)
            {
                Code = code;
                Description = description;
            }

            public int Code { get; set; }

            public string Description { get; set; }
         
    }
}
