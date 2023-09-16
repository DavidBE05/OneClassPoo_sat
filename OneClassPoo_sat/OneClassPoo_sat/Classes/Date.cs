using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OneClassPoo_sat.Classes
{
    internal class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;
        #endregion

        #region Methods

        public Date(int year, int month, int day) // 05/06/2016
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month); 
            _day = ValidateDay(day, month, year);
        }

        private int ValidateDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }


            if (month == 2 && day == 29 && IsLeapYear(year))    
            {
               
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;     
            }
            else
            {
                throw new DayException(String.Format("El dia {0} no es valido para el mes {1}" , day, month));

            }

        }

        private void IsLeapYearException(bool isLeapYear, int year) 
        {
            if (!isLeapYear)
            {
                throw new YearException(String.Format("El año {0} no es bisiesto!", year));
            }
        
        }

        private bool IsLeapYear(int year)
        {
            bool isLeapYear = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            return isLeapYear;
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Exception creation
                throw new YearException(String.Format("El mes {0} no es valido!", year));

            }
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            { 
                return month;
            }
            else
            {
                //Exception creation
                throw new MonthException(String.Format("El mes {0} no es valido!", month));

            }
        }

        public override string ToString()
        {
            var dateConcatenated1 = _day + "/" + _month + "/" + _year;
            var dateConcatenated2 = $"{_day:00}/{_month:00}/{_year:0000}";
            var dateConcatenated3 = String.Format("{0:00}/{1:00}/{2:0000}", _day, _month, _year);

            return dateConcatenated3;
        }

        #endregion
    }

    [Serializable]
    internal class YearException : Exception
    {
        public YearException()
        {
        }

        public YearException(string message) : base(message)
        {
        }

        public YearException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
