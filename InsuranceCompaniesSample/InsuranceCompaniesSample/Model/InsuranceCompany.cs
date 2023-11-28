namespace InsuranceCompaniesSample
{
    public class InsuranceCompany
    {
        public string CompaniesName { get; set; }
        public double MarketCapitalization { get; set; }

        public InsuranceCompany(string name, double capitalization)
        {
            CompaniesName = name;
            MarketCapitalization = capitalization;
        }
    }
}
