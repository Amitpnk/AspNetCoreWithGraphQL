namespace GraphQlProject.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public int PartySize{ get; set; }
        public string SpecialRequest { get; set; }
        public DateTime ReservatinDate { get; set; }

    }
}
