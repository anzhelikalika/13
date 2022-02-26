using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task5_8
{
    interface IShip
    {
        string Name { get; set; }

        string Sail();

        string Sink();
    }
}
