using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManagerSystem.Data.Entities
{
   public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
