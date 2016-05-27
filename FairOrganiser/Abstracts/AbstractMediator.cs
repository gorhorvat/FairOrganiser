using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public abstract class AbstractMediator
    {

        public abstract void Send<T>(string message, List<T> values, AbstractUser from);

    }
}
