using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManger.codebase
{
    //Contains properties set to describe personaly information
    interface IPerson
    {
        int Age { get; set; }

        string MobilePhoneNumber { get; set; }
        string HomePhoneNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string Organization { get; set; }

        DateTime Birthday { get; set; }
    }
}
