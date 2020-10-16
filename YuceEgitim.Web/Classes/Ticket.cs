using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuceEgitim.Web.Classes
{
    public class Ticket : ITicket
    {
        public string IPAddress { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
    }

    public interface ITicket
    {
         string IPAddress { get; set; }
         string Method { get; set; }
         string Path { get; set; }
    }
}
