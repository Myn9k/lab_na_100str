using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Worker.ViewModel;

namespace Worker.Model
{
    public class Role
    { 
        public int Id { get; set; } 
        public string NameRole { get; set; }
        public Role()
        {
            this.Persons = new HashSet<Person>();
        } 
        public virtual ICollection<Person> Persons { get; set; }

        public static implicit operator Role(PersonViewModel v) => throw new NotImplementedException();
    }
}
