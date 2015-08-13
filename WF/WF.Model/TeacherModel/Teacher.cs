using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Base;
namespace WF.Model.TeacherModel
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
        public Enums.Status Status { get; set; }
    }
}
