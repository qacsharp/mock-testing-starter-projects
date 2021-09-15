using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDependencyDemo
{
    public class ActivityDecider
    {
        private readonly ITimeService timeService;

        public ActivityDecider(ITimeService timeService)
        {
            this.timeService = timeService;
        }

        public ActivityDecider()
        {
            this.timeService = new PCTimeService();
        }

        public string PickActivity()
        {
            TimeSpan now = timeService.GetTimeOfDay();

            if (now.Hours >= 7 && now.Hours < 22)
                return "Eat";
            else
                return "Sleep";
        }
    }
}
