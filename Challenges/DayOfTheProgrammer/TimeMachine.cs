using System;

namespace Challenges.DayOfTheProgrammer
{
    public class TimeMachine
    {
        private readonly ICalendar _calendar;

        public TimeMachine(int year)
        {
            if (year < 1700 || year > 2700)
                throw new InvalidOperationException("This time machine can only travel between 1700 & 2700");

            if (year < 1917)
                this._calendar = new JulianCalendarLogic(year);
            else switch (year)
            {
                case 1918:
                    this._calendar = new MixedCalendarLogic(year);
                    break;
                default:
                    this._calendar = new GregorianCalendarLogic(year);
                    break;
            }
        }

        public DateTime GetDayOfTheProgrammer()
        {
            return this._calendar.GetDayOfTheProgrammer();
        }
    }

    public interface ICalendar
    {
        int Year { get; set; }

        DateTime GetDayOfTheProgrammer();
    }

    public class JulianCalendarLogic : ICalendar
    {
        public int Year { get; set; }

        public JulianCalendarLogic(int year)
        {
            this.Year = year;
        }

        public bool IsLeapYear()
        {
            return this.Year % 4 == 0;
        }

        public DateTime GetDayOfTheProgrammer()
        {
            // is it a leap year?
            var isLeapYear = this.IsLeapYear();

            // get the potential date
            var potentialDate = new DateTime(this.Year - 1, 12, 31).AddDays(256);

            // if it's a leap year in both calendars return the potential date
            if (this.IsLeapYear() && DateTime.IsLeapYear(this.Year))
                return potentialDate;


            // if it's a leap year in the new calendar, remove that date from the count
            if (DateTime.IsLeapYear(this.Year))
                return potentialDate.AddDays(-1);

            // otherwise we can just return the potential date
            return this.IsLeapYear() ? potentialDate.AddDays(-1) : potentialDate;
        }
    }

    public class GregorianCalendarLogic : ICalendar
    {
        public int Year { get; set; }

        public GregorianCalendarLogic(int year)
        {
            this.Year = year;
        }

        public DateTime GetDayOfTheProgrammer()
        {
            return new DateTime(this.Year - 1, 12, 31).AddDays(256);
        }
    }

    public class MixedCalendarLogic : ICalendar
    {
        public int Year { get; set; }

        public MixedCalendarLogic(int year)
        {
            this.Year = year;
        }

        public DateTime GetDayOfTheProgrammer()
        {
            return new DateTime(this.Year - 1, 12, 31).AddDays(256 + 13); // 13 to account for the missing weeks
        }
    }
}
