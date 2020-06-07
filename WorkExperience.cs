using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    //Класс для описания конкретного места работы
    public class Job
    {
        string _nameCompany; //название компании
        int _workingYears; //количество отработанных лет

        public int WorkingYears { get { return _workingYears; } }

        public Job(string nameCompany, int workingYears)
        {
            _nameCompany = nameCompany;
            _workingYears = workingYears;
        }

        public override string ToString()
        {
            return  _nameCompany + " - " + _workingYears + "\n";
        }
    }
    //Интерфейс для опыта работы
    public interface IWorkExperience
    {
        //Общее количество отработанных лет
        int GetWorkingYears();
        //Возвращает всю необходимую информацию об опыте работы
        string GetInfo();
    }
    //Класс для хранения информации об опыте работы соискателя
    public class WorkExperienceForApplicant: IWorkExperience
    {
        List<Job> jobs;

        public WorkExperienceForApplicant()
        {
            jobs = new List<Job>();
        }

        public WorkExperienceForApplicant(TypeWorker worker): this()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            if (random.Next(0,2) == 1)
            {
                AddJob(new Job(NamesCompanies.Get(worker), random.Next(1, 6)));
            }
        }

        void AddJob(Job job)
        {
            jobs.Add(job);
        }

        public int GetWorkingYears()
        {
            int tmp = 0;
            foreach (Job job in jobs)
            {
                tmp += job.WorkingYears;
            }
            return tmp;
        }

        public string GetInfo()
        {
            if (jobs.Count == 0)
            {
                return "Отсутствует";
            }
            else
            {
                string tmp = "";
                foreach (Job job in jobs)
                {
                    tmp += job;
                }
                return tmp;
            }
        }
    }
    //Класс для хранения информации о необходимом опыте работы для конкретной вакансии
    public class WorkExperienceForVacancy: IWorkExperience
    {
        int _years;

        public WorkExperienceForVacancy(int years)
        {
            _years = years;
        }

        public WorkExperienceForVacancy()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            _years = random.Next(0, 6);
        }

        public int GetWorkingYears()
        {
            return _years;
        }
        public string GetInfo()
        {
            if (_years == 0)
            {
                return "Опыт работы - не требуется";
            }
            else
            {
                return "Требуемый опыт работы - " + _years + " и более";
            }
        }
    }
}
