﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManagerSystem.Data.Entities
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students {get; set;}

   
    }
}