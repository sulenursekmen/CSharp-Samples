using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities
{
    public class IndividualCustomer: BaseCustomer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string NationalIdentity { get; set; }

    }
}
