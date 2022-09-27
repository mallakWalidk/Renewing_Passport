using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository repo;

        public RoleService(IRoleRepository repo)
        {
            this.repo = repo;
        }
        public List<Role> GetAllRole()
        {
            return repo.GetAllRole();
        }

        public Role GetById(int id)
        {
            return repo.GetById(id);
        }
    }
}
