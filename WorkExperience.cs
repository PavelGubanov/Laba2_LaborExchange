using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    public class Job
    {
        string _nameCompany;
        int _workingYears;

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

    public interface IWorkExperience
    {
        int GetWorkingYears();
        string GetInfo();
    }
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
            if (random.Next(0,1) == 1)
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
                return "Опыт работы - не требуется\n";
            }
            else
            {
                return "Требуемый опыт работы - " + _years + " и более\n";
            }
        }
    }
}
