using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class GlicoEntity
    {
        public int Id { get; set; }

        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}
