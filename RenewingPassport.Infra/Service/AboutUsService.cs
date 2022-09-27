using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository repo;

        public AboutUsService(IAboutUsRepository repo)
        {
            this.repo = repo;
        }

        public bool CreateAboutUsPage(AboutUsPage aboutuspage)
        {
           return repo.CreateAboutUsPage(aboutuspage);
        }

        public bool DeleteAboutUsPage(int id)
        {
            return repo.DeleteAboutUsPage(id);
        }

        public AboutUsPage GetAboutUsPageByID(int id)
        {
            return repo.GetAboutUsPageByID(id);
        }

        public List<AboutUsPage> GetAllAboutUsPage()
        {
            return repo.GetAllAboutUsPage();
        }

        public bool UpdateAboutUsPage(AboutUsPage aboutuspage)
        {
            return repo.UpdateAboutUsPage(aboutuspage);
        }
    }
}
