using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1_prg
{
    public interface IContactable
    {
        string Email
        {
            get;
            set;
        }

        string PhoneNumber
        {
            get;
            set;
        }
    }
}
