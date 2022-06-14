using CoFinder.Models;
using CoFinder.Repository;

namespace CoFinder.Service
{
    public class CompanyService
    {
        private readonly CompanyRepo companyRepo;
        private readonly NeshanService neshanService;
        public CompanyService(CompanyRepo companyRepo, NeshanService neshanService)
        {
            this.companyRepo = companyRepo;
            this.neshanService = neshanService;
        }

        public void RegisterCompany(Comapny_VM comapny_VM)
        {
            Company company = new Company();

            company.Name = comapny_VM.Name;
            company.RegisterNumber = comapny_VM.RegisterNumber;
            company.CompanyRegisterDate = comapny_VM.CompanyRegisterDate;
            company.NationalCode = comapny_VM.NationalCode;
            company.Address = comapny_VM.Address;
            company.Phone = comapny_VM.Phone;
            company.ActivityField = comapny_VM.ActivityField;
            company.ManagerName = comapny_VM.ManagerName;
            company.CompanyType = comapny_VM.CompanyType;
            company.CompanyEmail = comapny_VM.CompanyEmail;
            company.CompanyTitle = comapny_VM.CompanyTitle;

            company.RegisterDate = DateTime.Now;

            companyRepo.Insert(company);
        }

        public CompanySearchResult_VM SearchCompany(string nationalCode)
        {
            if (!string.IsNullOrEmpty(nationalCode))
            {
                Company companyResult = companyRepo.GetCompanyByNationalCode(nationalCode);
                Task<NeshanResponse> neshanResponse =  neshanService.GetLatLongFromAddressAsync(companyResult.Address);
                return new CompanySearchResult_VM
                {
                    Company = companyResult,
                    NeshanResponse = neshanResponse.Result
                };
            }
            else return null;
        }

        public List<Company> GetAllCompany()
        {
            return companyRepo.GetAllCompany();
        }
    }
}
