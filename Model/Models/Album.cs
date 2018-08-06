using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoLink { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
