using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Singletone
{
    class AudioManager
    {
        private static AudioManager _instance = new AudioManager();
        public static AudioManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AudioManager();
                return _instance;
            }
        }

        public void Destroy()
        {
            _instance = null;
        }

        public void PrintSomeMusic()
        {
            Console.WriteLine("Yellow submarine");
        }
    }
}
