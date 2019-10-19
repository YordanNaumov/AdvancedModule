using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int DateTimeDifference(string date1, string date2)
        {
            DateTime startDate = DateTime.Parse(date1);
            DateTime endDate = DateTime.Parse(date2);

            int result = Convert.ToInt32((startDate - endDate).TotalDays); 

            return result;
        }

    }
}
