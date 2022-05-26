using Data.Models;
using System.Collections.Generic;

namespace Fiorello_App.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Card> Cards { get; set; }
        public List<Expert> Experts { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<Say> Says { get; set; }

        public List<Instagram> Instagrams { get; set; }



    }
}
