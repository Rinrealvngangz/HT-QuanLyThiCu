using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManagerSystem.Application
{
    [Serializable]
   public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int MSSV { get; set; }
  
        public int CurrentGradeId { get; set; }

 
        public Students() { }

        public Students(DataRow row)
        {

            Id =int.Parse(row["Id"].ToString());
            FirstName = row["FirstName"].ToString();
            LastName = row["LastName"].ToString();
            MSSV = int.Parse(row["MSSV"].ToString());
            CurrentGradeId = int.Parse(row["CurrentGradeId"].ToString());
           

        }
    }
}
