using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prison prison = new Prison();            

            prison.ShowPrisoners();

            Console.WriteLine("\nАмнистия в Арстоцке!\n");
            prison.Amnesty();

            prison.ShowPrisoners();
        }
    }

    class Prison
    {
        private List<Prisoner> _prisoners;

        public Prison()
        {
            GetPrisoners();
        }

        public List<Prisoner> GetPrisoners()
        {
            _prisoners = new List<Prisoner>
            {
                new Prisoner("Жуков Геннадий Васильевич", "Пиратство"),
                new Prisoner("Падлов Артемий Константинович", "Антиправительственное"),
                new Prisoner("Молотилов Дмитрий Алексеевич", "Шпионаж"),
                new Prisoner("Кискина Елена Романовна", "Халатность"),
                new Prisoner("Жирко Андрей Михайлович", "Антиправительственное"),
                new Prisoner("Раскольников Родион Романович", "Убийство"),
                new Prisoner("Тихоходов Евгений Дмитриевич", "Антиправительственное"),
                new Prisoner("Порошкова Дарья Азаматовна", "Богохульство"),
            };

            return _prisoners;
        }

        public void ShowPrisoners()
        {
            Console.WriteLine("СПИСОК ЗАКЛЮЧЕННЫХ: ");

            foreach (var prisoner in _prisoners)
            {
                Console.WriteLine($"{prisoner.Name}. Преступление: {prisoner.Crime}");
            }
        }

        public void Amnesty()
        {
            var refreshedPrisoners = _prisoners.Where(prisoner => prisoner.Crime != "Антиправительственное").ToList();
            _prisoners = refreshedPrisoners;
        }
    }

    class Prisoner
    {
        public Prisoner(string name, string crime)
        {
            Name = name;
            Crime = crime;
        }

        public string Name { get; private set; }
        public string Crime { get; private set; }
    }
}
