using Konditer.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konditer.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Pokupatel> pokupatels;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Tovar> tovars;

        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            pokupatels = new HashSet<Pokupatel>();
            postavshiks = new HashSet<Postavshik>();
            tovars = new HashSet<Tovar>();
            Seed();
        }
        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;

        public ICollection<Pokupatel> Pokupatels => pokupatels;

        public ICollection<Postavshik> Postavshiks => postavshiks;

        public ICollection<Tovar> Tovars => tovars;

        private void Seed()
        {
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ОАО Цикада",
                Description = "Накладная № 1254353554, ИНН 13141431, КПП 14321312, Адрес покупателя: Рыбинск"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ООО Цербер",
                Description = "Накладная № 3453454234, ИНН 1234543522212, КПП 135345552, Адрес покупателя: Сингапур"
            });
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Павленко Илья Евгеньевич",
                Number = 799102950,
            });
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Рукенглаз Андрей Алексеевич",
                Number = 793221122,
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "maga@mail.ru",
                Name = "Магамед Мага Магамедович",
                Adres = "Австралия, Жинь-Шинь 21",
                Index = 222233,
                Inn = 123132131,
                RS = 464563362
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "shtorm@mail.ru",
                Name = "Джонсон Джексон Шторм",
                Adres = "Китай, Хуй-Вынь",
                Index = 543523,
                Inn = 23434341,
                RS = 213125487
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Яблочное безумие",
                Opis = "Хлебное изделие с яблочным повидлом",
                Value = 35
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Торт Черепашка",
                Opis = "Шоколадная нуга, посыпка, коржик",
                Value = 2
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Арахисовое пироженное",
                Opis = "Арахис, сливки, хлеб, арахисовая паста",
                Value = 15
            });
        }
    }
}
