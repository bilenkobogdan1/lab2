using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgood1.Models
{
    public class Group
    {
        public Group()
        {
            Greadbooks = new List<Greadbook>(); 
        }
        public int Id { get; set; }
        public int ComentsId { get; set; }
        public string Class { get; set; }
        public string YearOfStudy { get; set; }
        public string GroupComents { get; set; }
        public string UserName { get; set; }

        public virtual Coments Coments { get; set; }
        public virtual ICollection<Greadbook> Greadbooks { get; set; }
    }
}
