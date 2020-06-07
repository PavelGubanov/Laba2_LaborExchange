using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2_LaborExchange
{
    //Возможные области образования
    public enum EducationAreas
    {
        Technical, //техническое
        Construction, //строительное
        Trade, //торговое
        Scientific //научное
    }
    //Интерфейс для образования
    public interface IEducation
    {
        EducationAreas GetEducationArea();
        //Возвращает всю необходимую информацию об образовании
        string GetEducationInfo();
    }
    //Класс для хранения информации об образовании соискателя
    public class EducationForApplicant: IEducation
    {
        EducationAreas _educationArea;
        string _institution;
        string _faculty;
        string _specialty;

        public EducationAreas GetEducationArea()
        {
            return _educationArea;
        }

        public EducationForApplicant(EducationAreas educationArea, string institution, string faculty, string specialty)
        {
            _educationArea = educationArea;
            _institution = institution;
            _faculty = faculty;
            _specialty = specialty;
        }

        public EducationForApplicant(TypeWorker worker)
        {
            _educationArea = (EducationAreas)((int)worker);
            switch (worker)
            {
                case TypeWorker.FactoryWorker:
                    {
                        _institution = "ВГТУ";
                        _faculty = "Инженерные системы и сооружения";
                        _specialty = "Теплогазоснабжение и нефтегазовое дело";
                        break;
                    }
                case TypeWorker.Builder:
                    {
                        _institution = "ВГТУ";
                        _faculty = "Строительный";
                        _specialty = "Металлические и деревянные конструкции";
                        break;
                    }
                case TypeWorker.Trader:
                    {
                        _institution = "РЭУ им. Г.В. Плеханова";
                        _faculty = "Сфера обслуживания и управления";
                        _specialty = "Коммерция и товароведение";
                        break;
                    }
                case TypeWorker.Scientist:
                    {
                        _institution = "РГГРУ им. Серго Орджоникидзе";
                        _faculty = "Гидрогеологический";
                        _specialty = "Геотектоника";
                        break;
                    }
            }
        }
        public string GetEducationInfo()
        {
            string tmp = "учебное заведение - " + _institution + ", " +
                         "факультет - " + _faculty + ", " +
                         "специальность - " + _specialty;
            return tmp;
        }
    }
    //Класс для хранения информации об образовании, которое требуется в вакансии
    public class EducationForVacancy: IEducation
    {
        EducationAreas _educationArea;

        public EducationForVacancy(EducationAreas educationArea)
        {
            _educationArea = educationArea; 
        }

        public EducationForVacancy(TypeWorker worker)
        {
            _educationArea = (EducationAreas)((int)worker);
        }

        public EducationAreas GetEducationArea()
        {
            return _educationArea;
        }

        public string GetEducationInfo()
        {
            string tmp = "Требуемое образование: ";
            switch (_educationArea)
            {
                case EducationAreas.Technical:
                    tmp += "техническое";
                    break;
                case EducationAreas.Construction:
                    tmp += "строительное";
                    break;
                case EducationAreas.Trade:
                    tmp += "торговое";
                    break;
                case EducationAreas.Scientific:
                    tmp += "научное";
                    break;
            }
            return tmp;
        }
    }
}
