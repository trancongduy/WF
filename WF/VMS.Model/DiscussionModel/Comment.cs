using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Model.DiscussionModel
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        [Required]
        public int UserID { get; set; }
    }
}
