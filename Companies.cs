using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba2_LaborExchange
{
    //Возможные типы работников на предприятиях
    public enum TypeWorker
    {
        FactoryWorker,
        Builder,
        Trader,
        Scientist
    }
    //Класс для создания рандомных названий компаний
    public class NamesCompanies
    {
        static readonly string[][] _names = new string[][] {
            new string[] { "MachineGroup", "ИнтерПром-Рус", "ООО \"ТермоМакс\"" },
            new string[] { "ОАО \"СтройМеханизация\"", "ООО \"МирТехСтрой\"", "\"ПромСтройМаш\"" },
            new string[] { "АШАН", "Карусель", "IKEA" },
            new string[] { "ИЮПАК", "Созвездие", "Фламена" }
        };

        public static string Get(TypeWorker worker)
        {
            int row = (int)worker;
            Random random = new Random((int)DateTime.Now.Ticks);
            int column = random.Next(_names[row].Length);
            return _names[row][column];
        }

        public static string Get(Company company)
        {
            return Get(company.Workers);
        }
    }
    //Абстрактный класс для предприятия
    public abstract class Company
    {
        //Название компании
        public string Name { get; protected set; } 
        //Тип рабочих, которые могут работать на конкретном предприятии
        public TypeWorker Workers { get; protected set; } 
        //Создание полного имени предприятия с указанием его рода деятельности
        public abstract string GetFullName();
    }

    //Класс индустриального предприятия
    public class IndustrialCompany: Company
    {
        public IndustrialCompany(string name) 
        {            
            Workers = TypeWorker.FactoryWorker;
            Name = name;
        }
        public IndustrialCompany()
        {
            Workers = TypeWorker.FactoryWorker;
            Name = NamesCompanies.Get(this);
        }
        public override string GetFullName()
        {
            return "Промышленная компания: " + Name;
        }
    }
    //Класс строительного предприятия
    public class ConstructionCompany: Company
    {
        public ConstructionCompany(string name)
        {            
            Workers = TypeWorker.Builder;
            Name = name;
        }
        public ConstructionCompany()
        {
            Workers = TypeWorker.Builder;
            Name = NamesCompanies.Get(this);
        }
        public override string GetFullName()
        {
            return "Строительная компания: " + Name;
        }
    }
    //Класс торгового предприятия
    public class TradeСompany: Company
    {
        public TradeСompany(string name)
        {
            Workers = TypeWorker.Trader;
            Name = name;
        }
        public TradeСompany()
        {
            Workers = TypeWorker.Trader;
            Name = NamesCompanies.Get(this);
        }
        public override string GetFullName()
        {
            return "Торговая компания: " + Name;
        }
    }
    //Класс научной компании
    public class ScientificCompany: Company
    {
        public ScientificCompany(string name)
        {
            Workers = TypeWorker.Scientist;
            Name = name;
        }
        public ScientificCompany()
        {
            Workers = TypeWorker.Scientist;
            Name = NamesCompanies.Get(this);
        }
        public override string GetFullName()
        {
            return "Научная компания: " + Name;
        }
    }
}
