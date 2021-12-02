using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC_Contoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }  
        [DisplayName("LastName")]
        public string LastName { get; set; }

        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        public DateTime EnrollmentData { get; set; }

        // Relationship properties 

        public virtual ICollection<Enrollment>Enrollments { get; set; }
        public string FirstMidName { get; internal set; }
        public DateTime EnrollmentDate { get; internal set; }

        public string FullName()
        {
            return FirstName + " " + LastName; 
        }
    }
}
