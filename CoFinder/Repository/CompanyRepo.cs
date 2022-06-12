using CoFinder.Models;

namespace CoFinder.Repository
{
    public class CompanyRepo
    {
        private readonly AppDBContext _dbContext;

        public CompanyRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(Company comapny)
        {
            _dbContext.companies.Add(comapny);
            _dbContext.SaveChanges();
        }
        public Company GetCompanyByNationalCode(string nationalCode)
        {
            return _dbContext.companies.FirstOrDefault(x => x.NationalCode.Contains(nationalCode));
        }
        public Company GetCompanyById(int companyId)
        {
            return _dbContext.companies.FirstOrDefault(x => x.Id == companyId);
        }
        
        public List<Company> GetAllCompany()
        {
            return _dbContext.companies.ToList();
        }
    }
}
