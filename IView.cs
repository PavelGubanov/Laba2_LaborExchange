using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_LaborExchange
{
    public interface IView
    {
        void AddVacancy(Vacancy vacancy);
        void AddApplicant(Applicant applicant);
        void SearchVacancyForApplicant();   
    }
}
