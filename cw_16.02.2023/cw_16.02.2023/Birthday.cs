using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{

    struct Birthday
    {
        DateTime Birth { get; set; }

        public Birthday(DateTime birth)
        {
            Birth = birth;
        }

        public int DaysLeft()
        {
            DateTime date = DateTime.Now;
            return Convert.ToInt32(Birth - date);
        }

        public string DayInCurrentYear(int year) 
        {
            DateTime date = DateTime.Parse(Birth.Day.ToString() + '.' + Birth.Month.ToString() +'.' + year.ToString()) ;
            return date.ToString("dddd");
        }



        public string Day()
        {
            return Birth.ToString("dddd");
        }
    }
}
