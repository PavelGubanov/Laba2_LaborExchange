using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_LaborExchange
{
    //Интерфейс для отображения работы модели биржи труда
    public interface IView
    {
        //Добавление новой вакансии на биржу
        void AddVacancy(Vacancy vacancy);
        //Поступление новой анкеты соискателя на биржу
        void AddApplicant(Applicant applicant);
        //Подбор вакансии для соискателя
        void SearchVacancyForApplicant(Vacancy vacancy, Applicant applicant);   
    }
}
