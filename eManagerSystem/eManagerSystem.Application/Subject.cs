using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManagerSystem.Application
{
   public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Subject(DataRow row)
        {
            SubjectId = int.Parse(row["SubjectId"].ToString());
            SubjectName = row["SubjectName"].ToString();
        }
    }
}
