namespace CoFinder.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string CompanyRegisterDate { get; set; }
        public string EstablishmentDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ActivityField { get; set; }
        public string ManagerName { get; set; }
        public string CompanyType { get; set; }
    }
}
