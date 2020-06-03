using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laba2_LaborExchange
{
    public interface IExchange
    {
        void RegisterApplicant(Applicant jobless);
        void RemoveApplicant(Applicant jobless);
        void NotifyApplicants();
    }
    public class LaborExchange: IExchange
    {
        List<Applicant> joblesses;
        List<Vacancy> vacancies;



        public event EventHandler<EventArgs> ShowApplicant;
        public event EventHandler<EventArgs> ShowVacancy;
        public event EventHandler<EventArgs> ShowSearchVacancyForApplicant;

        public void OnShowApplicant()
        {
            ShowApplicant(this, EventArgs.Empty);
        }
        public void OnShowVacancy()
        {
            ShowVacancy(this, EventArgs.Empty);
        }

        public LaborExchange()
        {
            joblesses = new List<Applicant>();
            vacancies = new List<Vacancy>();
        }

        public void AddDemoVacancies(ref Vacancy vacancy)
        {
            int num = 0;
            while (num < 4)
            {
                vacancy = new Vacancy((TypeWorker)num);
                vacancies.Add(vacancy);
                OnShowVacancy();
                Thread.Sleep(10000);
                num++;
            }
        }

        public void AddDemoApplicants(ref Applicant applicant)
        {
            int num = 3;
            while (num >= 1)
            {
                applicant = new Applicant((TypeWorker)num);
                RegisterApplicant(applicant);
                OnShowApplicant();
                Thread.Sleep(10000);
                num--;
            }
        }



        public void NotifyApplicants()
        {
            foreach(Applicant jobless in joblesses)
            {
                jobless.SearchJob(vacancies);
            }
        }

        public void RegisterApplicant(Applicant jobless)
        {
            joblesses.Add(jobless);
        }

        public void RemoveApplicant(Applicant jobless)
        {
            joblesses.Remove(jobless);
        }
    }
}
