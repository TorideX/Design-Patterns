using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FileSystemEntity> list = new List<FileSystemEntity>();

            list.Add(new Folder());
            list.Add(new File());
            foreach(var item in list)
            {
                item.Move("new folder");
            }
        }
    }
}
