using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18._02._2023
{
    public class Guest
    {
        string FIO { get;}
        DateTime DateOfBrith;
        string Status;
        DateTime CheckInDate { get; set; }
        DateTime CheckOutDate { get; set; }
        public Guest(string fio, DateTime dateOfBirth, string status, DateTime checkInDate, DateTime checkOutDate)
        {
            FIO = fio;
            DateOfBrith = dateOfBirth;
            Status = status;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
        public string GetFio()
        {
            return FIO;
        }
        public string GetDateOfBirth()
        {
            return DateOfBrith.ToShortDateString();
        }
        public string GetStatus()
        {
            return Status;
        }
        public string GetCheckInDate()
        {
            return CheckInDate.ToShortDateString();
        }
        public string GetCheckOutDate()
        {
            return CheckOutDate.ToShortDateString();
        }
    }
}
