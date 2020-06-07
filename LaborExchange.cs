using System;
using System.Collections.Generic;

//Губанов Павел Романович - 2 курс, 9 группа
//Вторая лаба по C# (п. 7) - создание модели биржи труда
//  Задача реализована в автоматическом режиме (пользователю показывается "мультик",
//  после нажатия кнопки "Запуск", в котором отображаются три основных процесса,
//  присущих бирже: поступление вакансий от работодателей, поступление анкет от соискателей,
//  и подбор вакансии для каждого соискателя.

namespace Laba2_LaborExchange
{
    //Интерфейс, обозначающий основные действия для биржи
    public interface IExchange
    {
        //Регистрация соискателя на бирже
        void RegisterApplicant(Applicant jobless);
        //Удаление человека из списка соискателей 
        void RemoveApplicant(Applicant jobless);
        //Уведомление всех соискателей на бирже о доступных вакансиях
        void NotifyApplicants(ref Vacancy vacancyForView, ref Applicant applicantForView);
    }
    //Класс биржи труда
    public class LaborExchange : IExchange
    {
        List<Applicant> joblesses; //список соискателей
        List<Vacancy> vacancies; //список вакансий
        
        //Событие для отображения анкеты нового соискателя
        public event EventHandler<EventArgs> ShowApplicant;
        //Событие для отображения новой вакансии
        public event EventHandler<EventArgs> ShowVacancy;
        //Событие для отображения поиска подходящей вакансии для соискателя
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

        //Добавление нескольких вакансий для демонстрации работы биржи
        public void AddDemoVacancies(ref Vacancy vacancy)
        {
            int num = 0;
            while (num < 4)
            {
                vacancy = new Vacancy((TypeWorker)num);
                vacancies.Add(vacancy);
                OnShowVacancy();
                num++;
            }
        }

        //Добавление нескольких соискателей для демонстрации работы биржи
        public void AddDemoApplicants(ref Applicant applicant)
        {
            int num = 3;
            while (num >= 0)
            {
                applicant = new Applicant((TypeWorker)num);
                RegisterApplicant(applicant);
                OnShowApplicant();
                num--;
            }
        }

        public void NotifyApplicants(ref Vacancy vacancyForView, ref Applicant applicantForView)
        {
            Vacancy selectedVacancy;
            int i = 0;
            while (i < joblesses.Count)
            {
                applicantForView = joblesses[i];
                joblesses[i].ShowJobSelection += ShowSearchVacancyForApplicant;
                selectedVacancy = joblesses[i].SearchJob(vacancies, ref vacancyForView);
                if (selectedVacancy != null)
                {
                    RemoveApplicant(joblesses[i]);
                    vacancies.Remove(selectedVacancy);
                }
                else
                {
                    i++;
                }
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
