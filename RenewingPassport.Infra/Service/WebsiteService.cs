using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class WebsiteService: IWebsiteService
    {
        private readonly IWebsiteRepository repo;

        public WebsiteService(IWebsiteRepository repo)
        {
            this.repo = repo;
        }

        public bool CreateWebsitepages(WebsitePage websitepage)
        {
          return  repo.CreateWebsitepages(websitepage);
        }

        public bool DeleteWebsitepages(int id)
        {
            return repo.DeleteWebsitepages(id);
        }

        public List<WebsitePage> GetAllWebsitepages()
        {
            return repo.GetAllWebsitepages();
        }

        public WebsitePage GetById(int id)
        {
            return repo.GetById(id);
        }

        public bool UpdateWebsitepages(WebsitePage websitepage)
        {
            return repo.UpdateWebsitepages(websitepage);
        }
    }
}
