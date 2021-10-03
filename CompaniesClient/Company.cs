namespace CompaniesClient.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Country { get; set; }
        public int YearlyEarningsInUSDollars { get; set; }
        public bool IsPublic { get; set; }
    }
}