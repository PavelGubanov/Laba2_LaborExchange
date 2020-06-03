using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba2_LaborExchange
{
    public enum TypeWorker
    {
        FactoryWorker,
        Builder,
        Trader,
        Scientist
    }

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
    public abstract class Company
    {
        public string Name { get; protected set; }
        public TypeWorker Workers { get; protected set; }
    }

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
        public override string ToString()
        {
            return "Промышленная компания: " + Name + "\n";
        }
    }

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
        public override string ToString()
        {
            return "Строительная компания: " + Name + "\n";
        }
    }

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
        public override string ToString()
        {
            return "Торговая компания: " + Name + "\n";
        }
    }

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
        public override string ToString()
        {
            return "Научная компания: " + Name + "\n";
        }
    }
}
