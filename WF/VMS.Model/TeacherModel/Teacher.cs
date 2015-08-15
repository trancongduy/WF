using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Base;


namespace VMS.Model.TeacherModel
{
    public class Teacher
    {
        public int ID { get; set; }
        [MaxLength(10)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(10)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+(.[a-zA-Z]+\w*)+@eiu.edu.vn$")]
        public string Email { get; set; }
        [RegularExpression("^([0-9][0-9]*)$")]
        [MinLength(9)]
        [MaxLength(11)]
        [Required]
        public string PhoneNumber { get; set; }
        public VMS.Model.Enums.Enum.Status Status { get; set; }
    }
}
