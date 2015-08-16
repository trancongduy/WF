using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Model.DiscussionModel
{
    public class Topic
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}
