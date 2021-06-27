using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Webgood1.Models
{
    public class Coments
    {   
        public Coments()
        {
            Teachers = new List<Teacher>();
            Groups = new List<Group>();
        }
        public int Id { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public string Teacher { get; set; }
        public string Date { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Group> Groups { get; set; }


    }
}
