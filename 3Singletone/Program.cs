using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioManager.Instance.PrintSomeMusic();
            AudioManager.Instance.PrintSomeMusic();

            AudioManager.Instance.PrintSomeMusic();
            AudioManager.Instance.PrintSomeMusic();
            AudioManager.Instance.PrintSomeMusic();

        }
    }
}
