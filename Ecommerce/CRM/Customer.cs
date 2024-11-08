using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    // POCO : Plain Old CLR Obj
    public class Customer
    {
        public int Id { get; set; }         //auto property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        
    }
}

//here get set methods are public and variables are private

//this is pure business entity - as it contains only data members
// used for database connection - as object can be send as one record