using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoti_Find
{
    enum ActivityType//forces certain pieces of data to be used
    {
        Calm,
        Drivng,
        Workout,
        Sad,
        Chores,
        Hype
    }
    class Activity
    {
        public string ActivityName;
        public ActivityType thisActivityType;
    }
}
