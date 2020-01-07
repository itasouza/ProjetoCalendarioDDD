using System;

namespace DevIO.Business.Models
{
    public class Evento : Entity
    {
        public int EventoID { get; set; }
        public string title { get; set; }
        public string color { get; set; }
        public string url { get; set; }
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }

    }
}
