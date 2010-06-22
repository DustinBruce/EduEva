using System;

namespace EduEva.CoreData
{

    public class Age
    {
        private DateTime _today = DateTime.Today;
        private DateTime _date;
        public DateTime DateOfBirth
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                CurrentAge = _today.Subtract(value).Days / 365;
            }
        }
        public int CurrentAge { get; set; }
    }
}
