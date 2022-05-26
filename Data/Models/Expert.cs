using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Expert : BaseEntity
    {
        public string ImgUrl { get; set; }  
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
