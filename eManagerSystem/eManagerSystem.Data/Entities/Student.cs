using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManagerSystem.Data.Entities
{
   public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int MSSV { get; set; }

        public Grade Grade { get; set; }

        public int CurrentGradeId { get; set; }
        public Subject Subject { get; set; }

        public int CurrentSubjectId { get; set; }


    }
}
