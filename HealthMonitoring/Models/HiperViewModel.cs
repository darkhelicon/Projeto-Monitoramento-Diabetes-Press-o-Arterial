using Common;

namespace HealthMonitoring.Models
{
    public class HiperViewModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public decimal Sistolica { get; set; }
        public decimal Diastolica { get; set; }
        public Categoria Categoria { get; set; }
    }
}
