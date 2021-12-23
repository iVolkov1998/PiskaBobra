using System;
using System.Collections.Generic;
using System.Text;

namespace PiskaBobra.Models
{
    public class Meet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime MeetTime { get; set; }
    }
}
