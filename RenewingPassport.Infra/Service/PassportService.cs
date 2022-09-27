using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.Infra.Service
{
    public class PassportService : IPassportService
    {
        private readonly IPassportRepository passportRepository;

        public PassportService(IPassportRepository _passportRepository)
        {
            passportRepository = _passportRepository;
        }

        public bool CreatePassport(Passport passport)
        {
            return passportRepository.CreatePassport(passport);
        }

        public bool DeletePassport(int id)
        {
            return passportRepository.DeletePassport(id);
        }

        public List<Passport> GetAllPassport()
        {
            return passportRepository.GetAllPassport();
        }

        public List<Passport> GetPassportByID(int id)
        {
            return passportRepository.GetPassportByID(id);
        }

        public List<Passport> GetPassportByStatus(string status)
        {
            return passportRepository.GetPassportByStatus(status);
        }

        public List<Passport> SearchByEndDate(Passport passport)
        {
            return passportRepository.SearchByEndDate(passport);
        }

        public List<Passport> SearchByInterval(Passport passport)
        {
            return passportRepository.SearchByInterval(passport);
        }

        public List<Passport> SearchByStartDate(Passport passport)
        {
            return passportRepository.SearchByStartDate(passport);
        }

        public bool UpdatePassport(Passport passport)
        {
            return passportRepository.UpdatePassport(passport);
        }
    }
}