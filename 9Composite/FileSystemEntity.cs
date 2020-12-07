using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Composite
{
    public abstract class FileSystemEntity
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public abstract decimal Size { get; }
        public abstract void Move(string to);
        public abstract void Copy(string to);
        public abstract void Delete();
    }

    public class File : FileSystemEntity
    {
        public override decimal Size { get; }

        public override void Copy(string to)
        {
            Console.WriteLine("Copy");
        }

        public override void Delete()
        {
            Console.WriteLine("Delete");
        }

        public override void Move(string to)
        {
            Console.WriteLine("Move");
        }
    }

    public class Folder : FileSystemEntity
    {
        ICollection<FileSystemEntity> children;
        public override decimal Size
        {
            get
            {
                return children.Sum(i => i.Size);
            }
        }

        public override void Copy(string to)
        {
            Console.WriteLine("Copy");
        }

        public override void Delete()
        {
            Console.WriteLine("Delete");
        }

        public override void Move(string to)
        {
            Console.WriteLine("Move");
        }
    }
}
