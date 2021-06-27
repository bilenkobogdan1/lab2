using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgood1.Models
{
    public class Greadbook
    {
       public Greadbook()
        {
            Student = new List<Students>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        
        public string Mark { get; set; }
        public string Subject { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Students> Student { get; set; }

        
    }
}
