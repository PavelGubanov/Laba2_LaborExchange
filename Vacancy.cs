using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    public class NamesVacancies
    {
        static readonly string[] _names = new string[] {
            "Требуется инженер",
            "Требуется строитель",
            "Требуется продавец",
            "Требуется геолог"
        };
        public static string Get(Company company)
        {
            return _names[(int)company.Workers];
        }
    }
    public class Vacancy
    {
        Company _company;
        IWorkExperience _workExperience;
        IEducation _education;
        string _name;

        public string Name => _name;
        public IEducation Education => _education;
        public IWorkExperience WorkExperience => _workExperience;

        public Vacancy(TypeWorker worker) 
        {
            switch (worker)
            {
                case TypeWorker.FactoryWorker:
                    _company = new IndustrialCompany();
                    break;
                case TypeWorker.Builder:
                    _company = new ConstructionCompany();
                    break;
                case TypeWorker.Trader:
                    _company = new TradeСompany();
                    break;
                case TypeWorker.Scientist:
                    _company = new ScientificCompany();
                    break;
            }
            _name = NamesCompanies.Get(_company);
            _workExperience = new WorkExperienceForVacancy();
            _education = new EducationForVacancy(worker);
        }
        public Vacancy(string name, Company company, IWorkExperience workExperience, IEducation education)
        {
            _name = name;
            _company = company;
            _workExperience = workExperience;
            _education = education;
        }

        public override string ToString()
        {
            string tmp = Name + "\n" + _company +
                         _education.GetEducationInfo() + _workExperience;
            return tmp;
        }
    }
}
