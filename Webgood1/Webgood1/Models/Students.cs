using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgood1.Models
{
    public class Students
    {
        public int Id { get; set; }
        public int GreadebookId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Pasword { get; set; }
        public string YearOfStudy { get; set; }
        public virtual Greadbook Greadbook { get; set; }
        public virtual Group Group { get; set; }

    }
}
