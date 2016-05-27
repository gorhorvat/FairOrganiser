using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public abstract class AbstractUser
    {

        private static AbstractMediator _mediator;

        public static AbstractMediator Mediator
        {
            get { return _mediator; }
            set { _mediator = value; }
        }
        
        public AbstractUser(AbstractMediator mediator)
        {
            Mediator = mediator;
        }


        public abstract void Receive(AbstractUser from, string message);

    }
}
