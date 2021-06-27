using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgood1.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int ComentsId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Greadebook { get; set; }

        public virtual Coments Coments { get; set; }

    }
}
