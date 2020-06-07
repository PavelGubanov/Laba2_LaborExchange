using System;
using System.Threading;

namespace Laba2_LaborExchange
{

    public class Presenter
    {
        IView _view; // элемент отображения модели
        LaborExchange _laborExchange = new LaborExchange(); //модель биржи труда

        Vacancy vacancy; 
        Applicant applicant;

        public void AddDemoVacancies()
        {
            _laborExchange.AddDemoVacancies(ref vacancy);
        }

        public void AddDemoApplicants()
        {
           _laborExchange.AddDemoApplicants(ref applicant); 
        }

        public void DemoStaffRecruitment()
        {
            _laborExchange.NotifyApplicants(ref vacancy, ref applicant);             
        }

        private void AddVacancy(object e, EventArgs eventArgs)
        {
            _view.AddVacancy(vacancy);
        }

        private void AddApplicant(object e, EventArgs eventArgs)
        {
            _view.AddApplicant(applicant);
        }

        private void CompareVacancyAndApplicant(object e, EventArgs eventArgs)
        {
            _view.SearchVacancyForApplicant(vacancy, applicant);
        }


        public Presenter(IView view)
        {
            _view = view;
            //Поток, отображающий поступление вакансий на биржу
            Thread ProcessReceiptingVacancies = new Thread(AddDemoVacancies);
            //Поток, отображающий поступление анкет соискателей на биржу
            Thread ProcessAdmissionApplicants = new Thread(AddDemoApplicants);
            //Поток, отображающий процесс подбора вакансии для каждого соискателя
            Thread ProcessRecruitment = new Thread(DemoStaffRecruitment);

            _laborExchange.ShowVacancy += new EventHandler<EventArgs>(AddVacancy);
            ProcessReceiptingVacancies.Start();
            ProcessReceiptingVacancies.Join();
            Thread.Sleep(2000);

            _laborExchange.ShowApplicant += new EventHandler<EventArgs>(AddApplicant);
            ProcessAdmissionApplicants.Start();
            ProcessAdmissionApplicants.Join();
            Thread.Sleep(2000);
            
            _laborExchange.ShowSearchVacancyForApplicant += new EventHandler<EventArgs>(CompareVacancyAndApplicant);
            ProcessRecruitment.Start();
            ProcessRecruitment.Join();
        }
    }
}
