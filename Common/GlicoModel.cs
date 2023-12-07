using System;

namespace Common
{
    public class GlicoModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public string Desc { get; set; }
        public decimal Quantity { get; set; }
        public string Type { get; set; }
    }
}
