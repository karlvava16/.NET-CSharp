﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
}
