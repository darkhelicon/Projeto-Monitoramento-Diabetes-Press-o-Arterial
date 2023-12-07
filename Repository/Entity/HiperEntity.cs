using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class HiperEntity
    {
        public int Id { get; set; }

        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
        public DateTime Date { get; set; }
        public decimal Sistolica { get; set; }
        public decimal Diastolica { get; set; }
        public Categoria Categoria { get; set; }
    }
}
