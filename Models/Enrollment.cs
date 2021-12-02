using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Contoso.Models
{

    public enum Grades
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Nullable<Grades> Grade { get; set; }

        //navigation properties 

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
