using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_V1.Domain.Entities
{
    public class Groups
    {
        public int GroupId { get; set; }
        public string CourseName { get; set; }
        public DateTime Commence { get; set; }
        public decimal BasePrice { get; set; }

// навигационное свойство
public ICollection<Students>? Students { get; set; }
    }
}
