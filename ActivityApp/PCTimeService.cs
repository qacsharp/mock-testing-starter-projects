﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDependencyDemo
{
    class PCTimeService : ITimeService
    {
        public TimeSpan GetTimeOfDay()
        {
            return DateTime.Now.TimeOfDay;
        }
    }
}
