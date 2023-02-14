using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IMove
    {
        void Move();
        void Print();

        string Name { get; set; }

    }
}
