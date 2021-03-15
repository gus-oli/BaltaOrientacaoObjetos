using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaOrientacaoObjetos.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {

        }
        public Notification(string property, string messagem)
        {
            Property = property;
            Messagem = messagem;
        }

        public string Property { get; set; }
        public string Messagem { get; set; }
    }
}
