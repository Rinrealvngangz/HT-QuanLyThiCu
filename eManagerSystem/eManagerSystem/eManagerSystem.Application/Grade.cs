using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManagerSystem.Application
{
   public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public Grade(DataRow row)
        {
            GradeId = int.Parse(row["GradeId"].ToString());
            GradeName = row["GradeName"].ToString();        
        }
    }
}
