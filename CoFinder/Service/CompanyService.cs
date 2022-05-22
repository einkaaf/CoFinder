using CoFinder.Models;

namespace CoFinder.Service
{
    public class CompanyService
    {
        public void RegisterCompany(Comapny_VM comapny_VM)
        {
            Company company = new Company();

            company.Name= comapny_VM.Name;
            company.RegisterNumber = comapny_VM.RegisterNumber;
            company.CompanyRegisterDate = comapny_VM.CompanyRegisterDate;
            company.EstablishmentDate = comapny_VM.EstablishmentDate;
            company.NationalCode = comapny_VM.NationalCode;
            company.Address = comapny_VM.Address;
            company.Phone = comapny_VM.Phone;
            company.ActivityField = comapny_VM.ActivityField;
            company.ManagerName = comapny_VM.ManagerName;
            company.CompanyType = comapny_VM.CompanyType;

            company.RegisterDate=DateTime.Now;
        }
    }
}
