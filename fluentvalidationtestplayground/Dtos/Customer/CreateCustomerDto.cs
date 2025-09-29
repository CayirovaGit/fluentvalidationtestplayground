namespace fluentvalidationtestplayground.Dtos.Customer
{
    public class CreateCustomerDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tc { get; set; }
        public string? Phone { get; set; }
        public string Username { get; set; }
        public string? Notes { get; set; }
        public string? VatId { get; set; }
        public DateTime LastContactDate { get; set; } = DateTime.Now;
    }
}
