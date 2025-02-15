namespace AplikacePojisteniBlazor.Models
{
    public class ClientData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<Insurance> Insurances { get; set; } = new List<Insurance>(); // Reference na pojisteni
    }
}
