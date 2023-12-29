using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konditer.Context.Contracts.Models
{
    public class Tovar : BaseEntyty
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Opis { get; set; } = string.Empty;

        /// <summary>
        /// Количество
        /// </summary>
        public int Value { get; set; }
    }
}
