using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Helper;
using Worker.ViewModel;

namespace Worker.Model
{
    public class Person
    {
        public int Id { get; set; } // код 
        public int RoleId { get; set; } // код должности 
        public string FirstName { get; set; } // имя 
        public string LastName { get; set; } // фамилия сотрудника 
        public DateTime Birthday { get; set; } // дата рождения 
        public virtual Role Role { get; set; }
    }
}
