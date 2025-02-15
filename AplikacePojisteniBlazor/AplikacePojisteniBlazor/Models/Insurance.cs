namespace AplikacePojisteniBlazor.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public string Type { get; set; } // Typ pojištění (např. Auto, Dům)
        public decimal Premium { get; set; } // Výše pojistného
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; } // ID klienta
    }
}
