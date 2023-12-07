using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class PersonEntity 
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Email { get; set; }
        public bool hasH { get; set; }
        public bool hasG { get; set; }
        public DateTime Date { get; set; }
        public UserEntity User { get; set; }
    }
}
