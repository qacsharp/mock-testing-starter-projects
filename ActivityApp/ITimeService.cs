using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDependencyDemo
{
    public interface ITimeService
    {
        TimeSpan GetTimeOfDay();
    }
}
