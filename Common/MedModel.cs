using System;

namespace Common
{
    public class MedModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public string Descri { get; set; }
        public decimal Quantity { get; set; }
        public MedType Type { get; set; }
    }
}
