using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnIE103.DTO
{
    internal class CheckInAndOutDate
    {
        private DateTime checkInTime;
        private DateTime checkOutTime;
        private TimeSpan workTime;
        private double workTimeDay;
        public DateTime CheckInTime { get => checkInTime; set => checkInTime = value; }
        public DateTime CheckOutTime { get => checkOutTime; set => checkOutTime = value; }
        public TimeSpan WorkTime { get => workTime; set => workTime = value; }
        public double WorkTimeDay { get => workTimeDay; set => workTimeDay = value; }

        public CheckInAndOutDate() { }
        public CheckInAndOutDate(DateTime ckInTime, DateTime ckOutTime) 
        {
            checkInTime = ckInTime;
            checkOutTime = ckOutTime;
            workTime = ckOutTime - ckInTime;
            workTimeDay = workTime.TotalDays;
        }
    }
}
