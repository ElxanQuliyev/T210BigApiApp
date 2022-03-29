using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUi
{
    public interface IBaseManager
    {
        void Add(IEntity entity);
        void Update(IEntity entity);

    }
}
