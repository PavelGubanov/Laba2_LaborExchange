using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    public class NamesApplicants
    {
        static readonly string[] _names = { "Роман", "Павел", "Иван", "Сергей", "Артём" };
        static readonly string[] _surnames = { "Смирнов", "Иванов", "Кузнецов", "Соколов", "Попов" };
        static readonly string[] _patronymics = { "Олегович", "Максимович", "Петрович", "Витальевич", "Викторович" };

        public static string Get()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return _surnames[random.Next(0, _surnames.Length)] + " " +
                   _names[random.Next(0, _names.Length)] + " " +
                   _patronymics[random.Next(0, _patronymics.Length)];
        }
    }

    public class Applicant
    {
        IEducation _education;
        IWorkExperience _workExperience;

        public IEducation Education => _education;
        public IWorkExperience WorkExperience => _workExperience;
        public string FIO { get; private set; }

        public Applicant(string fio, IEducation education, IWorkExperience workExperience)
        {
            FIO = fio;
            _education = education;
            _workExperience = workExperience;
        }
        
        public Applicant(TypeWorker worker)
        {
            FIO = NamesApplicants.Get();
            _education = new EducationForApplicant(worker);
            _workExperience = new WorkExperienceForApplicant(worker);
        }

        public Vacancy SearchJob(List<Vacancy> vacancies)
        {
            Vacancy tmp = null;
            int i = 0;
            while ((i < vacancies.Count - 1) && (tmp == null))
            {
                if (_education.GetEducationArea() == vacancies[i].Education.GetEducationArea()
                    && _workExperience.GetWorkingYears() >= vacancies[i].WorkExperience.GetWorkingYears())
                {
                    tmp = vacancies[i];
                }
                ++i;
            }
            return tmp;
        }
    }
}
