using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilljetBokning_Labb
{
    class Person
    {

        public string FirstName{get;set;}
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("Namn:{0} {1}",FirstName,LastName);
        }

    }
}
