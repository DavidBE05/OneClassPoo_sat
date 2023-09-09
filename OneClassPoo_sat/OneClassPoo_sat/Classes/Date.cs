using System;
using System.Collections.Generic;
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
            _year = year;
            _month = month; 
            _day = day;
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
}
