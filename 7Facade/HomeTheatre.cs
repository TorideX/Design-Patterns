using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Facade
{
    class HomeTheatre
    {
        DVD _dvd;
        Projector _projector;
        PopcornMaker _popcornMaker;

        public HomeTheatre(DVD dvd, Projector projector, PopcornMaker popcornMaker)
        {
            _dvd = dvd;
            _projector = projector;
            _popcornMaker = popcornMaker;
        }

        public void WatchMovie()
        {
            _popcornMaker.Pop();
            _projector.On();
            _dvd.Play();
        }
    }
}
