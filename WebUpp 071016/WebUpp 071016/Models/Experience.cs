using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUpp_071016.Models
{
    public class Experience
    {
        public string Title { get; set; }

        public string Workplace { get; set; }

        public decimal TimeStarted { get; set; }

        public decimal TimeEnded { get; set; }

        public void WorkingPeriod()
        {
            string.Format("{0}-{1}", TimeStarted, TimeEnded);
        }

    }
}