using CoFinder.Models;
using CoFinder.Repository;

namespace CoFinder.Service
{
    public class CompanyService
    {
        private readonly CompanyRepo companyRepo;

        public CompanyService(CompanyRepo companyRepo)
        {
            this.companyRepo = companyRepo;
        }

        public void RegisterCompany(Comapny_VM comapny_VM)
        {
            Company company = new Company();

            company.Name= comapny_VM.Name;
            company.RegisterNumber = comapny_VM.RegisterNumber;
            company.CompanyRegisterDate = comapny_VM.CompanyRegisterDate;
            company.NationalCode = comapny_VM.NationalCode;
            company.Address = comapny_VM.Address;
            company.Phone = comapny_VM.Phone;
            company.ActivityField = comapny_VM.ActivityField;
            company.ManagerName = comapny_VM.ManagerName;
            company.CompanyType = comapny_VM.CompanyType;

            company.RegisterDate=DateTime.Now;

            companyRepo.Insert(company);
        }

        public Company GetCompany(string nationalCode)
        {
            if (!string.IsNullOrEmpty(nationalCode))
            {
                Company result = companyRepo.GetCompanyByNationalCode(nationalCode);
                return result;
            }
            else return null;
        }
    }
}
