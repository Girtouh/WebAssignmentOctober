using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUpp_071016.Models
{
    public class Experience
    {
        public string Title { get; set; }

        public string WorkPlace { get; set; }

        public string TimeStarted { get; set; }

        public string TimeEnded { get; set; }

        public void WorkingPeriod()
        {
            string.Format("{0}-{1}", TimeStarted, TimeEnded);
        }

    }
}