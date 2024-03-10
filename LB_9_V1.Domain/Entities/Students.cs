using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_V1.Domain.Entities
{
    public class Students
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal IndividualPrice { get; set; }
        public string ImageFileName { get; set; }
        // Навигационные свойства
        public int GroupId { get; set; }
        public Groups Group { get; set; }
    }
}
