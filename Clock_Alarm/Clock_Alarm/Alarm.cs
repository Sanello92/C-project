using System;
using System.ComponentModel.DataAnnotations;

namespace Clock_Alarm

{
    public class Alarm
    {
        public event EventHandler<string> WakeUp;

        

        private int _hours;
        private int _minutes;

        public void SetAlarm(string input)
        {
            Parse(input);
            WakeUp.Invoke(this, $"Time: {_hours} : {_minutes}");
        }



        private void Parse(string input)
        {
            TimeSpan time;
            if (!TimeSpan.TryParse(input, out time))
            {
                throw new ValidationException("parsing error");
            }

            if (time.TotalDays > 0) // in case user input '24'
            {
                throw new ValidationException("parsing error");
            }

            _hours = time.Hours;
            _minutes = time.Minutes;
            
        }


    }
}