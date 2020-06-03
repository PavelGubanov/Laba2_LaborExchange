using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laba2_LaborExchange
{
    public class Presenter
    {
        IView _view;
        LaborExchange _laborExchange = new LaborExchange();

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
            _laborExchange.DemoStaffRecruitment();
        }

        private void AddVacancy(object e, EventArgs eventArgs)
        {
            _view.AddVacancy(vacancy);
        }

        private void AddApplicant(object e, EventArgs eventArgs)
        {
            _view.AddApplicant(applicant);
        }


        public Presenter(IView view)
        {
            _view = view;
            Thread ProcessReceiptingVacancies = new Thread(AddDemoVacancies);
            Thread ProcessAdmissionApplicants = new Thread(AddDemoApplicants);
            Thread ProcessRecruitment = new Thread(DemoStaffRecruitment);

            _laborExchange.ShowVacancy += new EventHandler<EventArgs>(AddVacancy);
            ProcessReceiptingVacancies.Start();
            Thread.Sleep(10000);

            _laborExchange.ShowApplicant += new EventHandler<EventArgs>(AddApplicant);
            ProcessAdmissionApplicants.Start();
            Thread.Sleep(10000);

            _laborExchange.ShowSearchVacancyForApplicant += new EventHandler<EventArgs>();
            ProcessRecruitment.Start();
            Thread.Sleep(10000);
        }
    }
}
