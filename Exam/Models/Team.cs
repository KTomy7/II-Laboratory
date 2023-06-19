using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
}
