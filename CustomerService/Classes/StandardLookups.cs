using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerService.Classes
{
    public class StandardLookups
    {

        public StandardLookups(int code, string description, string value)
        {

            Code = code;
            Description = description;
            Value = value;
        }
        public int Code { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }

    }
}
