using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeApp
{
    public class TimeClass
    {
        public struct Time
        {
            private int _secondsSinceMidnight;
            private const int _maxSeconds = 86400;

            public int Hour
            {
                set
                {
                    int hour = value;
                    int temp = _secondsSinceMidnight % 3600;
                    _secondsSinceMidnight = (temp + hour * 3600) % _maxSeconds;
                }
                readonly get { return _secondsSinceMidnight / 3600; }
            }
            public int Minute
            {
                set
                {
                    int minute = value;
                    int temp = _secondsSinceMidnight % 3600;
                    _secondsSinceMidnight = (temp + minute * 60) % _maxSeconds;
                }
                readonly get { return _secondsSinceMidnight % 3600 / 60; }
            }

            public int Second
            {
                set
                {
                    int second = value;
                    _secondsSinceMidnight = _secondsSinceMidnight % 3600 + second;
                }
                readonly get { return _secondsSinceMidnight % 60; }
            }

            public Time(String time)
            {
                String hour = time.Substring(0, 2);
                String minute = time.Substring(3, 2);
                String second = time.Substring(6, 2);
                _secondsSinceMidnight = 0;
                Second = Int32.Parse(second);
                Minute = Int32.Parse(minute);
                Hour = Int32.Parse(hour);
            }

            public override String ToString()
            {
                return $"{Hour:D2}:{Minute:D2}:{Second:D2}, from midnight is {_secondsSinceMidnight}";
            }


        }
    }
}
