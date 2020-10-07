using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.observer
{
    public class Provider
    {
        public Provider()
        {
            Subscribers = new List<Subscriber>();
        }

        public List<Subscriber> Subscribers { get; set; }

        public void notifySubscribers()
        {
            foreach(Subscriber s in Subscribers)
            {
                s.update();
            }
        }
    }
}
