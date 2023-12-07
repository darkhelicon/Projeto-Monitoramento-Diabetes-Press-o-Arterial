using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class ExtraEntity
    {
        public int Id { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
        public DateTime Date { get; set; }
        public string Descri { get; set; }
        public decimal Quantity { get; set; }
    }
}
