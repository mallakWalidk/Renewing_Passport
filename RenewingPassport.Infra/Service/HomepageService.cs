using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class HomepageService: IHomepageService
    {
        private readonly IHomepageRepository repo;

        public HomepageService(IHomepageRepository repo)
        {
             this.repo = repo;
        }

        public bool CreateHomePage(HomePage homepage)
        {
            return repo.CreateHomePage(homepage);
        }

        public bool DeleteHomePage(int id)
        {
            return repo.DeleteHomePage(id);
        }

        public List<HomePage> GetAllHomePage()
        {
            return repo.GetAllHomePage();
        }

        public HomePage GetHomePageByID(int id)
        {
            return repo.GetHomePageByID(id);
        }

        public bool UpdateHomePage(HomePage homepage)
        {
            return repo.UpdateHomePage(homepage);
        }
    }
}
