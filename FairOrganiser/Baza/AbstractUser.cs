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
        
        public AbstractUser(AbstractMediator mediator)
        {
            _mediator = mediator;
        }
        
        public AbstractMediator Mediator
        {
            get { return _mediator; }
            set { _mediator = value; }
        }

        public abstract void Send(AbstractUser user, string message);
        public abstract void Receive(AbstractUser user);


    }
}
