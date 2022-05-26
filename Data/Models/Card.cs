using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Card :BaseEntity
    {
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }

    }
}
