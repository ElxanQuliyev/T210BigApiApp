using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUi
{
    public class BaseManager : IBaseManager
    {
        public void Update(IEntity entity)
        {
            Console.WriteLine(entity);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity);
        }

        public void Add(IEntity entity)
        {
            Console.WriteLine("Add olundu 4%");
        }
    }
}
