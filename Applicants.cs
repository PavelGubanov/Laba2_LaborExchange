using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    //Класс для создания рандомных ФИО соискателей
    public class NamesApplicants
    {
        static readonly string[] _names = { "Роман", "Павел", "Иван", "Сергей", "Артём" };
        static readonly string[] _surnames = { "Смирнов", "Иванов", "Кузнецов", "Соколов", "Попов" };
        static readonly string[] _patronymics = { "Олегович", "Максимович", "Петрович", "Витальевич", "Викторович" };
        static Random _random = new Random((int)DateTime.Now.Ticks); 

        public static string GetSurname()
        {
            return _surnames[_random.Next(0, _surnames.Length)];
        }
        public static string GetName()
        {
            return _names[_random.Next(0, _names.Length)];
        }
        public static string GetPatronymic()
        {
            return _patronymics[_random.Next(0, _patronymics.Length)];
        }
    }
    
    //Класс соискателя
    public class Applicant
    {
        IEducation _education; //информация об образовании
        IWorkExperience _workExperience; //информация об опыте работы
        string _surname; //фамилия
        string _name; //имя
        string _patronymic; //отчество

        public IEducation Education => _education;
        public IWorkExperience WorkExperience => _workExperience;
        public string FIO
        {
            get
            {
                return _surname + " " + _name + " " + _patronymic;
            }
        }

        public string GetInitials()
        {
            return _surname + " " + _name[0] + "." + _patronymic[0] + ".";
        }

        //Событие для отображения подбора вакансии для конкретного соискателя
        public event EventHandler<EventArgs> ShowJobSelection;

        public void OnShowJobSelection()
        {
            ShowJobSelection(this, EventArgs.Empty);
        }

        public Applicant(string surname, string name, string patronymic, IEducation education, IWorkExperience workExperience)
        {
            _surname = surname;
            _name = name;
            _patronymic = patronymic;
            _education = education;
            _workExperience = workExperience;
        }
        
        public Applicant(TypeWorker worker)
        {
            _surname = NamesApplicants.GetSurname();
            _name = NamesApplicants.GetName();
            _patronymic = NamesApplicants.GetPatronymic();            
            _education = new EducationForApplicant(worker);
            _workExperience = new WorkExperienceForApplicant(worker);
        }

        //Проверка текущего соискателя на соответствие заданной вакансии 
        public bool CheckVacancy(Vacancy vacancy)
        {
            return (_education.GetEducationArea() == vacancy.Education.GetEducationArea()
                    && _workExperience.GetWorkingYears() >= vacancy.WorkExperience.GetWorkingYears());
        }
        //Поиск подходящей вакансии из списка предоставленных
        public Vacancy SearchJob(List<Vacancy> vacancies, ref Vacancy vacancyForView)
        {
            Vacancy tmp = null;
            int i = 0;
            while ((i < vacancies.Count) && (tmp == null))
            {
                vacancyForView = vacancies[i];
                OnShowJobSelection();
                if (CheckVacancy(vacancies[i]))
                {
                    tmp = vacancies[i];
                }
                ++i;
            }
            return tmp;
        }

        public override string ToString()
        {
            string tmp = FIO + "\n\n" + "Образование:\n" + Education.GetEducationInfo() + "\n\n" +
                         "Опыт работы:\n" + WorkExperience.GetInfo();
            return tmp;
        }
    }
}   
