using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    //Класс для получения названий конкретных вакансий для демонстрации работы биржи труда
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
    //Класс вакансии
    public class Vacancy
    {
        //Компания, которой принадлежит вакансия
        Company _company;
        //Информация о требуемом опыте работы
        IWorkExperience _workExperience;
        //Информация о необходимом образовании
        IEducation _education;
        //Название
        string _name;

        public Company Company => _company;
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
            _name = NamesVacancies.Get(_company);
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
            string tmp = Name + "\n\n" + _company.GetFullName() + "\n\n" +
                         _education.GetEducationInfo() + "\n\n" + _workExperience.GetInfo();
            return tmp;
        }
    }
}
