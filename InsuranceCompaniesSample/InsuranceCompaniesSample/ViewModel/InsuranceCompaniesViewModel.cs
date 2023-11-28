using System.Collections.ObjectModel;

namespace InsuranceCompaniesSample
{
    public class InsuranceCompaniesViewModel
    {
        public ObservableCollection<InsuranceCompany> InsuranceCompaniesList { get; set; }

        public InsuranceCompaniesViewModel()
        {
            InsuranceCompaniesList = new ObservableCollection<InsuranceCompany>
            {
                 new InsuranceCompany("Elevance Health",123.11),
                 new InsuranceCompany("Cigna",101.30),
                 new InsuranceCompany("Marsh&MC Lennan",82.07),
                 new InsuranceCompany("Progressive",75.88),
                 new InsuranceCompany("Humana",64.84),
                 new InsuranceCompany("MetLife",56.78),
                 new InsuranceCompany("American International",46.98),
                 new InsuranceCompany("Arthur J.Gallagher",39.75),
                
                
            };
        }
    }
}
