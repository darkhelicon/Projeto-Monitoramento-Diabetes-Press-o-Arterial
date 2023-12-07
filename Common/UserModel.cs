using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public DateTime Date { get; set; }
        public string ResetHash { get; set; }
        public int PersonId { get; set; }
        public PersonModel Person { get; set; }
    }
}
