using System;
namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            int centuryy = year / 100;
            year %= 100;
            if (year > 0)
                centuryy = centuryy + 1;
            if (centuryy == 11 || centuryy == 12 || centuryy == 13)
            {
                return centuryy + "th century";
            }
            else if (centuryy == 1 || centuryy % 10 == 1)
            {
                return centuryy + "st century";
            }
            else if (centuryy == 2 || centuryy % 10 == 2)
            {
                return centuryy + "nd century";
            }
            else if (centuryy == 3 || centuryy % 10 == 3)
            {
                return centuryy + "rd century";
            }
            else
            {
                return centuryy + "th century";
            }
        }
    }
}
