using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    public class StatusChahgedEventArgs : EventArgs
    {
        //Estamos interessados na mensagem descrevendo o evento
        private string EventMsg;

        //Propriedade para retornar e definir uma mensagem de evento

        public string EventMessage
        {
            get { return EventMsg;  }
            set { EventMsg = value;  }
        }

        //Construtor para definir a mensagem do evento

        public StatusChahgedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}
